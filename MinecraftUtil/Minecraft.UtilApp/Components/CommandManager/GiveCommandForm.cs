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
    public partial class GiveCommandForm : BaseCommandForm
    {
        public GiveCommandForm()
        {
            InitializeComponent();
        }

        public override void GetCommand()
        {
            CommandString = "test";
        }
    }
}
