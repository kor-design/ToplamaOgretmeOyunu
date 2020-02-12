using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaOgret
{
    class Program
    {
        static void Main(string[] args)
        {
            int puan = 0 ;
            BASADON:
            Random rand = new Random();
            int sayi1 = rand.Next(1, 100);
            int sayi2 = rand.Next(1, 100);
            Console.WriteLine("Aşağıdaki işlemin sonucunu yazınız.");
            Console.WriteLine("{0}+{1}=", sayi1, sayi2);
            int sonuc = Convert.ToInt32(Console.ReadLine());
            if (puan >= 0 && puan < 100)
            {
                if (sonuc == (sayi1 + sayi2))
                {
                    puan = puan + 20;
                    Console.WriteLine("Tebrikler doğru cevap 20 puan kazandınız \nToplam Puanınız {0}", puan);
                    goto BASADON;
                }
                else
                {
                    puan = puan - 10;
                    Console.WriteLine("Üzgünüz yanlış cevaplandı 10 puan kaybettiniz \n Toplam Puanınız {0}", puan);
                    goto BASADON;
                }
            }
            else if (puan < 0)
            {
                Console.WriteLine("oyunu kaybettiniz... :(");
            }
            else if (puan == 100)
            {
                Console.WriteLine("Oyunu kazandınız... :)");
            }


            Console.Read();
        }
    }
}
