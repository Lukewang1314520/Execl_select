
namespace Execl_select
{
    partial class FeelTrace
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
            this.components = new System.ComponentModel.Container();
            this.FeedIDshow = new DevExpress.XtraEditors.TextEdit();
            this.FeedID = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonFeed = new DevExpress.XtraEditors.SimpleButton();
            this.FeedTraceView = new System.Windows.Forms.DataGridView();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FeedIDshow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedTraceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // FeedIDshow
            // 
            this.FeedIDshow.Location = new System.Drawing.Point(90, 131);
            this.FeedIDshow.Name = "FeedIDshow";
            this.FeedIDshow.Size = new System.Drawing.Size(100, 20);
            this.FeedIDshow.TabIndex = 0;
            // 
            // FeedID
            // 
            this.FeedID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeedID.Appearance.Options.UseFont = true;
            this.FeedID.Location = new System.Drawing.Point(29, 130);
            this.FeedID.Name = "FeedID";
            this.FeedID.Size = new System.Drawing.Size(48, 19);
            this.FeedID.TabIndex = 1;
            this.FeedID.Text = "飞达号";
            // 
            // simpleButtonFeed
            // 
            this.simpleButtonFeed.Location = new System.Drawing.Point(90, 233);
            this.simpleButtonFeed.Name = "simpleButtonFeed";
            this.simpleButtonFeed.Size = new System.Drawing.Size(100, 23);
            this.simpleButtonFeed.TabIndex = 2;
            this.simpleButtonFeed.Text = "确认";
            this.simpleButtonFeed.Click += new System.EventHandler(this.simpleButtonFeed_Click);
            // 
            // FeedTraceView
            // 
            this.FeedTraceView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeedTraceView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FeedTraceView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FeedTraceView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedTraceView.Location = new System.Drawing.Point(255, 12);
            this.FeedTraceView.Name = "FeedTraceView";
            this.FeedTraceView.RowTemplate.Height = 23;
            this.FeedTraceView.Size = new System.Drawing.Size(533, 449);
            this.FeedTraceView.TabIndex = 3;
            // 
            // FeelTrace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeedTraceView);
            this.Controls.Add(this.simpleButtonFeed);
            this.Controls.Add(this.FeedID);
            this.Controls.Add(this.FeedIDshow);
            this.Name = "FeelTrace";
            this.Text = "FeelTrace";
            ((System.ComponentModel.ISupportInitialize)(this.FeedIDshow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FeedTraceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit FeedIDshow;
        private DevExpress.XtraEditors.LabelControl FeedID;
        private DevExpress.XtraEditors.SimpleButton simpleButtonFeed;
        private System.Windows.Forms.DataGridView FeedTraceView;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}