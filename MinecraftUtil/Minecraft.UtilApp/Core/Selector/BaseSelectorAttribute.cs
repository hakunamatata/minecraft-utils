using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.UtilApp.Core.Selector
{
    public abstract class BaseSelectorAttribute : ICMSelectorAttribute
    {
        public string SelecetorName { get; private set; }

        public string SelectorValue { get; set; }

        public bool OperationEqual { get; private set; } = true;

        public BaseSelectorAttribute(string name)
        {
            SelecetorName = name;
            SelectorValue = string.Empty;
        }

        public abstract string GetAttributeString();

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(GetAttributeString()))
                return $"{SelecetorName}{(OperationEqual ? "=" : "!=")}{GetAttributeString()}";

            return string.Empty;
        }
    }
}
