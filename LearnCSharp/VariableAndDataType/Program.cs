using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableAndDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DefineVariable();
            //StringOrstring();
            //UserVarKeyWord();
            //PrintDatatypeLength();
            StringAndNumberType();
            Console.ReadKey();
        }

        static void DefineVariable()
        {
            int intValue = 100;
            long longValue = 100l;
            double doubleValue = 100.5d;
            float floatValue = 100.5f;

            Console.WriteLine(intValue.GetType());
            Console.WriteLine(longValue.GetType());
            Console.WriteLine(doubleValue.GetType());
            Console.WriteLine(floatValue.GetType());

            Console.WriteLine(intValue.GetType() == typeof(int));
        }

        static void StringOrstring()
        {
            String str1 = "Hello";
            string str2 = "World";
            Console.WriteLine(str1.GetType());
            Console.WriteLine(str2.GetType());
            Console.WriteLine(typeof(String) == typeof(string));
        }

        // 隐式类型变量定义
        static void UserVarKeyWord()
        {
            var value = "Hello";
            Console.WriteLine(value.GetType());
        }

        // 了解特定数据类型变量所占的内存单元
        static void PrintDatatypeLength()
        {
            Console.WriteLine("int类型占用：{0}字节", sizeof(int));
            Console.WriteLine("long类型占用：{0}字节", sizeof(long));
            Console.WriteLine("float类型占用：{0}字节", sizeof(float));
            Console.WriteLine("double类型占用：{0}字节", sizeof(double));

            int intValue = 100;
            long longValue = 100l;
            double doubleValue = 100.5d;
            float floatValue = 100.5f;

            longValue = intValue;
            doubleValue = floatValue;
            intValue = (int)longValue;

        }

        static void StringAndNumberType()
        {
            string strValue = "100";
            int intValue = int.Parse(strValue);
            double doubleValue = double.Parse(strValue);

            intValue = Convert.ToInt32(strValue);
            doubleValue = Convert.ToDouble(strValue);

            strValue = intValue.ToString();
            strValue = 200.ToString();

            strValue = intValue + "";
        }
    }
}
