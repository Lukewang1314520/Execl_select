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
    public partial class PCBTraceAndUpdate : Form
    {
        public PCBTraceAndUpdate()
        {
            InitializeComponent();
        }
        DALL80 dALL80 = new DALL80();
        private void simpleButtonSelect_Click(object sender, EventArgs e)
        {
            if (workIDshow.Text!="")
            {
                string Sql = $"select WorkOrderId,ReelId,LeftCount,CreateDate from [netcoredev].[dbo].[PS_PCBLeftCount] where WorkOrderId='{workIDshow.Text}' order by CreateDate desc";
                PcbTraceView.DataSource = dALL80.Adapter(Sql);
                workIDshow.Text = "";
            }
            else
            {
                MessageBox.Show("请输入工单号！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void simpleButtonUpdate_Click(object sender, EventArgs e)
        {
            if (ReelID.Text!=""&&AmountNumber.Text!="")
            {
                DialogResult result = MessageBox.Show("确定是否修改"+ ReelID.Text+"的数量", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string Str = $"update [netcoredev].[dbo].[PS_PCBLeftCount] set LeftCount=LeftCount+'{AmountNumber.Text}' where ReelId='{ReelID.Text}'";
                    int a = dALL80.Execute(Str);
                    if (a > 0)
                    {
                        MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ReelText.Text = "";
                        AmountText.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            else
            {
                MessageBox.Show("请输入要修改的ID及其数量");
            }
        }
    }
}
