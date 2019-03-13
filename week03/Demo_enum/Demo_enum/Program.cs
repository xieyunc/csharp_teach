using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_enum
{
    class Student
    {
        public enum SEX
        {
            男, 女
        }
        public string Name = "xieyunc";
        public SEX Sex = SEX.男;
        public int Age = 28;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //枚举类型的演示DEMO
            Student stu1 = new Student();
            System.Console.WriteLine("stu1.Name={0},stu1.Sex={1},stu1.Age={2}",stu1.Name,stu1.Sex,stu1.Age);
            stu1.Name = "小宇飞刀";
            stu1.Sex = Student.SEX.女;
            stu1.Age = 108;
            System.Console.WriteLine("stu1.Name={0},stu1.Sex={1},stu1.Age={2}", stu1.Name, stu1.Sex, stu1.Age);
            System.Console.ReadKey();
        }
    }
}
