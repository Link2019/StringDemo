using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (str.Contains("邪恶"))
            {
                str = str.Replace("邪恶", "**");
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
