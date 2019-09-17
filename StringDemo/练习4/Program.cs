using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\1.txt";
            string[] contents = File.ReadAllLines(path, Encoding.Default);
            for (int i = 0; i < contents.Length; i++)
            {
                string[] newStr = contents[i].Split(new char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine((contents[0].Length>=10)?newStr[0].Substring(0,8)+"..."+" | "+newStr[1]: newStr[0]+ " | " + newStr[1]);
            }
            Console.ReadKey();
        }
        /*1.txt内容
            C#基础提升的非常非常非常快  	老赵
           .Net.Net高阶篇一定要看		    小王
            历史就是这回事这回事儿		啊张
        */
    }
}
