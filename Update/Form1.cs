using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Update
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 当前版本
        /// </summary>
        public string UserVersion { get; set; }

        /// <summary>
        /// 自动升级
        /// </summary>
        public bool StartUpdate { get; set; }

        string[] zips;//获取升级压缩包
        WebReference.WebService service = new WebReference.WebService();

        public Form1()
        {
            InitializeComponent();
        }


        #region 升级的功能

        /// <summary>
        /// 获取当前最新的版本
        /// </summary>
        /// <returns></returns>
        public string GetGetVersion()
        {
            try
            {
                return service.GetVersion();
            }
            catch { }
            return null;
        }

        private void Form1_Shown_1(object sender, EventArgs e)
        {
            try
            {
                label7.Text = service.Url;
                label9.Text = service.GetUrl();
                label5.Text = UserVersion;
                label4.Text = service.GetVersion();
                if (StartUpdate) ButtonUpdate_Click(null, null);
            }
            catch (Exception ex)
            {
                label4.Text = ex.Message;
            }
        }

        /// <summary>
        /// 下载ZIP压缩包到指定的目录下
        /// </summary>
        /// <param name="URL">下载的链接</param>
        /// <param name="filename">压缩包文件名，包含路径</param>
        /// <param name="prog">进度条</param>
        /// <param name="label1">进度百分比</param>
        /// <returns></returns>
        public bool DownloadFile(string URL, string filename, System.Windows.Forms.ProgressBar prog, System.Windows.Forms.Label label1)
        {
            float percent = 0;
            try
            {
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                long totalBytes = myrp.ContentLength;
                if (prog != null)
                {
                    prog.Maximum = (int)totalBytes;
                }
                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                long totalDownloadedByte = 0;
                byte[] by = new byte[1024 * 50];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;
                    so.Write(by, 0, osize);
                    if (prog != null)
                    {
                        prog.Value = (int)totalDownloadedByte;
                    }
                    osize = st.Read(by, 0, (int)by.Length);

                    percent = (float)totalDownloadedByte / (float)totalBytes * 100;
                    label1.Text = percent.ToString() + "%";
                    Application.DoEvents(); //必须加注这句代码，否则label1将因为循环执行太快而来不及显示信息
                }
                so.Close();
                st.Close();
                return true;
            }
            catch (System.Exception)
            {
                return false;
                throw;
            }
        }

        /// <summary>
        /// 解压ZIP压缩包到指定的目录下
        /// </summary>
        /// <param name="fileToUnZip"></param>
        /// <param name="zipedFolder"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool UnZip(string fileToUnZip, string zipedFolder, string password = null)
        {
            bool result = true;
            FileStream fs = null;
            ZipInputStream zipStream = null;
            ZipEntry ent = null;
            string fileName;

            if (!File.Exists(fileToUnZip)) return false;
            if (!Directory.Exists(zipedFolder)) Directory.CreateDirectory(zipedFolder);

            try
            {
                zipStream = new ZipInputStream(File.OpenRead(fileToUnZip.Trim()));
                if (!string.IsNullOrEmpty(password)) zipStream.Password = password;
                while ((ent = zipStream.GetNextEntry()) != null)
                {
                    if (!string.IsNullOrEmpty(ent.Name))
                    {
                        fileName = Path.Combine(zipedFolder, ent.Name);
                        fileName = fileName.Replace('/', '\\');
                        if (fileName.EndsWith("\\"))
                        {
                            Directory.CreateDirectory(fileName);
                            continue;
                        }
                        using (fs = File.Create(fileName))
                        {
                            int size = 1024 * 50;
                            byte[] data = new byte[size];
                            while (true)
                            {
                                size = zipStream.Read(data, 0, data.Length);
                                if (size > 0) fs.Write(data, 0, size);
                                else break;
                            }
                        }
                    }
                }
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
                if (zipStream != null)
                {
                    zipStream.Close();
                    zipStream.Dispose();
                }
                if (ent != null)
                {
                    ent = null;
                }
                GC.Collect();
                GC.Collect(1);
            }
            return result;
        }

        /// <summary>
        /// 调用系统cmd命令，执行bat命令
        /// </summary>
        /// <param name="bat"></param>
        private void cmd(string bat)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = bat;
            proc.StartInfo.WorkingDirectory = System.Windows.Forms.Application.StartupPath;
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.RedirectStandardInput = false;
            proc.StartInfo.RedirectStandardOutput = false;
            proc.StartInfo.RedirectStandardError = false;
            proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
            proc.StartInfo.CreateNoWindow = false;
            proc.Start();
            proc.Close();
        }

        /*
         软件升级方法
        1、将服务器上的升级包下载到本地NewVersions目录下
        2、解压最新程序的压缩包到NewVersions目录下
        3、执行bat脚本，然后退出当前程序
        4、bat脚本：
           1）删除当前应用程序的所有文件，不包含NewVersions目录
           2）将NewVersions目录下解压的最新程序拷贝到当前应用程序目录
           3）启动当前应用程序
         */
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (label5.Text == label4.Text)
            {
                MessageBox.Show("当前版本已是最新，无需更新.");
                return;
            }
            string str = System.Windows.Forms.Application.StartupPath + @"\NewVersions";
            if (!Directory.Exists(str)) Directory.CreateDirectory(str);

            zips = service.GetZips();
            string url = str + @"\" + zips[0];
            string DownUrl = service.GetUrl();
            bool flag = DownloadFile(DownUrl, url, this.progressBar1, label6);
            if (flag)
            {
                //// 解压到 NewVersions
                if (UnZip(url, str) == false)
                {
                    MessageBox.Show("升级包解压失败.");
                    return;
                }
                // 删除 NewVersions 下的压缩包
                System.IO.File.Delete(url);
                // 更新版本信息文件
                IniClass ini = new IniClass(System.Windows.Forms.Application.StartupPath + @"\config\UpdateVersions.ini");
                ini.IniWriteValue("UpdateVersions", "version", label4.Text);
                // 启动 bat 脚本
                cmd("reboot.bat");
                // 退出当前应用程序
                Process.GetCurrentProcess().Kill();//此方法完全奏效，绝对是完全退出。
            }
        }
        #endregion


    }
}
