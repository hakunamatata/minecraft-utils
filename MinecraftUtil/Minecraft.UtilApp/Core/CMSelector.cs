using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.UtilApp.Core
{
    public class CMSelector
    {
        public Dictionary<string, string> Attributes { get; private set; }

        public static List<CMSelector> Selectors => new List<CMSelector>() {
            new CMSelector("@p","@p 距离最近的玩家"),
            new CMSelector("@r","@r 随机玩家"),
            new CMSelector("@a","@a 所有玩家"),
            new CMSelector("@e","@e 所有实体"),
            new CMSelector("@s","@s 命令执行者")
        };

        public string Name { get; set; }
        public string Describe { get; set; }

        public CMSelector(string name, string describe)
        {
            Name = name;
            Describe = describe;
        }

        public void SetAttribute(string key, string value)
        {
            Attributes.Update(key, value);
        }

    }
}
