using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习5_测试中文词语_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int index = str.IndexOf("咳嗽");
            Console.WriteLine("第1个咳嗽的位置在{0}", index);
            int count = 1;  //记录次数
            if (index != -1)
            {
                count++;
                index = str.IndexOf("咳嗽", index + 1);
                Console.WriteLine("第{0}个咳嗽的位置在{1}", count, index);
            }
            Console.ReadKey();
        }
    }
}
