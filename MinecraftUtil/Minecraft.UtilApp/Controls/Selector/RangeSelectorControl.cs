using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minecraft.UtilApp.Core.Selector;

namespace Minecraft.UtilApp.Controls.Selector
{
    public partial class RangeSelectorControl : UserControl
    {
        private string title = "标题";
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                lbTitle.Text = value;
            }
        }
        public string AttributeKey { get; set; }
        public RangeSelector Attribute { get; private set; }
        public RangeSelectorControl()
        {
            InitializeComponent();

        }
        public RangeSelectorControl(string title, string attributeKey) : this()
        {
            Title = title;
            AttributeKey = attributeKey;
        }

        private void RangeSelector_Load(object sender, EventArgs e)
        {
            Attribute = new RangeSelector(AttributeKey);
        }

        private void nbValue_TextChanged(object sender, EventArgs e)
        {
            var box = sender as NumberBox;
            Attribute.SelectorValue = box.Text;
        }

        private void nbMin_TextChanged(object sender, EventArgs e)
        {
            var box = sender as NumberBox;
            Attribute.MinValue = box.Value;
        }

        private void nbMax_TextChanged(object sender, EventArgs e)
        {
            var box = sender as NumberBox;
            Attribute.MaxValue = box.Value;
        }
    }
}
