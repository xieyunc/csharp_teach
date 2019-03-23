using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "xieyunc@qq.com";
            int i = email.IndexOf('@');
            Console.WriteLine("username={0}",email.Substring(0,i));
            Console.ReadKey();
        }
    }
}
