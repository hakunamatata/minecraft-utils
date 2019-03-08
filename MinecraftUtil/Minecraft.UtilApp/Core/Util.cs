using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft.UtilApp.Core
{
    public static class Extention
    {
        public static byte[] S2B(this string content)
        {
            return Encoding.UTF8.GetBytes(content);
        }

        public static string B2S(this byte[] bytes)
        {
            Debug.Print(Encoding.UTF8.GetString(bytes));
            return Encoding.UTF8.GetString(bytes);
        }

        public static void Update<T1, T2>(this Dictionary<T1, T2> dic, T1 key, T2 value)
        {
            T2 o;
            if (dic.TryGetValue(key, out o)) {
                dic[key] = value;
            }
            else
                dic.Add(key, value);
        }
    }
}
