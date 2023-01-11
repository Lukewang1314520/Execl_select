using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Configuration;

namespace Execl_select
{
    class DALL80
    {
        string read = "";
        int a;
        SqlConnection connection;
        public static string conn = ConfigurationManager.AppSettings["connectionstring_netcoredev"];
        public SqlConnection GetSqlConnection()
        {
            try
            {
                connection = new SqlConnection(conn);
                connection.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("连接数据库失败！");
            }
            return connection;
        }

        public SqlCommand Command(string Sql)
        {
            SqlCommand sqlCommand = new SqlCommand(Sql, GetSqlConnection());
            return sqlCommand;
        }
        public DataTable Adapter(string sql)
        {

            SqlDataAdapter dataAdapter = new SqlDataAdapter(Command(sql));
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }
        public int Execute(string sql)//返回受影响的行数
        {
            try
            {
                a = Command(sql).ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("数据库反馈为空");
            }
            return a;
        }
        public string Read(string sql)
        {
            read = Command(sql).ExecuteScalar().ToString();
            return read;
        }
    }
}
