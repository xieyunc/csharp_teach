using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_obj
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            object obj;
            obj = i;//装箱
            int x = (int)obj;//拆箱

            int cj_C = 89, cj_Csharp = 90, cj_SQL = 60;
            int cj_x = cj_Csharp - cj_SQL;
            int cj_Avg = (cj_C + cj_Csharp + cj_SQL) / 3;
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("C\tC#\tSQL");
            System.Console.WriteLine("{0}\t{1}\t{2}",cj_C,cj_Csharp,cj_SQL);
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("C#和SQL的成绩差为：{0}",cj_x);
            System.Console.WriteLine("三六课程的平均分为：{0}",cj_Avg);


            x = 10;
            int y = 6;

            int z = ++x;
            System.Console.WriteLine("x={0},y={1},z={2}",x,y,z);

            z = x < y ? 2 * x : 64 + 3 * y;

            z *= x + 4 * y;

            //System.Console.WriteLine("x={0}",x);
            System.Console.ReadKey();
        }
    }
}
