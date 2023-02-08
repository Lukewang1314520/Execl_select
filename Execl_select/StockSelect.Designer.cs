
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
            this.workIDshow = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.StockTraceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workIDshow.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.simpleButtonStock.Location = new System.Drawing.Point(12, 300);
            this.simpleButtonStock.Name = "simpleButtonStock";
            this.simpleButtonStock.Size = new System.Drawing.Size(200, 23);
            this.simpleButtonStock.TabIndex = 6;
            this.simpleButtonStock.Text = "确认";
            this.simpleButtonStock.Click += new System.EventHandler(this.simpleButtonStock_Click);
            // 
            // workIDshow
            // 
            this.workIDshow.Location = new System.Drawing.Point(12, 236);
            this.workIDshow.Name = "workIDshow";
            this.workIDshow.Size = new System.Drawing.Size(200, 20);
            this.workIDshow.TabIndex = 4;
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Location = new System.Drawing.Point(164, 12);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(77, 23);
            this.simpleButtonDelete.TabIndex = 8;
            this.simpleButtonDelete.Text = "删除";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "根据查询条件";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(37, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "ReelID";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(37, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "工单号";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // StockSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButtonDelete);
            this.Controls.Add(this.StockTraceView);
            this.Controls.Add(this.simpleButtonStock);
            this.Controls.Add(this.workIDshow);
            this.Name = "StockSelect";
            this.Text = "线边仓备料查询及删除";
            ((System.ComponentModel.ISupportInitialize)(this.StockTraceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workIDshow.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StockTraceView;
        private DevExpress.XtraEditors.SimpleButton simpleButtonStock;
        private DevExpress.XtraEditors.TextEdit workIDshow;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}