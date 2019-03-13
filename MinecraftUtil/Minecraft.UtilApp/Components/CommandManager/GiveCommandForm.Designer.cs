namespace Minecraft.UtilApp.Components.CommandManager
{
    partial class GiveCommandForm
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
            if (disposing && (components != null)) {
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.entitySelector1 = new Minecraft.UtilApp.Controls.EntitySelector();
            this.panel5 = new System.Windows.Forms.Panel();
            this.minecraftSelector1 = new Minecraft.UtilApp.Controls.MinecraftSelector();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nbNumber = new Minecraft.UtilApp.Controls.NumberBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nbDamage = new Minecraft.UtilApp.Controls.NumberBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Size = new System.Drawing.Size(690, 364);
            this.panel2.Visible = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nbDamage);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.nbNumber);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.entitySelector1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 40);
            this.panel3.TabIndex = 0;
            // 
            // entitySelector1
            // 
            this.entitySelector1.EntityType = Minecraft.UtilApp.Core.EntityType.Default;
            this.entitySelector1.Location = new System.Drawing.Point(76, 8);
            this.entitySelector1.Name = "entitySelector1";
            this.entitySelector1.Size = new System.Drawing.Size(140, 26);
            this.entitySelector1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.minecraftSelector1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.panel5.Size = new System.Drawing.Size(690, 324);
            this.panel5.TabIndex = 1;
            // 
            // minecraftSelector1
            // 
            this.minecraftSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minecraftSelector1.Location = new System.Drawing.Point(0, 30);
            this.minecraftSelector1.Name = "minecraftSelector1";
            this.minecraftSelector1.Size = new System.Drawing.Size(690, 294);
            this.minecraftSelector1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择实体:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数量:";
            // 
            // nbNumber
            // 
            this.nbNumber.Location = new System.Drawing.Point(263, 10);
            this.nbNumber.Name = "nbNumber";
            this.nbNumber.Size = new System.Drawing.Size(100, 21);
            this.nbNumber.TabIndex = 3;
            this.nbNumber.Value = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "损坏值:";
            // 
            // nbDamage
            // 
            this.nbDamage.Location = new System.Drawing.Point(424, 10);
            this.nbDamage.Name = "nbDamage";
            this.nbDamage.Size = new System.Drawing.Size(100, 21);
            this.nbDamage.TabIndex = 5;
            this.nbDamage.Value = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "选择器:";
            // 
            // GiveCommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 391);
            this.Name = "GiveCommandForm";
            this.Text = "GiveCommandForm";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private Controls.EntitySelector entitySelector1;
        private Controls.MinecraftSelector minecraftSelector1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.NumberBox nbNumber;
        private Controls.NumberBox nbDamage;
        private System.Windows.Forms.Label label4;
    }
}