using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.UtilApp.Core.Selector
{
    public abstract class BaseSelectorAttribute : ICMSelectorAttribute
    {
        public string SelectorName { get; private set; }

        public string SelectorValue { get; set; }

        public bool OperationEqual { get; private set; } = true;

        public BaseSelectorAttribute(string name)
        {
            SelectorName = name;
            SelectorValue = string.Empty;
        }

        public abstract string GetAttributeString();

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(GetAttributeString()))
                return $"{SelectorName}{(OperationEqual ? "=" : "!=")}{GetAttributeString()}";

            return string.Empty;
        }

        public string Render()
        {
            return $"{SelectorName}={(OperationEqual ? "" : "!")}{SelectorValue}";
        }
    }
}
