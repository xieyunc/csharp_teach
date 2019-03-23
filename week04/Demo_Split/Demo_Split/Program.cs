using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string str= "好人|坏人|圣人|AA";
            string[] strs = str.Split('|');
            Console.WriteLine("str = {0}",str);
            Console.WriteLine("strs[0]={0}",strs[0]);
            Console.WriteLine("strs[1]={0}", strs[1]);
            Console.WriteLine("strs[2]={0}", strs[2]);
            Console.WriteLine("strs[3]={0}", strs[3]);


            str = "小宇飞刀";
            //str = "【" + str + "】";
            Console.WriteLine(str.Length);
            string str1 = str.PadLeft(5,'【');
            string str2 = str1.PadRight(6,'】');
            Console.WriteLine("str2={0}",str2);
            str = str.Remove(2, 2);
            Console.WriteLine("str={0}", str);
            str2 = string.Copy(str);
            str = "abcdefg";
            char[] ss= {'k','k','k','k','k'};
            Console.WriteLine("ss={0}",ss[0]);//kkkkk
            str.CopyTo(1, ss, 0, 3);
            Console.WriteLine("ss={0}", ss[0]);//bcdkk

            Console.WriteLine("str={0}", str);
            str = str.Replace('a', 'A');
            Console.WriteLine("str={0}",str);

            str = str.Replace("de","DE");
            Console.WriteLine("str={0}", str);

            Console.ReadKey();
        }
    }
}
