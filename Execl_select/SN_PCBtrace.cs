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
    public partial class SN_PCBtrace : Form
    {
        public SN_PCBtrace()
        {
            InitializeComponent();
        }

        private void SN_PCBtrace_Load(object sender, EventArgs e)
        {
            OpenExecl.Enabled = false;
        }
        private void select_One_CheckedChanged_1(object sender, EventArgs e)
        {
            OpenExecl.Enabled = false;
            Selec_ID.Enabled = true;
        }

        private void select_All_CheckedChanged_1(object sender, EventArgs e)
        {
            OpenExecl.Enabled = true;
            Selec_ID.Enabled = false;
        }

        private void OpenExecl_Click_1(object sender, EventArgs e)
        {
            SN_PCBBLL bLL = new SN_PCBBLL();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "using";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFile.FileName;
                DataTable excelDt = ExcelHelper.ReadFromExcel(filePath);
                gridControl1.DataSource = bLL.SN_PCBID(excelDt);
            }
        }

        private void Selec_ID_Click_1(object sender, EventArgs e)
        {
            SN_PCBBLL bLL = new SN_PCBBLL();
            if (SNshow.Text != "")
            {
                gridControl1.DataSource = bLL.SN_PCBIDone(SNshow.Text);
            }
        }

    }
    public class SN_PCBBLL
    {
        DALL80 dALL80 = new DALL80();
        string Sql = "";
        public List<SN_PCB> SN_PCBID(DataTable dataTable)
        {

            var list = new List<SN_PCB>();
            foreach (DataRow item in dataTable.Rows)
            {

                var SN = item["板边码"].ToString();
                Sql = $"exec SN_PCBID @sn={SN}";
                var show = new SN_PCB() { SN = SN, REELID = dALL80.Read(Sql) };
                list.Add(show);
            }
            return list;
        }
        public List<SN_PCB> SN_PCBIDone(string sn)
        {
            var list = new List<SN_PCB>();
            Sql = $"exec SN_PCBID @sn={sn}";
            var show = new SN_PCB() { SN = sn, REELID = dALL80.Read(Sql) };
            list.Add(show);
            return list;
        }
    }
}
