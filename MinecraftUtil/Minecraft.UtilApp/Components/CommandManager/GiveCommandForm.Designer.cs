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
            this.entitySelector1.Location = new System.Drawing.Point(3, 5);
            this.entitySelector1.Name = "entitySelector1";
            this.entitySelector1.Size = new System.Drawing.Size(140, 26);
            this.entitySelector1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.minecraftSelector1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(690, 324);
            this.panel5.TabIndex = 1;
            // 
            // minecraftSelector1
            // 
            this.minecraftSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minecraftSelector1.Location = new System.Drawing.Point(0, 0);
            this.minecraftSelector1.Name = "minecraftSelector1";
            this.minecraftSelector1.Size = new System.Drawing.Size(690, 324);
            this.minecraftSelector1.TabIndex = 0;
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
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private Controls.EntitySelector entitySelector1;
        private Controls.MinecraftSelector minecraftSelector1;
    }
}