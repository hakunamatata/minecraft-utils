using Minecraft.UtilApp.Components;
using Minecraft.UtilApp.Components.CommandManager;
using Minecraft.UtilApp.Components.EntityManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft.UtilApp
{
    public partial class Form1 : MCForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 菜单：方块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void blockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var itemForm = new EntityForm(Core.EntityType.Block);
            if (itemForm.ShowDialog() == DialogResult.OK) {

            }
        }
        /// <summary>
        /// 菜单： 指令 -> /give
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void giveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var giveForm = new GiveForm();
            giveForm.ShowDialog();
        }
    }
}
