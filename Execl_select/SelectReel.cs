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
    public partial class SelectReel : Form
    {
        public SelectReel()
        {
            InitializeComponent();
        }

        private void SimpleButtonReel_Click(object sender, EventArgs e)
        {
            if (ReelIDshow.Text != "")
            {
                model.Chosetime = "2022-5月之后";
                DALL2 dALL2 = new DALL2();
                string Sql = $"select O.Timestamp,O.OperatorID,O.McID,O.Station,O.Slot,O.FeederID,O.CompID,C.CompName,O.Description from OperatorTrace O left join CompList C ON O.CompID=C.CompID where O.CompID='{ReelIDshow.Text}' order by Timestamp desc ";
                ReelTraceView.DataSource = dALL2.Adapter(Sql);
            }
            else
            {
                MessageBox.Show("请输入ReelID", "提示");
            }
        }
    }
}
