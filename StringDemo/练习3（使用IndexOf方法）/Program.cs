using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习3_使用IndexOf方法_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abc@163.com";
            int index = str.IndexOf('@');
            string userName = str.Substring(0, index);
            string domainName = str.Substring(index + 1);
            Console.WriteLine("用户名为{0},域名为{1}", userName, domainName);
            Console.ReadKey();
        }
    }
}
