using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.UtilApp.Core.Selector
{
    public abstract class BaseSelectorRangeAttribute : ICMSelectorRangeAttribute
    {
        public BaseSelectorRangeAttribute(string name)
        {
            SelectorName = name;
            SelectorValue = string.Empty;
        }

        public decimal? MaxValue { get; set; } = null;

        public decimal? MinValue { get; set; } = null;

        public string SelectorName { get; private set; }

        public string SelectorValue { get; set; }

        public bool OperationEqual { get; private set; } = true;

        public abstract string GetAttributeString();

        public string Render()
        {
            if (string.IsNullOrEmpty(SelectorValue)) {
                return $"{SelectorName}={MinValue},{SelectorName}m={MaxValue}";
            }
            else {
                return $"{SelectorName}={(OperationEqual ? "" : "!")}{SelectorValue}";
            }
        }

        public override string ToString()
        {
            string attrString = GetAttributeString();

            if (!string.IsNullOrEmpty(attrString))
                return $"{SelectorName}{(OperationEqual ? "=" : "!=")}{attrString}";
            else {
                if (MinValue == null) {
                    if (MaxValue == null) {
                        attrString = string.Empty;
                    }
                    else {
                        attrString = $"..{MaxValue.Value.ToString("#.##")}";
                    }
                }
                else {
                    if (MaxValue == null) {
                        attrString = $"{MinValue.Value.ToString("#.##")}..";
                    }
                    else {
                        attrString = $"{MinValue.Value.ToString("#.##")}..{MaxValue.Value.ToString("#.##")}";
                    }
                }
                return $"{SelectorName}{(OperationEqual ? "=" : "!=")}{attrString}";
            }
        }
    }
}
