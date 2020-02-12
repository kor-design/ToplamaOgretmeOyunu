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
        BASADON:
            int puan = 0;
            Random rand = new Random();
            int sonuc;
            int dogrucevap = 0;
            int yanliscevap = 0;
            do
            {
                int sayi1 = rand.Next(1, 100);
                int sayi2 = rand.Next(1, 100);
                Console.WriteLine("Aşağıdaki işlemin sonucunu yazınız.");
                Console.WriteLine("{0}+{1}=", sayi1, sayi2);
                sonuc = Convert.ToInt32(Console.ReadLine());
                if (sonuc == (sayi1 + sayi2))
                {
                    dogrucevap++;
                    puan = puan + 20;
                    Console.WriteLine("Tebrikler doğru cevap 20 puan kazandınız " +
                        "\nToplam Puanınız {0} " +
                        "\nDoğru cevap sayısı={1} ", puan,dogrucevap);

                }
                else
                {
                    yanliscevap++;
                    puan = puan - 10;
                    Console.WriteLine("Üzgünüz yanlış cevaplandı 10 puan kaybettiniz " +
                        "\nToplam Puanınız {0}" +
                        "\nYanlış cevap sayısı={1}", puan,yanliscevap);
                }
            } while (puan < 100 && puan >= 0);
            if (puan==100)
            {
                Console.WriteLine("Tebrikler oyunu kazandınız");
            }
            if (puan < 0)
            {
                Console.WriteLine("Üzgünüz kaybettiniz");
            }
            Console.WriteLine("Yeni oyun için 1 e basınız.");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim=='1')
            {
                goto BASADON;
            }
            else
            {
                Console.WriteLine("Güle Güle....");
            }
            Console.ReadKey();
            
        }
    }
}
