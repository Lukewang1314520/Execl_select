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
    class DALL2
    {
        SqlConnection connection;
        int a;
        string read = "";
        public static string conn_vManage2022 = ConfigurationManager.AppSettings["connectionstring_vManage2022"];
        public static string conn_vManage = ConfigurationManager.AppSettings["connectionstring_vManage"];
        public SqlConnection GetSqlConnection()
        {
            try
            {
                if (model.Chosetime == "2022-5月之前")
                {
                    string str = conn_vManage2022;
                    connection = new SqlConnection(str);
                    connection.Open();
                }
                else if (model.Chosetime == "2022-5月之后")
                {
                    string str = conn_vManage;
                    connection = new SqlConnection(str);
                    connection.Open();
                }
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

        public DataTable Adapter(string sql)
        {

            SqlDataAdapter dataAdapter = new SqlDataAdapter(Command(sql));
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table;
        }
        public List<string> ReelID(string sql)//读取数据库操作
        {
            var list = new List<string>();
            SqlDataReader sqlData = Command(sql).ExecuteReader();
            while (sqlData.Read())
            {
                var CompName = sqlData["CompName"].ToString();
                var MnfDate = sqlData["MnfDate"].ToString();
                var LotNo = sqlData["LotNo"].ToString();

                list.Add(CompName);
                list.Add(MnfDate);
                list.Add(LotNo);
            }
            return list;
        }
    }
}
