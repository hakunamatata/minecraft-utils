using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.UtilApp.Core
{
    public class Colors
    {
        public static MColor Black => new MColor("黑色", "\u00a70", Color.Black);
        public static MColor DarkBlue => new MColor("深蓝", "\u00a71", Color.DarkBlue);
        public static MColor DarkGreen => new MColor("深绿", "\u00a72", Color.DarkGreen);
        public static MColor SkyBlue => new MColor("天蓝", "\u00a73", Color.SkyBlue);
        public static MColor Red => new MColor("红色", "\u00a74", Color.Red);
        public static MColor DarkPurple => new MColor("深紫色", "\u00a75", Color.Purple);
        public static MColor Gold => new MColor("金黄", "\u00a76", Color.Gold);
        public static MColor Gray => new MColor("浅灰", "\u00a77", Color.Gray);
        public static MColor DarkGrey => new MColor("深灰", "\u00a78", Color.DarkGray);
        public static MColor LightPurple => new MColor("淡紫", "\u00a79", Color.MediumPurple);
        public static MColor LightGreen => new MColor("深绿", "\u00a7a", Color.LightGreen);
        public static MColor LightBlue => new MColor("淡蓝", "\u00a7b", Color.LightBlue);
        public static MColor LightRed => new MColor("淡红", "\u00a7c", Color.Red);
        public static MColor LightPruple => new MColor("淡紫", "\u00a7d", Color.Purple);
        public static MColor LightYellow => new MColor("淡黄", "\u00a7e", Color.LightYellow);
        public static MColor White => new MColor("白色", "\u00a7f", Color.White);
        public static MColor[] AllColors => new MColor[16] {
            Black, DarkBlue, DarkGreen,SkyBlue, Red, DarkPurple, Gold, Gray, DarkGreen, LightPurple,LightGreen,LightBlue,LightRed,LightPruple, LightYellow,White
        };
    };
}

public class MColor
{
    public string Name { get; set; }
    public string Code { get; set; }
    public Color Color { get; set; }
    public MColor(string name, string code, Color color)
    {
        Name = name;
        Code = code;
        Color = color;
    }
}
