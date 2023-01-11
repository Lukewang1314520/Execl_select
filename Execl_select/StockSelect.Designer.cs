
namespace Execl_select
{
    partial class StockSelect
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
            this.StockTraceView = new System.Windows.Forms.DataGridView();
            this.simpleButtonStock = new DevExpress.XtraEditors.SimpleButton();
            this.WorkID = new DevExpress.XtraEditors.LabelControl();
            this.workIDshow = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.StockTraceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workIDshow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // StockTraceView
            // 
            this.StockTraceView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockTraceView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StockTraceView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StockTraceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockTraceView.Location = new System.Drawing.Point(247, 1);
            this.StockTraceView.Name = "StockTraceView";
            this.StockTraceView.RowTemplate.Height = 23;
            this.StockTraceView.Size = new System.Drawing.Size(533, 449);
            this.StockTraceView.TabIndex = 7;
            // 
            // simpleButtonStock
            // 
            this.simpleButtonStock.Location = new System.Drawing.Point(87, 120);
            this.simpleButtonStock.Name = "simpleButtonStock";
            this.simpleButtonStock.Size = new System.Drawing.Size(100, 23);
            this.simpleButtonStock.TabIndex = 6;
            this.simpleButtonStock.Text = "确认";
            this.simpleButtonStock.Click += new System.EventHandler(this.simpleButtonStock_Click);
            // 
            // WorkID
            // 
            this.WorkID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkID.Appearance.Options.UseFont = true;
            this.WorkID.Location = new System.Drawing.Point(26, 49);
            this.WorkID.Name = "WorkID";
            this.WorkID.Size = new System.Drawing.Size(48, 19);
            this.WorkID.TabIndex = 5;
            this.WorkID.Text = "工单号";
            // 
            // workIDshow
            // 
            this.workIDshow.Location = new System.Drawing.Point(87, 50);
            this.workIDshow.Name = "workIDshow";
            this.workIDshow.Size = new System.Drawing.Size(100, 20);
            this.workIDshow.TabIndex = 4;
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Location = new System.Drawing.Point(175, 12);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(66, 23);
            this.simpleButtonDelete.TabIndex = 8;
            this.simpleButtonDelete.Text = "删除";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // StockSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.simpleButtonDelete);
            this.Controls.Add(this.StockTraceView);
            this.Controls.Add(this.simpleButtonStock);
            this.Controls.Add(this.WorkID);
            this.Controls.Add(this.workIDshow);
            this.Name = "StockSelect";
            this.Text = "线边仓备料查询及删除";
            ((System.ComponentModel.ISupportInitialize)(this.StockTraceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workIDshow.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StockTraceView;
        private DevExpress.XtraEditors.SimpleButton simpleButtonStock;
        private DevExpress.XtraEditors.LabelControl WorkID;
        private DevExpress.XtraEditors.TextEdit workIDshow;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
    }
}