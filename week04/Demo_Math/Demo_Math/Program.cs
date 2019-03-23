using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Random rnd = new Random();
            x = rnd.Next(1,10);
            y = rnd.Next(1,10);
            Console.Write("{0}+{1}=", x, y);
            string str = Console.ReadLine();
            if (!string.IsNullOrEmpty(str))
            {
                int z = Convert.ToInt32(str);
                if (x + y == z)
                    Console.WriteLine("你答对了，真棒！");
                else
                    Console.WriteLine("答错了，还要加油啊！");
            }
            Console.ReadKey();
        }
    }
}
