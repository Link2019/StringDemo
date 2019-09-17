using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abc@163.com";
            string[] s1 = str.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("用户名为{0},域名为{1}",s1[0],s1[1]);
            Console.ReadKey();
        }
    }
}
