using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    /*Bir otomobilin 100 km de yaptığı yakıt tüketimine (L) ortalama yakıt tüketimi denir. Kullanıcıdan son 2 yakıt alma sırasında aracın km değerleri ve
     son yakıt alımında ödenen tutar istenerek ortalama yakıt tüketimini TL cinsinden hesaplayan program*/
    class Otomobil
    {
        public int km;
        public double tutar;
        public double hesapla(int a, int b, double c)
        {
            double ort_yakit = c / (a - b) * 10d;
            return ort_yakit;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Otomobil yol1 = new Otomobil();
            Otomobil yol2 = new Otomobil();
            Otomobil tl = new Otomobil();

            Console.Write("Aracınıza ait ilk kilometre değerini girin: ");
            yol1.km = int.Parse(Console.ReadLine());
            Console.Write("Son kilometre değerini girin: ");
            yol2.km = int.Parse(Console.ReadLine());
            Console.Write("Ödediğiniz tutarı girin (TL): ");
            tl.tutar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Aracınızın ortalama yakıt tüketimi: {0:0.00} TL", tl.hesapla(yol2.km, yol1.km, tl.tutar));

            Console.Read();
        }
    }
}
