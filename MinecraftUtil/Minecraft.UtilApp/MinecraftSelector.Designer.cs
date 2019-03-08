namespace Minecraft.UtilApp.Controls
{
    partial class MinecraftSelector
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.rbNearest = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbEntity = new System.Windows.Forms.RadioButton();
            this.rbSender = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAttr1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rangeSelectorControl3 = new Minecraft.UtilApp.Controls.Selector.RangeSelectorControl();
            this.rangeSelectorControl2 = new Minecraft.UtilApp.Controls.Selector.RangeSelectorControl();
            this.rangeSelectorControl1 = new Minecraft.UtilApp.Controls.Selector.RangeSelectorControl();
            this.flowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAttr1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.Controls.Add(this.rbNearest);
            this.flowPanel.Controls.Add(this.rbRandom);
            this.flowPanel.Controls.Add(this.rbAll);
            this.flowPanel.Controls.Add(this.rbEntity);
            this.flowPanel.Controls.Add(this.rbSender);
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowPanel.Location = new System.Drawing.Point(0, 0);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(99, 369);
            this.flowPanel.TabIndex = 0;
            // 
            // rbNearest
            // 
            this.rbNearest.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNearest.AutoSize = true;
            this.rbNearest.Checked = true;
            this.rbNearest.Location = new System.Drawing.Point(3, 3);
            this.rbNearest.Name = "rbNearest";
            this.rbNearest.Size = new System.Drawing.Size(93, 22);
            this.rbNearest.TabIndex = 0;
            this.rbNearest.TabStop = true;
            this.rbNearest.Text = "@p 最近的玩家";
            this.rbNearest.UseVisualStyleBackColor = true;
            this.rbNearest.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // rbRandom
            // 
            this.rbRandom.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(3, 31);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(93, 22);
            this.rbRandom.TabIndex = 1;
            this.rbRandom.Text = "@r 随机玩家  ";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // rbAll
            // 
            this.rbAll.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(3, 59);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(93, 22);
            this.rbAll.TabIndex = 2;
            this.rbAll.Text = "@a 所有玩家  ";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // rbEntity
            // 
            this.rbEntity.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEntity.AutoSize = true;
            this.rbEntity.Location = new System.Drawing.Point(3, 87);
            this.rbEntity.Name = "rbEntity";
            this.rbEntity.Size = new System.Drawing.Size(93, 22);
            this.rbEntity.TabIndex = 3;
            this.rbEntity.Text = "@e 所有实体  ";
            this.rbEntity.UseVisualStyleBackColor = true;
            this.rbEntity.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // rbSender
            // 
            this.rbSender.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbSender.AutoSize = true;
            this.rbSender.Location = new System.Drawing.Point(3, 115);
            this.rbSender.Name = "rbSender";
            this.rbSender.Size = new System.Drawing.Size(93, 22);
            this.rbSender.TabIndex = 4;
            this.rbSender.Text = "@s 命令执行者";
            this.rbSender.UseVisualStyleBackColor = true;
            this.rbSender.CheckedChanged += new System.EventHandler(this.rbItem_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(99, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 369);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAttr1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAttr1
            // 
            this.tabAttr1.Controls.Add(this.flowLayoutPanel1);
            this.tabAttr1.Location = new System.Drawing.Point(4, 22);
            this.tabAttr1.Name = "tabAttr1";
            this.tabAttr1.Size = new System.Drawing.Size(583, 343);
            this.tabAttr1.TabIndex = 0;
            this.tabAttr1.Text = "1";
            this.tabAttr1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rangeSelectorControl1);
            this.flowLayoutPanel1.Controls.Add(this.rangeSelectorControl2);
            this.flowLayoutPanel1.Controls.Add(this.rangeSelectorControl3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(583, 343);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rangeSelectorControl3
            // 
            this.rangeSelectorControl3.Location = new System.Drawing.Point(8, 76);
            this.rangeSelectorControl3.Name = "rangeSelectorControl3";
            this.rangeSelectorControl3.Size = new System.Drawing.Size(513, 34);
            this.rangeSelectorControl3.TabIndex = 2;
            this.rangeSelectorControl3.Title = "Z";
            // 
            // rangeSelectorControl2
            // 
            this.rangeSelectorControl2.Location = new System.Drawing.Point(8, 42);
            this.rangeSelectorControl2.Name = "rangeSelectorControl2";
            this.rangeSelectorControl2.Size = new System.Drawing.Size(513, 28);
            this.rangeSelectorControl2.TabIndex = 1;
            this.rangeSelectorControl2.Title = "Y";
            // 
            // rangeSelectorControl1
            // 
            this.rangeSelectorControl1.Location = new System.Drawing.Point(8, 8);
            this.rangeSelectorControl1.Name = "rangeSelectorControl1";
            this.rangeSelectorControl1.Size = new System.Drawing.Size(513, 28);
            this.rangeSelectorControl1.TabIndex = 0;
            this.rangeSelectorControl1.Title = "X";
            // 
            // MinecraftSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowPanel);
            this.Name = "MinecraftSelector";
            this.Size = new System.Drawing.Size(690, 369);
            this.Load += new System.EventHandler(this.MinecraftSelector_Load);
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabAttr1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.RadioButton rbNearest;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbEntity;
        private System.Windows.Forms.RadioButton rbSender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAttr1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Selector.RangeSelectorControl rangeSelectorControl1;
        private Selector.RangeSelectorControl rangeSelectorControl2;
        private Selector.RangeSelectorControl rangeSelectorControl3;
    }
}
