using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bilgi yarışmasına hoşgeldiniz.");
            Console.WriteLine();
            Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
            Console.WriteLine();

            int soru = 1;
            string cevap;

            if (soru == 1)
            {
                Console.WriteLine("Türkiyenin başkenti neresidir ?");
                Console.WriteLine();
                Console.WriteLine("A-) İSTANBUL");
                Console.WriteLine("B-) ANKARA");
                Console.WriteLine("C-) İZMİR");
                Console.WriteLine("A-) ANTALYA");
                Console.WriteLine();
                Console.Write("Cevabınız : ");
                cevap = Console.ReadLine();

                if (cevap == "b" || cevap == "B" ) {
                   soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış, toplam puanınız : 0 ");
                }
            }

            if (soru == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Türkiyenin en büyük futbol kulubü : ");
                Console.WriteLine();
                Console.WriteLine("A-) BEŞİKTAŞ");
                Console.WriteLine("B-) EYÜP SPOR");
                Console.WriteLine("C-) KARŞIYAKA ");
                Console.WriteLine("D-) ALTAY ");
                Console.WriteLine();
                Console.Write("Cevabınız : ");
                cevap = Console.ReadLine();

                if (cevap == "a" || cevap == "A")
                {
                    Console.WriteLine("Cevabınız doğru");
                    soru = soru + 1;
                }
                else
                {
                    Console.Write("Cevap yanlış, toplam puanınız : 10 ");
                }
            }

                if (soru == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Türkiyenin en güzel tatil yeri : ");
                    Console.WriteLine();
                    Console.WriteLine("A-) Antalya");
                    Console.WriteLine("B-) Bursa");
                    Console.WriteLine("C-) Çanakkale ");
                    Console.WriteLine("D-) Denizli");
                    Console.WriteLine();
                    Console.Write("Cevabınız : ");
                    cevap = Console.ReadLine();

                    if (cevap == "a" || cevap == "A")
                    {
                        Console.WriteLine("Cevabınız doğru, yarışmayı 30 puan ile bitirdiniz ");
                    }
                    else
                    {
                        Console.Write("Cevap yanlış, toplam puanınız : 20 ");
                    }
                }



            Console.Read();
        }
    }
}
