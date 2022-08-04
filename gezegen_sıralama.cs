using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ /*gezegenleri güneşe uzaklıklarına göre sıralama oyunu*/

    struct gezegenler
    {
        public string[] dizi1;
        public int[] dizi2;
    }
    class listele
    {
        public listele(string[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
                Console.WriteLine("{0}. {1} ", i + 1, dizi[i]);

        }
    }
    class sırala
    {
        public string alinan_siralama;
        public string dogru_siralama;
        public sırala()
        {
            alinan_siralama = Console.ReadLine();
            dogru_siralama = "12345678";
            if (alinan_siralama == dogru_siralama)
            {
                Console.Write("Tebrikler, doğru sıralamayı yaptınız!");
            }
            else if (alinan_siralama.IndexOf('1') != 0)
            {
                Console.Write("En baştan hatalısınız, tekrar deneyin!");
            }
            else
            {
                Console.Write("Yeniden deneyin!");
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            gezegenler g1 = new gezegenler();
            g1.dizi1 = new string[8] { "m e r k ü r ", "v e n ü s ", "d ü n y a ", "m a r s ", "j ü p i t e r ", "s a t ü r n ", "u r a n ü s ", "n e p t ü n " };
            listele lis_gez = new listele(g1.dizi1);
            Console.WriteLine("Güneşe uzaklıklarına göre sıralayınız: ");
            sırala sıra_gez = new sırala();

            Console.Read();
        }
    }
}