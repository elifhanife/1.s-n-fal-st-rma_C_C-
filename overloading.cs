using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OVERLOAD_1
{
    /*Taban uzunlukları ve yüksekliği girilen dikdörtgensel piramitin hacmini ve taban alanını ekrana yazan program*/
    class Program
    {
        static float piramit(int a, int b, int c)
        {
            return (a * b * c) / 3;
        }
        static int piramit(int a, int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.Write("taban uzunluğu a yı girin:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("taban uzunluğu b yi girin:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("h yüksekliğini girin: ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Piramitin hacmi= " + piramit(a, b, h));
            Console.WriteLine("Piramitin taban alanı= " + piramit(a, b));
            Console.Read();
        }
    }
}