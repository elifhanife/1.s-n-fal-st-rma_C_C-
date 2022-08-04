using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECURSIVE_2
{
    class Program
    {
        /*Sürtünmesiz ortamda serbest düşme yapan bir cismin hareketi boyunca aldığı yolu(m) ekrana yazan program */
        static int hesapla(int t)
        {
            if (t == 1)
                return 5;
            else
                return 5 * (t + t - 1) + hesapla(t - 1);

        }

        static void Main(string[] args)
        {
            Console.Write("t süresini girin (saniye): ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.Write(hesapla(t) + " metre");
            Console.Read();
        }
    }
}