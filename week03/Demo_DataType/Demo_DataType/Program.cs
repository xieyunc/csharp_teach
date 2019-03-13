using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DataType
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}", 
                                typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}", 
                                typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}", 
                                typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}", 
                                typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}", 
                                typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}", 
                                typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}", 
                                typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}", 
                                typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}", 
                                typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}", 
                                typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}", 
                                typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t", 
                                typeof(bool).Name, sizeof(bool));
            Console.WriteLine("{0}:\t 所占字节数: {1}\t 取值范围：{2} ~ {3}",
                                typeof(char).Name, sizeof(char), char.MinValue, char.MaxValue);
            Console.WriteLine("{0}:\t 所占字节数: {1}\t ",
                                typeof(IntPtr).Name, IntPtr.Size);

            Console.ReadKey();
        }
    }
}
