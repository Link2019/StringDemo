using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { "诸葛亮", "鸟叔", "卡卡西", "卡哇伊" };
            string newStr = string.Join("|", str);
            string[] s1 = newStr.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(newStr);
            Console.ReadKey();
        }
    }
}
