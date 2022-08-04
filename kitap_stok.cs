using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{  /* Adı ve yazarı girilen kitabın istenilen baskısının stokta olup olmadığı hakkında bilgi veren program*/
    class Program
    {
        struct kutuphane
        {
            public string k_adi;
            public int baski;
        }

        static void fonk(kutuphane kitap1)
        {
            int[] baskilar = new int[5] { 10, 11, 12, 13, 14 };
            if (kitap1.baski > baskilar[0] && kitap1.baski < baskilar[4])
            {
                for (int i = 0; i < baskilar.Length; i++)
                {
                    if (baskilar[i] == kitap1.baski)
                        Console.WriteLine("YAŞASIN, {0} kitabına ait {1}. baskı BULUNDU!!!", kitap1.k_adi, baskilar[i]);
                }
            }
            else
                Console.WriteLine("TÜH, {0}. baskı kalmamış ancak en güncel {1}. baskı VAR!!! ", kitap1.baski, baskilar[4]);
        }

        static void Main(string[] args)
        {
            kutuphane kitap1 = new kutuphane();

            Console.Write("Kitabın adını girin: ");
            kitap1.k_adi = Console.ReadLine();
            Console.Write("İstediğiniz baskıyı girin: ");
            kitap1.baski = int.Parse(Console.ReadLine());
            fonk(kitap1);

            Console.Read();
        }

    }
}