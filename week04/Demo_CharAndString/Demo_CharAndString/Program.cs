using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CharAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2;
            t2 = t1;

            Console.WriteLine("t1.x={0},t1.y={1}",t1.x,t1.y);
            Console.WriteLine("t2.x={0},t2.y={1}", t2.x, t2.y);
            t1.x = 77;
            t1.y = 88;
            Console.WriteLine("t1.x={0},t1.y={1}", t1.x, t1.y);
            Console.WriteLine("t2.x={0},t2.y={1}", t2.x, t2.y);


            //StringBuilder

            string name = "小宇飞刀";
            char sex = '女';
            double score = 80.5;
            string str1 = name;

            str1 = "xieyunc";//这一操作并不会改变name变量的值，why?

            Console.WriteLine("name={0},sex={1},score={1}",name,sex,score);

            Console.WriteLine("z:\\csharp_teach\babcd");
            //Console.WriteLine("abcd");

            string s1=null, s2="";
            string str2;
            str2 = s1 == s2 ? "相等" : "不相等";
            Console.WriteLine("str2的值为：{0}", str2);
            //if (s1 == null)
            if (s2.Equals(string.Empty))
            {
                Console.WriteLine("条件为真");
            }

            str1 = "abc";
            str2 = "Abc";

            if (str1.ToLower() == str2.ToLower())
                Console.WriteLine("相等");
            else
                Console.WriteLine("不相等");

            if (string.Compare(str1,str2,true)==0)
                Console.WriteLine("相等");
            else
                Console.WriteLine("不相等");

            if (str1.ToLower().CompareTo(str2.ToLower())==0)
                Console.WriteLine("相等");
            else
                Console.WriteLine("不相等");

            

            Console.ReadKey();
        }
    }
    class Test
    {
        public int x = 10;
        public int y = 20;
    }
}
