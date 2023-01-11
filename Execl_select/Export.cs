using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execl_select
{
    class Export
    {
        /// <summary>
        /// 导出各种格式
        /// </summary>
        /// <param name="gridControl  数据源"></param>
        public static void ExportAll(GridControl gridControl1)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx |Text File (.txt)|*.txt |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html |Docx File (.html)|*.docx |RichText File (.rtf)|*.rtf |MhT File (.rtf)|*.mht |CSV File (.rtf)|*.csv";
                saveDialog.FileName = DateTime.Now.ToString("yyyy-MM-dd");
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xlsx":
                            gridControl1.ExportToXlsx(exportFilePath, new DevExpress.XtraPrinting.XlsxExportOptionsEx()
                            { ExportType = DevExpress.Export.ExportType.WYSIWYG });
                            break;
                        case ".pdf":
                            gridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl1.ExportToMht(exportFilePath);
                            break;
                        case ".csv":
                            gridControl1.ExportToCsv(exportFilePath);
                            break;
                        case ".docx":
                            gridControl1.ExportToDocx(exportFilePath);
                            break;
                        case ".txt":
                            gridControl1.ExportToText(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl1.ExportToRtf(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            if (DialogResult.Yes == XtraMessageBox.Show("文件已成功导出，是否打开文件?", "提示", MessageBoxButtons.YesNo))
                            {
                                System.Diagnostics.Process.Start(exportFilePath);
                            }
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public static void ExportAllFailMessage(GridControl gridControl1)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2010) (.xlsx)|*.xlsx |Text File (.txt)|*.txt |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html |Docx File (.html)|*.docx |RichText File (.rtf)|*.rtf |MhT File (.rtf)|*.mht |CSV File (.rtf)|*.csv";
                saveDialog.FileName = "FailMessage details (" + DateTime.Now.ToString("yyyy-MM-dd") + ") " + DateTime.Now.ToString("HHmm");
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xlsx":
                            gridControl1.ExportToXlsx(exportFilePath);
                            break;
                        case ".pdf":
                            gridControl1.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            gridControl1.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            gridControl1.ExportToMht(exportFilePath);
                            break;
                        case ".csv":
                            gridControl1.ExportToCsv(exportFilePath);
                            break;
                        case ".docx":
                            gridControl1.ExportToDocx(exportFilePath);
                            break;
                        case ".txt":
                            gridControl1.ExportToText(exportFilePath);
                            break;
                        case ".rtf":
                            gridControl1.ExportToRtf(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            if (DialogResult.Yes == XtraMessageBox.Show("文件已成功导出，是否打开文件?", "提示", MessageBoxButtons.YesNo))
                            {
                                System.Diagnostics.Process.Start(exportFilePath);
                            }
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
