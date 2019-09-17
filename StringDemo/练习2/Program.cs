using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello c sharp";
            /*
            char[] chs = { ' ' };
            string[] s1 = str.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            */
            string[] s1 = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); //等价于上面注释的内容
            for (int i = 0; i < s1.Length / 2; i++)
            {
                string temp = s1[i];
                s1[i] = s1[s1.Length - 1 - i];
                s1[s1.Length - 1 - i] = temp;
            }
            str = string.Join(" ", s1);
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}
