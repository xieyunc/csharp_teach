using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {2,5,1,19,81,23,4,6};

            ArrayList List = new ArrayList(a); 

            Console.WriteLine("数组的原始值：");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();

            List.Add(66);
            List.Insert(3, 44);
            List.Remove(5);
            List.RemoveAt(3);

            List.RemoveRange(5, 2);

            Console.WriteLine("List的原始值：");
            foreach (int x in List)
            {
                Console.Write(x+" ");
            }

            Console.WriteLine();
            List.Sort();
            Console.WriteLine("List排序之后的值：");
            foreach (int x in List)
            {
                Console.Write(x + " ");
            }



            Console.ReadKey();

        }
    }
}
