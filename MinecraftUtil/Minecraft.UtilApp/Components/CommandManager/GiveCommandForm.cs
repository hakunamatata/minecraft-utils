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
    /// <summary>
    /// /give command:
    /// 语法: 
    ///     /give 选择器 数量 损伤 
    /// </summary>
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
