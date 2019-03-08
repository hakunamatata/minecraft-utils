using Minecraft.UtilApp.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft.UtilApp.Components
{
    public partial class MCForm : Form
    {
        protected MCData Database => MCData.Database;
        public MCForm()
        {
            InitializeComponent();
        }

        protected void Alert(string title, string content)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        protected void Alert(string content)
        {
            Alert("提示", content);
        }
    }
}
