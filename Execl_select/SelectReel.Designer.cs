
namespace Execl_select
{
    partial class SelectReel
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
            this.ReelTraceView = new System.Windows.Forms.DataGridView();
            this.SimpleButtonReel = new DevExpress.XtraEditors.SimpleButton();
            this.ReelID = new DevExpress.XtraEditors.LabelControl();
            this.ReelIDshow = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelTraceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelIDshow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ReelTraceView
            // 
            this.ReelTraceView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReelTraceView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReelTraceView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReelTraceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReelTraceView.Location = new System.Drawing.Point(247, 1);
            this.ReelTraceView.Name = "ReelTraceView";
            this.ReelTraceView.RowTemplate.Height = 23;
            this.ReelTraceView.Size = new System.Drawing.Size(533, 449);
            this.ReelTraceView.TabIndex = 7;
            // 
            // SimpleButtonReel
            // 
            this.SimpleButtonReel.Location = new System.Drawing.Point(82, 222);
            this.SimpleButtonReel.Name = "SimpleButtonReel";
            this.SimpleButtonReel.Size = new System.Drawing.Size(143, 23);
            this.SimpleButtonReel.TabIndex = 6;
            this.SimpleButtonReel.Text = "确认";
            this.SimpleButtonReel.Click += new System.EventHandler(this.SimpleButtonReel_Click);
            // 
            // ReelID
            // 
            this.ReelID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReelID.Appearance.Options.UseFont = true;
            this.ReelID.Location = new System.Drawing.Point(21, 119);
            this.ReelID.Name = "ReelID";
            this.ReelID.Size = new System.Drawing.Size(43, 19);
            this.ReelID.TabIndex = 5;
            this.ReelID.Text = "Reelid";
            // 
            // ReelIDshow
            // 
            this.ReelIDshow.Location = new System.Drawing.Point(82, 120);
            this.ReelIDshow.Name = "ReelIDshow";
            this.ReelIDshow.Size = new System.Drawing.Size(143, 20);
            this.ReelIDshow.TabIndex = 4;
            // 
            // SelectReel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReelTraceView);
            this.Controls.Add(this.SimpleButtonReel);
            this.Controls.Add(this.ReelID);
            this.Controls.Add(this.ReelIDshow);
            this.Name = "SelectReel";
            this.Text = "SelectReel";
            ((System.ComponentModel.ISupportInitialize)(this.ReelTraceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelIDshow.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReelTraceView;
        private DevExpress.XtraEditors.SimpleButton SimpleButtonReel;
        private DevExpress.XtraEditors.LabelControl ReelID;
        private DevExpress.XtraEditors.TextEdit ReelIDshow;
    }
}