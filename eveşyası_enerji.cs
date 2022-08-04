using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    /* Seçilen ev eşyalarının seçilen süre içerisindeki enerji tüketimlerini bulan program*/
    class ev_aletleri
    {
        public int tuketim;
        public int index;
        public int enerji;
    }
    struct hesapla
    {
        public void bul(ev_aletleri esya1)
        {
            Program fonk = new Program();
            switch (esya1.index)
            {
                case 1:
                    {
                        switch (esya1.tuketim)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Buzdolabının harcaması: {0:0.00} kw/gün", fonk.islem_yap1(esya1.enerji));
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Buzdolabının harcaması: {0:0.00} kw/ay", fonk.islem_yap1(esya1.enerji) * 30);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Buzdolabının harcaması: {0:0.00} kw/yıl", fonk.islem_yap1(esya1.enerji) * 365);
                                }
                                break;
                        }

                    }
                    break;
                case 2:
                    {
                        switch (esya1.tuketim)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Elektrikli süpürgenin harcaması: {0:0.00} kw/gün", fonk.islem_yap2(esya1.enerji));
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Elektrikli süpürgenin harcaması: {0:0.00} kw/ay", fonk.islem_yap2(esya1.enerji) * 30);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Elektrikli süpürgenin harcaması: {0:0.00} kw/yıl", fonk.islem_yap2(esya1.enerji) * 365);
                                }
                                break;
                        }
                    }
                    break;
                case 3:
                    {
                        switch (esya1.tuketim)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Fırının harcaması: {0:0.00} kw/gün", fonk.islem_yap3(esya1.enerji));
                                }
                                break;
                            case 2:
                                {
                                    Console.WriteLine("Fırının harcaması: {0:0.00} kw/ay", fonk.islem_yap3(esya1.enerji) * 30);
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine("Fırının harcaması: {0:0.00} kw/yıl", fonk.islem_yap3(esya1.enerji) * 365);
                                }
                                break;
                        }
                    }
                    break;
            }
        }
    }

    class Program
    {
        public double islem_yap1(int watt)
        {
            double gunluk_fiyat = 1.2d;
            return watt * gunluk_fiyat / 1000;
        }
        public double islem_yap2(int watt)
        {
            double gunluk_fiyat = 2.4d;
            return watt * gunluk_fiyat / 1000;
        }
        public double islem_yap3(int watt)
        {
            double gunluk_fiyat = 4.5d;
            return watt * gunluk_fiyat / 1000;
        }

        static void Main(string[] args)
        {
            ev_aletleri esya1 = new ev_aletleri();
            hesapla esya = new hesapla();
            Console.WriteLine("1. Buzdolabı");
            Console.WriteLine("2. Elektrikli Süpürge");
            Console.WriteLine("3. Fırın");
            Console.Write("Ev eşyanızı seçin: ");
            esya1.index = int.Parse(Console.ReadLine());
            Console.Write("Tüketilen enerji: ");
            esya1.enerji = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tüketim süresi: ");
            Console.WriteLine("1. Günlük");
            Console.WriteLine("2. Aylık");
            Console.WriteLine("3. Yıllık");
            esya1.tuketim = int.Parse(Console.ReadLine());
            esya.bul(esya1);
            Console.Read();
        }
    }
}
