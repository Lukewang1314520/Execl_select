using DevExpress.XtraEditors;
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
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            Update.IniClass ini = new Update.IniClass(System.Windows.Forms.Application.StartupPath + @"\config\UpdateVersions.ini");
            NowVersions = ini.IniReadValue("UpdateVersions", "version");
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FeelTrace feelTrace = new FeelTrace();
            feelTrace.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FlingMaterials flingMaterials = new FlingMaterials();
            flingMaterials.ShowDialog();
        }

        private void 备料记录查询与删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockSelect stockSelect = new StockSelect();
            stockSelect.ShowDialog();
        }

        private void PCBTrace_Click(object sender, EventArgs e)
        {
            PCBTraceAndUpdate pCBTraceAndUpdate = new PCBTraceAndUpdate();
            pCBTraceAndUpdate.ShowDialog();
        }

        private void iMEI物料批量查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatchSelect batchSelect = new BatchSelect();
            batchSelect.ShowDialog();
        }

        private void SelectReelID_Click(object sender, EventArgs e)
        {
            SelectReel selectReel = new SelectReel();
            selectReel.ShowDialog();
        }

        private void pCB与板边码追溯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SN_PCBtrace sN_PCBtrace = new SN_PCBtrace();
            sN_PCBtrace.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Text ="IT自用工具 版本号——"+ NowVersions;
        }

        public string NowVersions { get; set; }
        Update.Form1 UpDate { get; set; }
        private void 检测更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UpDate == null || UpDate.IsDisposed)
            {
                UpDate = new Update.Form1();
                UpDate.ShowInTaskbar = false;
                UpDate.StartUpdate = false; // 是否启动自动升级，软件用于软件启动时自动进行版本检测、更新
                UpDate.UserVersion = NowVersions;
                UpDate.StartPosition = FormStartPosition.CenterScreen;
                UpDate.ShowDialog();
            }
            else
            {
                UpDate.Activate();
            }

        }
    }
}