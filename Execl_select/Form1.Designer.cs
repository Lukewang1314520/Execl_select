
namespace Execl_select
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.备料记录查询与删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PCBTrace = new System.Windows.Forms.ToolStripMenuItem();
            this.iMEI物料批量查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectReelID = new System.Windows.Forms.ToolStripMenuItem();
            this.pCB与板边码追溯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检测更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.备料记录查询与删除ToolStripMenuItem,
            this.PCBTrace,
            this.iMEI物料批量查询ToolStripMenuItem,
            this.SelectReelID,
            this.pCB与板边码追溯ToolStripMenuItem,
            this.检测更新ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 21);
            this.toolStripMenuItem1.Text = "飞达绑定记录";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem2.Text = "抛料查询";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 备料记录查询与删除ToolStripMenuItem
            // 
            this.备料记录查询与删除ToolStripMenuItem.Name = "备料记录查询与删除ToolStripMenuItem";
            this.备料记录查询与删除ToolStripMenuItem.Size = new System.Drawing.Size(128, 21);
            this.备料记录查询与删除ToolStripMenuItem.Text = "备料记录查询与删除";
            this.备料记录查询与删除ToolStripMenuItem.Click += new System.EventHandler(this.备料记录查询与删除ToolStripMenuItem_Click);
            // 
            // PCBTrace
            // 
            this.PCBTrace.Name = "PCBTrace";
            this.PCBTrace.Size = new System.Drawing.Size(115, 21);
            this.PCBTrace.Text = "PCB绑定追溯修改";
            this.PCBTrace.Click += new System.EventHandler(this.PCBTrace_Click);
            // 
            // iMEI物料批量查询ToolStripMenuItem
            // 
            this.iMEI物料批量查询ToolStripMenuItem.Name = "iMEI物料批量查询ToolStripMenuItem";
            this.iMEI物料批量查询ToolStripMenuItem.Size = new System.Drawing.Size(119, 21);
            this.iMEI物料批量查询ToolStripMenuItem.Text = "IMEI物料批量查询";
            this.iMEI物料批量查询ToolStripMenuItem.Click += new System.EventHandler(this.iMEI物料批量查询ToolStripMenuItem_Click);
            // 
            // SelectReelID
            // 
            this.SelectReelID.Name = "SelectReelID";
            this.SelectReelID.Size = new System.Drawing.Size(82, 21);
            this.SelectReelID.Text = "ReelID查询";
            this.SelectReelID.Click += new System.EventHandler(this.SelectReelID_Click);
            // 
            // pCB与板边码追溯ToolStripMenuItem
            // 
            this.pCB与板边码追溯ToolStripMenuItem.Name = "pCB与板边码追溯ToolStripMenuItem";
            this.pCB与板边码追溯ToolStripMenuItem.Size = new System.Drawing.Size(115, 21);
            this.pCB与板边码追溯ToolStripMenuItem.Text = "PCB与板边码追溯";
            this.pCB与板边码追溯ToolStripMenuItem.Click += new System.EventHandler(this.pCB与板边码追溯ToolStripMenuItem_Click);
            // 
            // 检测更新ToolStripMenuItem
            // 
            this.检测更新ToolStripMenuItem.Name = "检测更新ToolStripMenuItem";
            this.检测更新ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.检测更新ToolStripMenuItem.Text = "检测更新";
            this.检测更新ToolStripMenuItem.Click += new System.EventHandler(this.检测更新ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 464);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "工具——IT自用";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 备料记录查询与删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PCBTrace;
        private System.Windows.Forms.ToolStripMenuItem iMEI物料批量查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectReelID;
        private System.Windows.Forms.ToolStripMenuItem pCB与板边码追溯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检测更新ToolStripMenuItem;
    }
}