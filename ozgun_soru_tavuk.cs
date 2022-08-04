using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class ozgun_soru_tavuk
    {

        /* Tavuk sahibinin girdiği günlük yumurta sayısının haftalık ortalamasını bulan program.
         Eğer pazartesiden itibaren giriyorsa günlere göre yumurta sayısını da ekrana yazar*/
        static double ortalama(int[] gunluk)
        {
            double toplam = 0.0;
            for (int i = 0; i < 7; i++)
            {
                toplam += gunluk[i];
            }
            double ort = toplam / 7;
            double sonuc = Math.Round(ort);
            return sonuc;
        }
        static void oku2(int[] gunluk)
        {
            foreach (int i in gunluk)
                Console.WriteLine(i);
        }
        static void oku(int[] gunluk)
        {
            string[] dizi_gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(dizi_gunler[i]);
                Console.WriteLine(gunluk[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] gunluk = new int[7];
            Console.Write("Bilgileri girmeye başladığınız günü yazın: ");
            string gun = Console.ReadLine();
            if (gun == "pazartesi")
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.Write("Tavuk bugün kaç yumurta verdi? : ");
                    gunluk[i] = Convert.ToInt32(Console.ReadLine());
                }
                oku(gunluk);
                Console.Write("Bu haftanın ortalama yumurta sayısı: " + ortalama(gunluk));
            }
            else
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.Write("Tavuk bugün kaç yumurta verdi? : ");
                    gunluk[i] = Convert.ToInt32(Console.ReadLine());
                }
                //oku2(gunluk);
                Console.Write("Bu haftanın ortalama yumurta sayısı: {0}", ortalama(gunluk));
            }


            Console.Read();
        }


    }
}
