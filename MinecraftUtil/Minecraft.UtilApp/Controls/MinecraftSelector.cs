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
using Minecraft.UtilApp.Core.Selector;

namespace Minecraft.UtilApp.Controls
{
    public partial class MinecraftSelector : MCUserControl
    {
        public CMSelector Selector { get; private set; } = CMSelector.Selectors[0];
        public MinecraftSelector()
        {
            InitializeComponent();
        }

        void selectorsBind()
        {
            rbNearest.Tag = CMSelector.Selectors[0];
            rbRandom.Tag = CMSelector.Selectors[1];
            rbAll.Tag = CMSelector.Selectors[2];
            rbEntity.Tag = CMSelector.Selectors[3];
            rbSender.Tag = CMSelector.Selectors[4];
        }
        void attributesBind()
        {

        }
        private void MinecraftSelector_Load(object sender, EventArgs e)
        {
            selectorsBind();
            attributesBind();
        }

        private void rbItem_CheckedChanged(object sender, EventArgs e)
        {
            var rb = sender as RadioButton;
            if (rb.Checked) Selector = (CMSelector)rb.Tag;
        }
    }
}
