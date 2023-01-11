
namespace Execl_select
{
    partial class FlingMaterials
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
            this.TimeBegin = new System.Windows.Forms.DateTimePicker();
            this.TimeOver = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Materialno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.LineNumber = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.FlingMaterialsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Materialno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlingMaterialsView)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeBegin
            // 
            this.TimeBegin.CustomFormat = "yyyy-MM-dd HH:mm";
            this.TimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeBegin.Location = new System.Drawing.Point(96, 31);
            this.TimeBegin.Name = "TimeBegin";
            this.TimeBegin.Size = new System.Drawing.Size(200, 21);
            this.TimeBegin.TabIndex = 0;
            // 
            // TimeOver
            // 
            this.TimeOver.CustomFormat = "yyyy-MM-dd HH:mm";
            this.TimeOver.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeOver.Location = new System.Drawing.Point(97, 98);
            this.TimeOver.Name = "TimeOver";
            this.TimeOver.Size = new System.Drawing.Size(200, 21);
            this.TimeOver.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 23);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "起：";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(43, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 23);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "至：";
            // 
            // Materialno
            // 
            this.Materialno.Location = new System.Drawing.Point(97, 218);
            this.Materialno.Name = "Materialno";
            this.Materialno.Size = new System.Drawing.Size(100, 20);
            this.Materialno.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(43, 160);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 23);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "产线";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(43, 215);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 23);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "料号";
            // 
            // LineNumber
            // 
            this.LineNumber.Location = new System.Drawing.Point(97, 163);
            this.LineNumber.Name = "LineNumber";
            this.LineNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LineNumber.Properties.Items.AddRange(new object[] {
            "NPI1-104",
            "NPI2-114",
            "MP1-204",
            "MP2-304",
            "MP3-404",
            "MP4-214",
            "MP5-314",
            "MP6-414",
            "MP7-514",
            "MP8-614",
            "MP9-714",
            "MP10-814"});
            this.LineNumber.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.LineNumber.Size = new System.Drawing.Size(100, 20);
            this.LineNumber.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(97, 287);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "确定";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // FlingMaterialsView
            // 
            this.FlingMaterialsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlingMaterialsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FlingMaterialsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FlingMaterialsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlingMaterialsView.Location = new System.Drawing.Point(322, 2);
            this.FlingMaterialsView.Name = "FlingMaterialsView";
            this.FlingMaterialsView.RowTemplate.Height = 23;
            this.FlingMaterialsView.Size = new System.Drawing.Size(480, 446);
            this.FlingMaterialsView.TabIndex = 10;
            // 
            // FlingMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FlingMaterialsView);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.Materialno);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TimeOver);
            this.Controls.Add(this.TimeBegin);
            this.Controls.Add(this.LineNumber);
            this.Name = "FlingMaterials";
            this.Text = "FlingMaterials";
            ((System.ComponentModel.ISupportInitialize)(this.Materialno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlingMaterialsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TimeBegin;
        private System.Windows.Forms.DateTimePicker TimeOver;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit Materialno;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.ComboBoxEdit LineNumber;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView FlingMaterialsView;
    }
}