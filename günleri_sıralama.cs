using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YENI_ORNEK
{
    /*Dağınık verilmiş harfler içinden günleri bulup yazma oyunu. İlk denemeden sonraki 2 denemede ipucu verir.*/
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int sayi = rnd.Next(7);
            string[] daginik_kelimeler = { "p z a t s i e a r ", "a s l ı ", "m r a b ş a ç a ", "m b r e p e e ş ", "u m c a ", "t s e c r u m i a ", "a a z r p " };
            string[] duzenli_kelimeler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar", "pazartesi" };
            string cevap;
            int i = 1;
            Console.WriteLine(daginik_kelimeler[sayi]);
            do
            {
                Console.WriteLine(" ");
                Console.WriteLine("{0}.Deneme", i++);
                Console.WriteLine("Bu hangi gün? ");
                cevap = Console.ReadLine();

                if (duzenli_kelimeler[sayi] == cevap)
                    Console.WriteLine("Bildiniz! Doğru cevap: " + cevap.ToUpper());
                else
                {
                    if (i == 2)
                    {
                        Console.WriteLine("Yanlış! ");
                        Console.WriteLine(" ");
                        Console.WriteLine("İpucu => Baş harfi: " + duzenli_kelimeler[sayi].Substring(0, 1));
                    }
                    else if (i == 3)
                    {
                        Console.WriteLine("Yanlış!");
                        Console.WriteLine(" ");
                        Console.WriteLine("İpucu => Bu gün {0} gününün dünüdür ", duzenli_kelimeler[sayi + 1]);
                    }
                }

            } while (duzenli_kelimeler[sayi] != cevap);

            Console.Read();
        }
    }
}