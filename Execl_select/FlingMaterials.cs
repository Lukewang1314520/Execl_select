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
    public partial class FlingMaterials : Form
    {
        public FlingMaterials()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DALL2 dALL2 = new DALL2();
            model.Chosetime = "2022-5月之后";
            TimeSpan timeSpan = TimeOver.Value - TimeBegin.Value;
            double getday = timeSpan.TotalDays;
            if (getday<10&&LineNumber.Text!=""&&Materialno.Text!="")
            {
                string Line = LineNumber.Text.Substring(LineNumber.Text.Length - 3);
                string Sql = $"select distinct CC.CompID,CC.Errors,CC.Used,CC.Amount from OperatorTrace OO,CompList CC where OO.CompID=CC.CompID and OO.Timestamp between '{TimeBegin.Value}'and '{TimeOver.Value}' and OO.McID = '{Line}' and CC.CompName = '{Materialno.Text}'";
                FlingMaterialsView.DataSource=dALL2.Adapter(Sql);
            }
            else
            {
                MessageBox.Show("填写的时间不超过10天，线体，料号参数！！！","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            LineNumber.Text = "";
            Materialno.Text = "";
        }
    }
}
