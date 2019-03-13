using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DataType
{
    class Program
    {
        public enum Mrkj
        {
            Csharp,Cpp=6,Jave
        }
        static void Main(string[] args)
        {
            float f = 10.34f;
            double d = 10.34;

            int i = 10;

            d = i;//隐形数据类型转换

            i = (int)d;//强制类型转换方法一
            i = Convert.ToInt32(d);//强制类型转换方法二
            i = int.Parse(d.ToString());//强制类型转换方法三

            Student stu1 = new Student();
            Student stu2;

            stu2 = stu1;
            stu1.Sex = Student.SEX.女;

            System.Console.WriteLine("student.name={0}",stu1._name);
            stu2._name = "小宇飞刀";
            System.Console.WriteLine("student.Sex={0}", stu1.Sex);

            System.Console.WriteLine("Csharp={0},Cpp={1},Jave={2}",(int)Mrkj.Csharp,(int)Mrkj.Cpp,(int)Mrkj.Jave);

            System.Console.WriteLine("f="+f);
            System.Console.WriteLine("short类型的类型名为：{0},占用字节数{1},最小值为{2},最大值为{3}", typeof(short), sizeof(short), short.MinValue, short.MaxValue);
            System.Console.WriteLine("long类型的类型名为：{0},占用字节数{1},最小值为{2},最大值为{3}", typeof(long), sizeof(long), long.MinValue, long.MaxValue);
            System.Console.WriteLine("double类型的类型名为：{0},占用字节数{1},最小值为{2},最大值为{3}", typeof(double), sizeof(double), double.MinValue, double.MaxValue);

            System.Console.ReadKey();
        }
    }
    class Student
    {
        public enum SEX
        {
            男, 女
        }
        public string _name = "xieyunc";  //9
        private SEX _sex=SEX.男;//私有成员变量
        public SEX Sex//公共成员变量，类的属性
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private DateTime _Birth;//8

        public Student()
        {
            Sex = SEX.男;
        }

    }
}
