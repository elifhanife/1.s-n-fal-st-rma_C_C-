using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{ /*Girilen geometrik şeklin ölçülerine göre işlem yapan program*/
    class Program
    {
        static int kare(string sekil)
        {
            Console.Write("Kenar uzunluğu k yı girin: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Küpün yüzey alanı: " + kare(k * k));
            return k * k;
        }
        static int kare(int alan)
        {
            return 6 * alan;
        }
        static int ucgen(string sekil)
        {
            Console.Write("Taban uzunluğu m yi girin: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Yükseklik h yi girin: ");
            int h = int.Parse(Console.ReadLine());
            return (m * h) / 2;
        }
        static float daire(string sekil)
        {
            float pi = 3.14f;
            Console.Write("Yarıçap r yi girin: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Kürenin yüzey alanı: " + daire(r));
            return pi * r * r;
        }
        static float daire(int r)
        {
            float pi = 3.14f;
            return 4 * pi * r * r;
        }
        static void Main(string[] args)
        {
            string[] sekiller = { "kare", "üçgen", "daire" };
            Console.Write("Geometrik şeklin ismini girin: ");
            string sekil = Console.ReadLine();
            if (sekil == "kare")
                Console.WriteLine("Karenin alanı: " + kare(sekil));
            else if (sekil == "üçgen")
                Console.WriteLine("Üçgenin alanı: " + ucgen(sekil));
            else
                Console.WriteLine("Dairenin alanı: " + daire(sekil));

            Console.Read();
        }
    }
}