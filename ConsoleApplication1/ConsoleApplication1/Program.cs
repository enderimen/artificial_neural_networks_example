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
            Console.Write(solution("radher", "rakher"));
        }

        public static int solution(string A, string B)
        {
            int tekrar = 0;
            int ekle = 0;

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {

                    if (A[i] == B[j])
                    {
                        tekrar++;
                    }
                }

                if (tekrar != 0)
                {
                    ekle++;
                }
           } 
            
            /*
            for (int i = 0; i < B.Length; i++)
            {

                for (int j = 0; j < A.Length; j++)
                {

                    if (B[i] == A[j])
                    {
                        tekrar++;
                    }
                }
            }

            if (tekrar != 0)
            {
                ekle++;
            }*/
            
            return ekle;
        }
    }
}
