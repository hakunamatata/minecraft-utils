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
    public partial class MCUserControl : UserControl
    {
        public MCData Database => MCData.Database;
        public MCUserControl()
        {
            InitializeComponent();
        }

        protected DialogResult Alert(string title, string content)
        {
            return MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        protected DialogResult Alert(string content)
        {
            return Alert("提示", content);
        }
    }
}
