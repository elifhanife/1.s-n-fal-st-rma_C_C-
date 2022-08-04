using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    /*yay sabitlerinin değeri verildiğinde seri ve paralel bağlı olma durumlarına göre eşdeğer yay sabitini bulan program*/
    class seri
    {
        public int K1;
        public int K2;
        public seri(int k1, int k2)
        {
            K1 = k1;
            K2 = k2;
        }

        public int baglanma
        {
            get
            {
                return K1 * K2 / (K1 + K2);
            }
            set
            {
                K1 = value;
                K2 = value;
            }
        }
    }
    class paralel
    {
        public int S1;
        public int S2;
        public paralel(int s1, int s2)
        {
            S1 = s1;
            S2 = s2;
        }
        public int p_baglanma
        {
            get
            {
                return S1 + S2;
            }

            set
            {
                S1 = value;
                S2 = value;
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            seri yay1 = new seri(4, 12);
            Console.WriteLine("Eşdeğer yay sabiti: " + yay1.baglanma);
            paralel yay2 = new paralel(4, 12);
            Console.Write("Eşdeğer yay sabiti: " + yay2.p_baglanma);

            Console.Read();
        }
    }
}
