namespace Minecraft.UtilApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.giveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的世界ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.指令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.队伍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.commandStripMenuItem1,
            this.我的世界ToolStripMenuItem,
            this.指令ToolStripMenuItem,
            this.队伍ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // commandStripMenuItem1
            // 
            this.commandStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giveToolStripMenuItem});
            this.commandStripMenuItem1.Name = "commandStripMenuItem1";
            this.commandStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.commandStripMenuItem1.Text = "命令";
            // 
            // giveToolStripMenuItem
            // 
            this.giveToolStripMenuItem.Name = "giveToolStripMenuItem";
            this.giveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.giveToolStripMenuItem.Text = "/give";
            this.giveToolStripMenuItem.Click += new System.EventHandler(this.giveToolStripMenuItem_Click);
            // 
            // 我的世界ToolStripMenuItem
            // 
            this.我的世界ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blockToolStripMenuItem,
            this.itemToolStripMenuItem});
            this.我的世界ToolStripMenuItem.Name = "我的世界ToolStripMenuItem";
            this.我的世界ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.我的世界ToolStripMenuItem.Text = "实体";
            // 
            // blockToolStripMenuItem
            // 
            this.blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            this.blockToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.blockToolStripMenuItem.Text = "方块";
            this.blockToolStripMenuItem.Click += new System.EventHandler(this.blockToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.itemToolStripMenuItem.Text = "物品";
            // 
            // 指令ToolStripMenuItem
            // 
            this.指令ToolStripMenuItem.Name = "指令ToolStripMenuItem";
            this.指令ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.指令ToolStripMenuItem.Text = "计分板";
            // 
            // 队伍ToolStripMenuItem
            // 
            this.队伍ToolStripMenuItem.Name = "队伍ToolStripMenuItem";
            this.队伍ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.队伍ToolStripMenuItem.Text = "队伍";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 376);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的世界ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 指令ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 队伍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem giveToolStripMenuItem;
    }
}

