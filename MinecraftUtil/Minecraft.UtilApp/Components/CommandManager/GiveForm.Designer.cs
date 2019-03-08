namespace Minecraft.UtilApp.Components.CommandManager
{
    partial class GiveForm
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
            this.entitySelector1 = new Minecraft.UtilApp.Controls.EntitySelector();
            this.minecraftSelector1 = new Minecraft.UtilApp.Controls.MinecraftSelector();
            this.SuspendLayout();
            // 
            // entitySelector1
            // 
            this.entitySelector1.EntityType = Minecraft.UtilApp.Core.EntityType.Default;
            this.entitySelector1.Location = new System.Drawing.Point(12, 12);
            this.entitySelector1.Name = "entitySelector1";
            this.entitySelector1.Size = new System.Drawing.Size(209, 26);
            this.entitySelector1.TabIndex = 0;
            // 
            // minecraftSelector1
            // 
            this.minecraftSelector1.Location = new System.Drawing.Point(21, 54);
            this.minecraftSelector1.Name = "minecraftSelector1";
            this.minecraftSelector1.Size = new System.Drawing.Size(140, 100);
            this.minecraftSelector1.TabIndex = 1;
            // 
            // GiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minecraftSelector1);
            this.Controls.Add(this.entitySelector1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GiveForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.EntitySelector entitySelector1;
        private Controls.MinecraftSelector minecraftSelector1;
    }
}