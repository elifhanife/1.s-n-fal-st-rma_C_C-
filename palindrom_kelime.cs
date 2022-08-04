using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Kullanıcının girdiği ismin palindrom (baştan ve sondan okunuşu aynı olan kelime-örneğin nalan) olup olmadığını ekrana yazan program*/
/* Program en fazla 9 harften oluşan kelimeler için yazılmıştır.*/
namespace ConsoleApp1
{
    class PalindromKelime
    {
        static void Main()
        {
            Console.Write("İsminiz kaç harflidir? : ");
            int isim = Convert.ToInt32(Console.ReadLine());
            if (isim % 2 == 0)
                Console.WriteLine("Üzgünüm, isminiz palindrom olamaz!");
            else
            {
                string[] array_isim = new string[isim];
                for (int i = 0; i < isim; i++)
                {
                    Console.Write("İsminizin {0}. harfini girin: ", i + 1);
                    array_isim[i] = Console.ReadLine();
                }
                if (isim < 6)
                {
                    if (array_isim[0] == array_isim[isim - 1])
                    {
                        if (array_isim[1] == array_isim[isim - 2])
                        {
                            Console.WriteLine("İsminiz bir palindrom kelimedir!");
                        }
                        else
                        {
                            Console.WriteLine("İsminiz bir palindrom kelime değildir!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("İsminiz bir palindrom kelime değildir!");
                    }

                }
                else
                {
                    if (array_isim[0] == array_isim[isim - 1])
                    {
                        if (array_isim[1] == array_isim[isim - 2])
                        {
                            if (array_isim[2] == array_isim[isim - 3])
                            {
                                if (array_isim[3] == array_isim[isim - 4])
                                {
                                    Console.WriteLine("İsminiz bir palindrom kelimedir!");
                                }
                                else
                                {
                                    Console.WriteLine("İsminiz bir palindrom kelime değildir!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("İsminiz bir palindrom kelime değildir!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("İsminiz bir palindrom kelime değildir!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("İsminiz bir palindrom kelime değildir!");
                    }
                }

            }
            Console.Read();
        }
    }
}