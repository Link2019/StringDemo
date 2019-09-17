using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] newStr = str.ToCharArray();
            for (int i = 0; i < newStr.Length / 2; i++)
            {
                char temp = newStr[i];
                newStr[i] = newStr[newStr.Length - 1 - i];
                newStr[newStr.Length - 1 - i] = temp;
            }
            //str = string.Join("", newStr); 
            str = new string(newStr);   //这个直接一些
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
