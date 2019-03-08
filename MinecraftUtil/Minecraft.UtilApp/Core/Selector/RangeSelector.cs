using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.UtilApp.Core.Selector
{
    public class RangeSelector : BaseSelectorRangeAttribute
    {
        public RangeSelector(string name) : base(name)
        {
        }

        public override string GetAttributeString()
        {
            return SelectorValue.ToString();
        }
    }
}
