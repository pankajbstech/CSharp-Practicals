using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Generic
{
    public class MainClass
    {
        public static void Main()
        {
            bool equal = Calculator.AreEqual(1, 2);
            if (equal)
            {
                Console.WriteLine("Equal");
            }
            else
                Console.WriteLine("Not Equal");
            Console.ReadLine();
        }
    }
    class Calculator
    {
        public static bool AreEqual(string Value1, string Value2)
        {
            return Value1 == Value2;
        }
        public static bool AreEqual(object Value1, object Value2)
        {
            return Value1 == Value2;
        }
        public static bool AreEqual<T>(T Value1, T Value2)// Generic Method
        {
            return Value1.Equals(Value2);
        }
    }
    class Calculator<T>  // Generic Class
    {
        public static bool AreEqual(string Value1, string Value2)
        {
            return Value1 == Value2;
        }
        public static bool AreEqual(object Value1, object Value2)
        {
            return Value1 == Value2;
        }
        public static bool AreEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
