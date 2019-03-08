namespace Minecraft.UtilApp.Controls.Selector
{
    partial class RangeSelectorControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nbValue = new Minecraft.UtilApp.Controls.NumberBox();
            this.nbMin = new Minecraft.UtilApp.Controls.NumberBox();
            this.nbMax = new Minecraft.UtilApp.Controls.NumberBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbTitle);
            this.flowLayoutPanel1.Controls.Add(this.nbValue);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.nbMin);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.nbMax);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(391, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(3, 8);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(29, 12);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "标题";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "最小值";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "最大值";
            // 
            // nbValue
            // 
            this.nbValue.Location = new System.Drawing.Point(38, 3);
            this.nbValue.Name = "nbValue";
            this.nbValue.Size = new System.Drawing.Size(60, 21);
            this.nbValue.TabIndex = 1;
            this.nbValue.Text = "0";
            this.nbValue.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nbValue.TextChanged += new System.EventHandler(this.nbValue_TextChanged);
            // 
            // nbMin
            // 
            this.nbMin.Location = new System.Drawing.Point(186, 3);
            this.nbMin.Name = "nbMin";
            this.nbMin.Size = new System.Drawing.Size(45, 21);
            this.nbMin.TabIndex = 4;
            this.nbMin.Text = "0";
            this.nbMin.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nbMin.TextChanged += new System.EventHandler(this.nbMin_TextChanged);
            // 
            // nbMax
            // 
            this.nbMax.Location = new System.Drawing.Point(307, 3);
            this.nbMax.Name = "nbMax";
            this.nbMax.Size = new System.Drawing.Size(45, 21);
            this.nbMax.TabIndex = 4;
            this.nbMax.Text = "0";
            this.nbMax.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nbMax.TextChanged += new System.EventHandler(this.nbMax_TextChanged);
            // 
            // RangeSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RangeSelectorControl";
            this.Size = new System.Drawing.Size(391, 28);
            this.Load += new System.EventHandler(this.RangeSelector_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private NumberBox nbValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private NumberBox nbMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private NumberBox nbMax;
        public System.Windows.Forms.Label lbTitle;
    }
}
