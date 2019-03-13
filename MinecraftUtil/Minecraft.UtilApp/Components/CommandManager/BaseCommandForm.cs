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

namespace Minecraft.UtilApp.Components.CommandManager
{
    public partial class BaseCommandForm : MCForm, IMCCommand
    {
        public string CommandString
        {
            get
            {
                return textBoxCommand.Text.Trim();
            }
            protected set
            {
                textBoxCommand.Text = value;
            }
        }

        public string Pattern { get; set; }

        public BaseCommandForm()
        {
            InitializeComponent();
        }

        private void buttonCommand_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CommandString)) {
                // 输入指令
                GetCommand();
            }
            else {
                // 返回指令
                DialogResult = DialogResult.OK;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            CommandString = string.Empty;
        }

        public virtual void GetCommand()
        {

        }
    }
}
