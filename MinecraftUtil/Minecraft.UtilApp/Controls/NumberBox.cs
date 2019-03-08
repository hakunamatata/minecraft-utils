using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft.UtilApp.Controls
{
    public class NumberBox : TextBox
    {
        public decimal Value
        {
            get {
                return Convert.ToDecimal(Text);
            }

            set {
                Text = value.ToString();
            }
        }
        public NumberBox()
        {
            TextChanged += NumberBox_TextChanged;
        }

        private void NumberBox_TextChanged(object sender, EventArgs e)
        {
            var box = sender as NumberBox;
            decimal v = 0;
            if (decimal.TryParse(box.Text, out v))
                Text = v.ToString();
            else {
                Text = "0";
            }
        }
    }
}
