using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    struct zaman
    {
        public int saat, dakika, saniye;
    }
    class Program
    {
        public static void hesapla(zaman z1, zaman z2)
        {
            zaman z3 = new zaman();
            Console.WriteLine("1.Zaman Dilimi=> {0}.{1}.{2}", z1.saat, z1.dakika, z1.saniye);
            Console.WriteLine("2.Zaman Dilimi=> {0}.{1}.{2}", z2.saat, z2.dakika, z2.saniye);

            if (z1.saniye < z2.saniye)
            {
                z3.saniye = (z1.saniye + 60) - z2.saniye;
                z1.dakika--;

                if (z1.dakika < z2.dakika)
                {
                    z3.dakika = (z1.dakika + 60) - z2.dakika;
                    z1.saat--;

                    if (z1.saat < z2.saat)
                    {
                        z3.saat = Math.Abs(z1.saat - z2.saat) + 24;
                    }
                    else
                    {
                        z3.saat = Math.Abs(z1.saat - z2.saat);
                    }
                }
            }


            Console.WriteLine("Fark=> {0}.{1}.{2}", z3.saat, z3.dakika, z3.saniye);
        }
        static void Main(string[] args)
        {
            zaman z1 = new zaman();
            zaman z2 = new zaman();

            Console.WriteLine("1.Zaman dilimi: ");
            z1.saat = int.Parse(Console.ReadLine());
            z1.dakika = int.Parse(Console.ReadLine());
            z1.saniye = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Zaman dilimi: ");
            z2.saat = int.Parse(Console.ReadLine());
            z2.dakika = int.Parse(Console.ReadLine());
            z2.saniye = int.Parse(Console.ReadLine());
            hesapla(z1, z2);


            Console.Read();

        }
    }
}

