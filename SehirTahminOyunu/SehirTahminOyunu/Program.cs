using System.Collections.Concurrent;

namespace SehirTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -------------- Şehir Tahmin Oyunu -------------- ");

            //dizi oluştur. şehirleri ekle. şehir sorgusu yap

            string[] sehirler = { "İstanbul", "Ankara" };

            Random rastgele = new Random();

            int pcSkor = 0, kullaniciSkor = 0;

            bool durum = true;
            int tahminSayisi = 5;

            while (durum)
            {
                Console.WriteLine("---- Şehir Tahmin Oyunu ----");
                Console.WriteLine("----------------------------");
                int pcTahmin = rastgele.Next(sehirler.Length);
                string pcSehirTahmin = sehirler[pcTahmin];
                Console.WriteLine("------ Şehir Listesi -------");
                Console.WriteLine("----------------------------");
                foreach (string sehir in sehirler)
                {
                    Console.WriteLine(sehir);
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine("----- Tahmin Et Kazan ------");
                Console.WriteLine("----------------------------");
                Console.Write("Tahmininiz: ");

                string kullaniciSehirTahmin = Console.ReadLine();
                if (kullaniciSehirTahmin == "Çıkış")
                {
                    Console.WriteLine("----- Oyun Kapanıyor. ------");
                    Console.WriteLine("----------------------------");
                    durum = false;
                    return;
                }

                if (kullaniciSehirTahmin==pcSehirTahmin)
                {
                    kullaniciSkor++;
                    Console.WriteLine("** Tebrikler Doğru Tahmin **");
                }
                else
                {
                    pcSkor++;
                    Console.WriteLine("***** Yanlış Tahmin :( *****");
                }
                Console.WriteLine("----------------------------");
                Console.WriteLine("-------- Tahminler ---------");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Pc: {pcSehirTahmin} Kullanıcı: {kullaniciSehirTahmin}");
                Console.WriteLine("--------- Skorlar ----------");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Pc Skor: {pcSkor} Kullanıcı Skor: {kullaniciSkor}");
                if (kullaniciSkor == tahminSayisi)
                {
                    Console.Clear();
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("******************************");
                        Console.WriteLine("***** Tebrikler Kazandın *****");
                        Console.WriteLine("******************************");
                        Thread.Sleep(300);
                        Console.Beep();
                        Console.Clear();
                    }
                    kullaniciSkor = 0;
                    pcSkor = 0;
                }
                else if (pcSkor == tahminSayisi)
                {
                    Console.Clear();
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("******************************");
                        Console.WriteLine("***** Bilgisayar Kazandı *****");
                        Console.WriteLine("******************************");
                        Thread.Sleep(300);
                        Console.Beep();
                        Console.Clear();
                    }
                    kullaniciSkor = 0;
                    pcSkor = 0;
                }
                Console.ReadLine();
                Console.Clear();
            }

            //int tahmin = rastgele.Next(10,20); //index mantığıyla çalıştığı için 10 u dahil ediyor ama 20 yi dahil etmiyor
            //Console.WriteLine(tahmin);

            //int tahmin = rastgele.Next(sehirler.Length);
            //Console.WriteLine(sehirler[tahmin]);






























            Console.ReadLine();
        }
    }
}