
namespace Execl_select
{
    partial class SN_PCBtrace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SNID = new DevExpress.XtraEditors.LabelControl();
            this.SNshow = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Selec_ID = new DevExpress.XtraEditors.SimpleButton();
            this.OpenExecl = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.select_One = new System.Windows.Forms.RadioButton();
            this.select_All = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.SNshow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SNID
            // 
            this.SNID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNID.Appearance.Options.UseFont = true;
            this.SNID.Location = new System.Drawing.Point(39, 191);
            this.SNID.Name = "SNID";
            this.SNID.Size = new System.Drawing.Size(48, 19);
            this.SNID.TabIndex = 13;
            this.SNID.Text = "板边码";
            // 
            // SNshow
            // 
            this.SNshow.Location = new System.Drawing.Point(100, 192);
            this.SNshow.Name = "SNshow";
            this.SNshow.Size = new System.Drawing.Size(100, 20);
            this.SNshow.TabIndex = 12;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(245, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(552, 446);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Selec_ID
            // 
            this.Selec_ID.Location = new System.Drawing.Point(100, 285);
            this.Selec_ID.Name = "Selec_ID";
            this.Selec_ID.Size = new System.Drawing.Size(100, 25);
            this.Selec_ID.TabIndex = 10;
            this.Selec_ID.Text = "查询";
            this.Selec_ID.Click += new System.EventHandler(this.Selec_ID_Click_1);
            // 
            // OpenExecl
            // 
            this.OpenExecl.Location = new System.Drawing.Point(100, 237);
            this.OpenExecl.Name = "OpenExecl";
            this.OpenExecl.Size = new System.Drawing.Size(100, 25);
            this.OpenExecl.TabIndex = 9;
            this.OpenExecl.Text = "加载Execl";
            this.OpenExecl.Click += new System.EventHandler(this.OpenExecl_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.select_One);
            this.groupBox1.Controls.Add(this.select_All);
            this.groupBox1.Location = new System.Drawing.Point(39, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择";
            // 
            // select_One
            // 
            this.select_One.AutoSize = true;
            this.select_One.Checked = true;
            this.select_One.Location = new System.Drawing.Point(33, 30);
            this.select_One.Name = "select_One";
            this.select_One.Size = new System.Drawing.Size(71, 16);
            this.select_One.TabIndex = 0;
            this.select_One.TabStop = true;
            this.select_One.Text = "单个查询";
            this.select_One.UseVisualStyleBackColor = true;
            this.select_One.CheckedChanged += new System.EventHandler(this.select_One_CheckedChanged_1);
            // 
            // select_All
            // 
            this.select_All.AutoSize = true;
            this.select_All.Location = new System.Drawing.Point(33, 76);
            this.select_All.Name = "select_All";
            this.select_All.Size = new System.Drawing.Size(71, 16);
            this.select_All.TabIndex = 1;
            this.select_All.Text = "批量查询";
            this.select_All.UseVisualStyleBackColor = true;
            this.select_All.CheckedChanged += new System.EventHandler(this.select_All_CheckedChanged_1);
            // 
            // SN_PCBtrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SNID);
            this.Controls.Add(this.SNshow);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.Selec_ID);
            this.Controls.Add(this.OpenExecl);
            this.Controls.Add(this.groupBox1);
            this.Name = "SN_PCBtrace";
            this.Text = "SN_PCBtrace";
            this.Load += new System.EventHandler(this.SN_PCBtrace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SNshow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl SNID;
        private DevExpress.XtraEditors.TextEdit SNshow;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Selec_ID;
        private DevExpress.XtraEditors.SimpleButton OpenExecl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton select_One;
        private System.Windows.Forms.RadioButton select_All;
    }
}