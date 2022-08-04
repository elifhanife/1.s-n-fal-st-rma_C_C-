using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fit_kal_uygulama
{
    /* Bazal Metabolizma Hızı, vücut fonksiyonlarının yerine getirilmesi için gerekli enerji miktarıdır.*/
    /* Kullanıcının kilo,boy,yaş ve fiziksel aktifliği bilgilerini alıp 
    bazal metabolizma hızını,ideal kilosunu, ne kadar kilo alması/vermesi 
    gerektiğini ve günlük kalori ihtiyacını hesaplayıp ekrana yazdıran program */
    struct bilgiler
    {
        public int boy, kilo, yas;

        public bilgiler(int boy, int kilo, int yas)
        {
            this.boy = boy;
            this.kilo = kilo;
            this.yas = yas;
        }
        public static double kadin, erkek;
        public double bmh_kadin()
        {
            kadin = 665.1 + (9.56 * kilo) + (1.85 * boy) - (4.68 * yas);
            return kadin;
        }
        public double bmh_erkek()
        {
            erkek = 66.5 + (13.75 * kilo) + (5.03 * boy) - (6.75 * yas);
            return erkek;
        }
        public static double ikilo_kadin, ikilo_erkek;
        public double idealkilo_kadin()
        {
            ikilo_kadin = 45.5 + (2.3 / 2.54) * (boy - 152.4);
            return ikilo_kadin;
        }

        public double idealkilo_erkek()
        {
            ikilo_erkek = 50 + (2.3 / 2.54) * (boy - 152.4);
            return ikilo_erkek;
        }
    }
    class bilgiler2
    {
        char cins1 = 'k';
        char cins2 = 'e';

        public void hesapla(char cins, bilgiler hesaplama_bilgileri)
        {
            double fark1 = hesaplama_bilgileri.idealkilo_kadin() - hesaplama_bilgileri.kilo;
            double fark2 = hesaplama_bilgileri.idealkilo_erkek() - hesaplama_bilgileri.kilo;


            if (cins == cins1)
            {
                Console.WriteLine("Bazal Metabolizma Hızı: {0}", hesaplama_bilgileri.bmh_kadin());
                Console.WriteLine("İdeal kilonuz: {0:0.0}", hesaplama_bilgileri.idealkilo_kadin());

                if (fark1 > 0)
                {
                    Console.WriteLine("{0:0.0} kilo almalısın!", fark1);

                }
                else if (fark1 < 0)
                {
                    Console.WriteLine("{0:0.0} kilo vermelisin!", Math.Abs(fark1));

                }
                else
                {
                    Console.WriteLine("İdeal kilondasın!");
                }
            }
            else if (cins == cins2)
            {
                Console.WriteLine("Bazal Metabolizma Hızı: {0}", hesaplama_bilgileri.bmh_erkek());
                Console.WriteLine("İdeal kilonuz: {0:0.0}", hesaplama_bilgileri.idealkilo_erkek());

                if (fark2 > 0)
                {
                    Console.WriteLine("{0:0.0} kilo almalısın!", fark2);

                }
                else if (fark2 < 0)
                {
                    Console.WriteLine("{0:0.0} kilo vermelisin!", Math.Abs(fark2));

                }
                else
                {
                    Console.WriteLine("İdeal kilondasın!");

                }
            }
            else
            {
                Console.WriteLine("Cinsiyetini k ya da e şeklinde girmelisin!");
            }
        }
    }
    class Program
    {
        public static int aktiflik;
        public static void sor()
        {
            Console.WriteLine("Fiziksel aktivite durumu (numara seçin): ");
            string[] dizi1 = { "çok pasif", "pasif", "kısmen hareketli", "hareketli", "sürekli hareketli" };
            string[] dizi2 = { "hiç egzersiz yok", "haftada 1-3 kez egzersiz", "haftada 3-5 kez egzersiz", "haftada 6-7 kez egzersiz", "çok yoğun egzersiz" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. {1} => ({2})", i + 1, dizi1[i].ToUpper(), dizi2[i]);
            }

            aktiflik = int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int boy, kilo, yas;
            char cins;
            Console.Write("Boy (cm): ");
            boy = int.Parse(Console.ReadLine());
            Console.Write("Kilo: ");
            kilo = int.Parse(Console.ReadLine());
            Console.Write("Yaş: ");
            yas = int.Parse(Console.ReadLine());
            bilgiler hesaplama_bilgileri = new bilgiler(boy, kilo, yas);
            Console.Write("Cinsiyet (k/e): ");
            cins = Convert.ToChar(Console.ReadLine());
            sor();
            bilgiler2 bilgileri_isle = new bilgiler2();
            bilgileri_isle.hesapla(cins, hesaplama_bilgileri);

            switch (aktiflik)
            {
                case 1:
                    {
                        if (cins == 'k')
                            Console.WriteLine("Günlük kalori ihtiyacın: {0:0.0}", hesaplama_bilgileri.bmh_kadin() * 1.2);
                        else if (cins == 'e')
                        {
                            Console.WriteLine("Günlük kalori ihtiyacın: {0:0.0}", hesaplama_bilgileri.bmh_erkek() * 1.2);
                        }
                    }
                    break;
                case 2:
                    {
                        if (cins == 'k')
                            Console.WriteLine("Günlük kalori ihtiyacın: {0:0.0}", hesaplama_bilgileri.bmh_kadin() * 1.375);
                        else if (cins == 'e')
                        {
                            Console.WriteLine("Günlük kalori ihtiyacın: {0:0.0}", hesaplama_bilgileri.bmh_erkek() * 1.375);
                        }
                    }
                    break;
                case 3:
                    {
                        if (cins == 'k')
                            Console.WriteLine("Günlük kalori ihtiyacın: {0:0.0}", hesaplama_bilgileri.bmh_kadin() * 1.55);
                        else if (cins == 'e')
                        {
                            Console.WriteLine("Günlük kalori ihtiyacın: {0:0.0}", hesaplama_bilgileri.bmh_erkek() * 1.55);
                        }
                    }
                    break;
                case 4:
                    {
                        if (cins == 'k')
                            Console.WriteLine("Günlük kalori ihtiyacın: {0:0.0}", hesaplama_bilgileri.bmh_kadin() * 1.725);
                        else if (cins == 'e')
                        {
                            Console.WriteLine("Günlük kalori ihtiyacın: {0:0.0}", hesaplama_bilgileri.bmh_erkek() * 1.725);
                        }
                    }
                    break;
                case 5:
                    {
                        if (cins == 'k')
                            Console.WriteLine("Günlük kalori ihtiyacın: {0:0.0}", hesaplama_bilgileri.bmh_kadin() * 1.9);
                        else if (cins == 'e')
                        {
                            Console.WriteLine("Günlük kalori ihtiyacın: {0:0.0}", hesaplama_bilgileri.bmh_erkek() * 1.9);
                        }
                    }
                    break;
            }
            Console.Read();
        }
    }
}
