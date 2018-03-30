using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazılımSınama
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 > 0)
            {
                string a = Console.ReadLine();
                Console.WriteLine(x(a));
            }

            Console.ReadKey();
        }

        public static string x(string a)
        {
            string var1 = "";
            for (int i = 0; i < a.Length; i++)
            {
                var1 = (string)a.Reverse(); 
            }
            return var1;
        }
    }
}