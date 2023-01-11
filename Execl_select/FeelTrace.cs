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
    public partial class FeelTrace : Form
    {
        public FeelTrace()
        {
            InitializeComponent();
        }

        private void simpleButtonFeed_Click(object sender, EventArgs e)
        {
            DALL2 dALL2 = new DALL2();
            if (FeedIDshow.Text!="")
            {
                try
                {
                    model.Chosetime = "2022-5月之后";
                    string sql = $"select TOP(30) OO.Timestamp,OO.McID,OO.Station,OO.Slot,OO.FeederID,OO.CompID,CC.CompName,OO.Description from OperatorTrace OO left join CompList CC on OO.CompID=CC.CompID where OO.FeederID='{FeedIDshow.Text}' order by Timestamp desc";
                    FeedTraceView.DataSource = dALL2.Adapter(sql);
                }
                catch (Exception)
                {

                    MessageBox.Show("错误！！");
                }
            }
            else
            {
                MessageBox.Show("请输入飞达号！！");
            }
            FeedIDshow.Text = "";
        }
    }
}
