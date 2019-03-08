using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.UtilApp.Core.Selector
{
    public interface ICMSelectorAttribute
    {

        string SelecetorName { get; }
        string SelectorValue { get; set; }
        bool OperationEqual { get; }
    }
}
