
namespace Execl_select
{
    partial class PCBTraceAndUpdate
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
            this.PcbTraceView = new System.Windows.Forms.DataGridView();
            this.simpleButtonUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.WorkID = new DevExpress.XtraEditors.LabelControl();
            this.workIDshow = new DevExpress.XtraEditors.TextEdit();
            this.ReelText = new DevExpress.XtraEditors.LabelControl();
            this.ReelID = new DevExpress.XtraEditors.TextEdit();
            this.AmountText = new DevExpress.XtraEditors.LabelControl();
            this.AmountNumber = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonSelect = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PcbTraceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workIDshow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbTraceView
            // 
            this.PcbTraceView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PcbTraceView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PcbTraceView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PcbTraceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PcbTraceView.Location = new System.Drawing.Point(244, 1);
            this.PcbTraceView.Name = "PcbTraceView";
            this.PcbTraceView.RowTemplate.Height = 23;
            this.PcbTraceView.Size = new System.Drawing.Size(533, 449);
            this.PcbTraceView.TabIndex = 11;
            // 
            // simpleButtonUpdate
            // 
            this.simpleButtonUpdate.Location = new System.Drawing.Point(129, 343);
            this.simpleButtonUpdate.Name = "simpleButtonUpdate";
            this.simpleButtonUpdate.Size = new System.Drawing.Size(100, 23);
            this.simpleButtonUpdate.TabIndex = 10;
            this.simpleButtonUpdate.Text = "确认修改";
            this.simpleButtonUpdate.Click += new System.EventHandler(this.simpleButtonUpdate_Click);
            // 
            // WorkID
            // 
            this.WorkID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkID.Appearance.Options.UseFont = true;
            this.WorkID.Location = new System.Drawing.Point(23, 49);
            this.WorkID.Name = "WorkID";
            this.WorkID.Size = new System.Drawing.Size(48, 19);
            this.WorkID.TabIndex = 9;
            this.WorkID.Text = "工单号";
            // 
            // workIDshow
            // 
            this.workIDshow.Location = new System.Drawing.Point(84, 50);
            this.workIDshow.Name = "workIDshow";
            this.workIDshow.Size = new System.Drawing.Size(124, 20);
            this.workIDshow.TabIndex = 8;
            // 
            // ReelText
            // 
            this.ReelText.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReelText.Appearance.Options.UseFont = true;
            this.ReelText.Location = new System.Drawing.Point(23, 141);
            this.ReelText.Name = "ReelText";
            this.ReelText.Size = new System.Drawing.Size(47, 19);
            this.ReelText.TabIndex = 13;
            this.ReelText.Text = "ReelID";
            // 
            // ReelID
            // 
            this.ReelID.Location = new System.Drawing.Point(84, 142);
            this.ReelID.Name = "ReelID";
            this.ReelID.Size = new System.Drawing.Size(124, 20);
            this.ReelID.TabIndex = 12;
            // 
            // AmountText
            // 
            this.AmountText.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountText.Appearance.Options.UseFont = true;
            this.AmountText.Location = new System.Drawing.Point(23, 230);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(32, 19);
            this.AmountText.TabIndex = 15;
            this.AmountText.Text = "数量";
            // 
            // AmountNumber
            // 
            this.AmountNumber.Location = new System.Drawing.Point(84, 231);
            this.AmountNumber.Name = "AmountNumber";
            this.AmountNumber.Size = new System.Drawing.Size(124, 20);
            this.AmountNumber.TabIndex = 14;
            // 
            // simpleButtonSelect
            // 
            this.simpleButtonSelect.Location = new System.Drawing.Point(12, 343);
            this.simpleButtonSelect.Name = "simpleButtonSelect";
            this.simpleButtonSelect.Size = new System.Drawing.Size(100, 23);
            this.simpleButtonSelect.TabIndex = 16;
            this.simpleButtonSelect.Text = "查询";
            this.simpleButtonSelect.Click += new System.EventHandler(this.simpleButtonSelect_Click);
            // 
            // PCBTraceAndUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.simpleButtonSelect);
            this.Controls.Add(this.AmountText);
            this.Controls.Add(this.AmountNumber);
            this.Controls.Add(this.ReelText);
            this.Controls.Add(this.ReelID);
            this.Controls.Add(this.PcbTraceView);
            this.Controls.Add(this.simpleButtonUpdate);
            this.Controls.Add(this.WorkID);
            this.Controls.Add(this.workIDshow);
            this.Name = "PCBTraceAndUpdate";
            this.Text = "PCB绑定查询及修改";
            ((System.ComponentModel.ISupportInitialize)(this.PcbTraceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workIDshow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PcbTraceView;
        private DevExpress.XtraEditors.SimpleButton simpleButtonUpdate;
        private DevExpress.XtraEditors.LabelControl WorkID;
        private DevExpress.XtraEditors.TextEdit workIDshow;
        private DevExpress.XtraEditors.LabelControl ReelText;
        private DevExpress.XtraEditors.TextEdit ReelID;
        private DevExpress.XtraEditors.LabelControl AmountText;
        private DevExpress.XtraEditors.TextEdit AmountNumber;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSelect;
    }
}