using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execl_select
{
    public partial class StockSelect : Form
    {
        public StockSelect()
        {
            InitializeComponent();
        }

        private void simpleButtonStock_Click(object sender, EventArgs e)
        {
            model.Chosetime = "2022-5月之后";
            if (workIDshow.Text!="")
            {
                try
                {
                    DALL2 dALL2 = new DALL2();
                    string Sql = $"select ID,WorkOrder,ReelID,Station,Program,CreateTime from IsFirstMaterialNo where WorkOrder='{workIDshow.Text}'";
                    StockTraceView.DataSource = dALL2.Adapter(Sql);
                }
                catch (Exception)
                {
                    MessageBox.Show("系统出错，请联系IT处理！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                }
            }
            else
            {
                MessageBox.Show("请输入工单号！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e)
        {
            model.Chosetime = "2022-5月之后";
            if (workIDshow.Text != "")
            {
                DialogResult dt= MessageBox.Show("确认是否删除！！", "警告！", MessageBoxButtons.YesNo);
                if (dt==DialogResult.Yes)
                {
                    try
                    {
                        DALL2 dALL2 = new DALL2();
                        string Sql = $"delete IsFirstMaterialNo where WorkOrder='{workIDshow.Text}'";
                        int a = dALL2.Execute(Sql);
                        if (a > 0)
                        {
                            MessageBox.Show("删除成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            MessageBox.Show("系统出错，请联系IT处理！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("系统出错，请联系IT处理！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                }
            }
            else
            {
                MessageBox.Show("请输入工单号！！！");
            }
        }
    }
}
