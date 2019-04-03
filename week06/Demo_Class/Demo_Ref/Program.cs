using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Console.WriteLine("交换之前的数据：");
            Console.WriteLine("x={0},y={1}",x,y);

            Swap(ref x, ref y);
            Console.WriteLine("交换之后的数据：");
            Console.WriteLine("x={0},y={1}", x, y);

            Console.ReadKey();

        }

        public static void Swap(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
