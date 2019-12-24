using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> s1 = new List<string>();
            s1.Add("ABC");
            s1.Add("PQR");
            s1.Add("LMN");
            List<string> s2 = new List<string>();

            s2.Add("abc");
            s2.Add("pqr");
            s2.Add("lmn");
            ABC.s = s1;
            ABC.s = s2;
            var z = "Abc";
            z = "";
            dynamic x = "asd";
            x = 1;
            foreach (var c in ABC.s)
            {
                System.Console.WriteLine(c.ToString());

            }
            for (int i = 0; i < ABC.s.Count; i++)
            {
                System.Console.WriteLine(ABC.s[i].ToString());
            }
            System.Console.ReadLine();
        }
    }
    public static class ABC
    {
        public static void Add(int a, int b)
        {

        }
        public static string a { get; set; }
        public static List<string> s = new List<string>();
    }
}
