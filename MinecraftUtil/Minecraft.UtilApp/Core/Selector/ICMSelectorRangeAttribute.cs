using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.UtilApp.Core.Selector
{
    public interface ICMSelectorRangeAttribute : ICMSelectorAttribute
    {
        decimal? MaxValue { get; set; }
        decimal? MinValue { get; set; }
    }
}
