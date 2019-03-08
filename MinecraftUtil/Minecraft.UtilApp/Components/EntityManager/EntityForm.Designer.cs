namespace Minecraft.UtilApp.Components.EntityManager
{
    partial class EntityForm
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
            this.attributeEditor1 = new Minecraft.UtilApp.Controls.AttributeEditor();
            this.SuspendLayout();
            // 
            // entitySelector1
            // 
            this.entitySelector1.EntityType = Minecraft.UtilApp.Core.EntityType.Block;
            this.entitySelector1.Location = new System.Drawing.Point(12, 2);
            this.entitySelector1.Name = "entitySelector1";
            this.entitySelector1.Size = new System.Drawing.Size(142, 27);
            this.entitySelector1.TabIndex = 0;
            // 
            // attributeEditor1
            // 
            this.attributeEditor1.Location = new System.Drawing.Point(12, 68);
            this.attributeEditor1.Name = "attributeEditor1";
            this.attributeEditor1.Size = new System.Drawing.Size(523, 202);
            this.attributeEditor1.TabIndex = 1;
            // 
            // EntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 282);
            this.Controls.Add(this.attributeEditor1);
            this.Controls.Add(this.entitySelector1);
            this.Name = "EntityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.EntityForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.EntitySelector entitySelector1;
        private Controls.AttributeEditor attributeEditor1;
    }
}