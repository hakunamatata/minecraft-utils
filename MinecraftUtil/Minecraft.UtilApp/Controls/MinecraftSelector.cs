using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minecraft.UtilApp.Core;

namespace Minecraft.UtilApp.Controls
{
    public partial class MinecraftSelector : MCUserControl
    {
        public MinecraftSelector()
        {
            InitializeComponent();
        }

        void selectionBind()
        {
            checkedListBox1.DataSource = CMSelector.Selectors;
            checkedListBox1.ValueMember = "Code";
            checkedListBox1.DisplayMember = "Name";
            //CMSelector.Selectors.ForEach(s => {
            //    checkedListBox1.Items.Clear();
            //    checkedListBox1.Items.Add();
            //});
        }

        private void MinecraftSelector_Load(object sender, EventArgs e)
        {
            selectionBind();
        }
    }
}
