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
    public partial class BatchSelect : Form
    {
        public BatchSelect()
        {
            InitializeComponent();
            

        }
        BLL BLL = new BLL();
        
        //批量查询界面展示。调用方法展示
        private void button1_Click(object sender, EventArgs e)
        {
            model.Chosetime = choseTime.Text;
            //string sql = "";
            //var imei="";
            //var weizhi = "";
            //var Listreel = new List<ReelInfo>();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory.ToString()+"using";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFile.FileName;
                DataTable excelDt = ExcelHelper.ReadFromExcel(filePath);
                if (comboBoxEdit1.Text == "IMEI 位置》QT DC LOT")
                {
                    gridControl1.DataSource = BLL.Imei_QTDCLOT(excelDt);
                    FinishNews.Text = "查询结束"; 
                    FinishNews.ForeColor = Color.Red;
                }
                else if (comboBoxEdit1.Text == "IMEI》Pannel")
                {
                    gridControl1.DataSource = BLL.imei_Pannels(excelDt);
                    FinishNews.Text = "查询结束";
                    FinishNews.ForeColor = Color.Red;
                }
                else if (comboBoxEdit1.Text == "QWSQ 位置》QT DC LOT")
                {
                    gridControl1.DataSource = BLL.QWSQ_Pannel(excelDt);
                    FinishNews.Text = "查询结束";
                    FinishNews.ForeColor = Color.Red;
                }
                else if (comboBoxEdit1.Text == "Pannel 位置》QT DC LOT")
                {
                    gridControl1.DataSource = BLL.Pannel_QTDCLOT(excelDt);
                    FinishNews.Text = "查询结束";
                    FinishNews.ForeColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("错误！请选择查询列别", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                comboBoxEdit1.Text = "";
                //FinishNews.Text = "";

                //for (int i = 0; i < excelDt.Rows.Count; i++)
                //{ 
                //    imei=excelDt.Rows[i]["IMEI"].ToString();
                //    weizhi = excelDt.Rows[i]["位置"].ToString();
                //    sql = $"select Panel from Laser_Panel_Log where MO=(select MO from Abstract_Log where IMEI='{imei}' union select MO from Abstract_Log_old where IMEI='{imei}') and PCBA_SN like '%{imei}%'";
                //    var pannel = GetALL78.Read(sql);
                //    if (pannel != "")
                //    {

                //        sql = $"select distinct C.CompName,C.MnfDate,C.LotNo from PcbTrace P,DeviceTrace D,ComponentTrace C WHERE P.DeviceID=D.DeviceID and D.CompID=C.CompID and P.McID=D.McID and  P.PcbID='{pannel}'and D.Reference='{weizhi}'";
                //        try
                //        {
                //            var show = new ReelInfo() { IMEI = imei,Pannel=pannel ,CompName = GetALL2.ReelID(sql)[0], DC = GetALL2.ReelID(sql)[1], LotNober = GetALL2.ReelID(sql)[2] };
                //            Listreel.Add(show);
                //        }
                //        catch (Exception)
                //        {

                //            MessageBox.Show(imei + "：无信息");
                //        }
                //    }

                //}

                //List<string> REEL = Execl_IMEI(excelDt);//获取EXECL表格里面的参数
                //for (int i = 0; i < REEL.Count(); i++)
                //{
                //    sql = $"select Reel,ID from ReelID  where ID='{REEL[i]}'";
                //    var reel = new ReelInfo() { IMEI = GetModel.ReelID(sql)[0], id = GetModel.ReelID(sql)[1] };
                //    Listreel.Add(reel);
                //}
                //gridControl1.DataSource = Listreel;
            }
        }
        //导出execl
        private void button2_Click(object sender, EventArgs e)
        {

            Export.ExportAll(gridControl1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choseTime.Text = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choseTime.Text = radioButton2.Text;
        }

        private void comboBoxEdit1_Click(object sender, EventArgs e)
        {
            FinishNews.Text = "";
        }
    }
    public class BLL
    {
        model model = new model();
        DALL78 GetALL78 = new DALL78();
        DALL2 GetALL2 = new DALL2();
        string Sql = "";

        //Iemi 查询料号信息
        public List<ReelInfo> Imei_QTDCLOT(DataTable dataTable)
        {

            var list = new List<ReelInfo>();
            foreach (DataRow item in dataTable.Rows)
            {
                var imei = item["IMEI"].ToString();
                var weizhi = item["位置"].ToString();
                Sql = $"exec Imei_Pannel @IMEI='{imei}'";
                var pannel = GetALL78.Read(Sql);
                if (imei != "")
                {
                    Sql = $"select distinct C.CompName,C.MnfDate,C.LotNo from PcbTrace P,DeviceTrace D,ComponentTrace C WHERE P.DeviceID=D.DeviceID and D.CompID=C.CompID and P.McID=D.McID and  P.PcbID='{pannel}'and D.Reference='{weizhi}'";
                    try
                    {
                        var show = new ReelInfo() { IMEI = imei, Pannel = pannel, CompName = GetALL2.ReelID(Sql)[0], DC = GetALL2.ReelID(Sql)[1], LotNober = GetALL2.ReelID(Sql)[2] };
                        list.Add(show);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show(imei + "：无信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            return list;
            
        }

        //Iemi 查询PCB号信息
        public List<Imei_Pannel> imei_Pannels(DataTable dataTable)
        {
            var list = new List<Imei_Pannel>();
            foreach (DataRow item in dataTable.Rows)
            {
                var Imei = item["IMEI"].ToString();
                Sql = $"exec Imei_Pannel @IMEI='{Imei}'";
                try
                {
                    var show = new Imei_Pannel() { IMEI = Imei, Pannel = GetALL78.Read(Sql)};
                    list.Add(show);
                }
                catch (Exception)
                {

                    MessageBox.Show(Imei + "：无信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            return list;
        }

        ////通过测试工单查询PCB号
        public List<QWSQ_Pannel> QWSQ_Pannel(DataTable dataTable)
        {
            var list = new List<QWSQ_Pannel>();
            foreach (DataRow item in dataTable.Rows)
            {
                var QWSQ = item["QWSQ"].ToString();
                var weizhi = item["位置"].ToString();
                Sql = $"select TOP (1) Panel from Laser_Panel_Log where MO='{QWSQ}'"; 
                var OrderID = GetALL78.Read(Sql);
                OrderID = OrderID.Substring(0, 11);
                if (OrderID != "")
                {
                    Sql = $"select distinct C.CompName,C.MnfDate,C.LotNo from PcbTrace P,DeviceTrace D,ComponentTrace C where P.DeviceID = D.DeviceID and D.CompID = C.CompID and D.McID = P.McID and P.PcbID like '{OrderID}%' and D.Reference = '{weizhi}'";
                    try
                    {
                        var show = new QWSQ_Pannel() { QWSQ = QWSQ, Order = OrderID, CompName = GetALL2.ReelID(Sql)[0], DC = GetALL2.ReelID(Sql)[1], LotNober = GetALL2.ReelID(Sql)[2] };
                        list.Add(show);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show(QWSQ + "：无信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); ;
                    }
                }
            }
            return list;
        }
        public List<ReelInfo> Pannel_QTDCLOT(DataTable dataTable)
        {
            var list = new List<ReelInfo>();
            foreach (DataRow item in dataTable.Rows)
            {
                var Pannel = item["Pannel"].ToString();
                var weizhi = item["位置"].ToString();

                Sql = $"select distinct C.CompName,C.MnfDate,C.LotNo from PcbTrace P,DeviceTrace D,ComponentTrace C WHERE P.DeviceID=D.DeviceID and D.CompID=C.CompID and P.McID=D.McID and P.PcbID='{Pannel}'and D.Reference='{weizhi}'";
                try

                {
                   var show = new ReelInfo() { Pannel = Pannel, CompName = GetALL2.ReelID(Sql)[0], DC = GetALL2.ReelID(Sql)[1], LotNober = GetALL2.ReelID(Sql)[2] };
                   list.Add(show);
                }
                catch (Exception)
                {

                   MessageBox.Show(Pannel + "：无信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            return list;
        }
    }  
}
