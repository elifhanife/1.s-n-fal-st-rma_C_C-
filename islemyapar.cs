using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class islemyapar
    {
        //a v c değerleriyle işlem yapan program
        static int islem_yap(int a, int b, int c)
        {
            if (a % 2 == 0)
            {
                return a * c;
            }
            else if (b % 2 == 0)
            {
                return a * b;
            }
            else
            {
                return a * b * c;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("a sayısını girin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b sayısını girin: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c sayısını girin: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write(islem_yap(a, b, c));

            Console.Read();
        }


    }
}
