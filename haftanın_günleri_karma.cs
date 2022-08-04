using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Math
    {
        static void Main(string[] args)
        {
            // Haftanın p ile başlayan günlerini klavyeden alıp p ile başlıyorsa kelimenin uzunluğuna göre işlem yapan, p ile başlamıyorsa ekrana yıldızlardan oluşan şekli çizen program
            Console.Write("Haftanın bir gününü girin: ");
            string day = Console.ReadLine();
            bool x = day.StartsWith("p");

            if (x)
            {
                Console.WriteLine(x);
                int a = day.Length;
                for (int i = 0; i < a; i++)
                {
                    int islem1 = i * i;
                    Console.Write(islem1);
                    Console.Write(" ");
                }

            }
            else
            {
                Console.WriteLine(x);
                int j = 0;
                int a = day.Length;
                for (j = 0; j <= a; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        Console.Write("*");

                    }
                    Console.WriteLine(" ");

                }
            }

            Console.ReadKey();
        }
    }
