Er
Erhan Kaya
15:34
namespace HesaplamaProgrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hesaplama();
        }

        public static void Hesaplama()
        {
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("-------- Hesaplama Programı --------\n"+
                "------------------------------------\n" +
                "-------- Hesaplama Seçiniz ---------\n"+
                "------------------------------------\n"+
                "Basit Hesap Makinesi_____________(1)\n"+
                "Dairenin Alan Hesaplaması________(2)\n" +
                "Dairenin Çevre Hesaplaması_______(3)\n" +
                "Dikdörtgen Alan Hesaplaması______(4)\n" +
                "Dikdörtgen Çevre Hesaplaması_____(5)\n" +
                "Çıkış Yap________________________(0)\n");

                Console.Write("Seçiminiz: ");

                int secim = Convert.ToInt32(Console.ReadLine());

                Program program = new Program();

                switch (secim)
                {
                    case 1:
                        program.BasitHesapMakinesi();
                        break;
                    case 2:
                        program.DaireAlanHesabi();
                        break;
                    case 3:
                        program.DaireCevreHesabi();
                        break;
                    case 4:
                        program.DikdortgenAlanHesabi();
                        break;
                    case 5:
                        program.DikdortgenCevreHesabi();
                        break;
                    case 0:
                        Console.WriteLine("Çıkış Yapılıyor....");
                        durum = false;
                        break;
                    default:
                        Console.WriteLine("Tanımsız Seçim Yapıldı Tekrar Deneyiniz.");
                        break;
                }

            }
        }

        public void BasitHesapMakinesi()
        {
            Console.Clear();
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("------- Basit Hesap Makinesi -------\n" +
                "------------------------------------\n" +
                "Üst Menüye Geç___________________(E)\n");

                Console.Write("1. Sayı: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2. Sayı: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Operatör Seçiniz ( + - * / % ): ");
                string oprt = Console.ReadLine();
                oprt = oprt.Substring(0, 1);

                double sonuc = 0;
                switch (oprt)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);

                        break;
                    case "-":
                        sonuc = sayi1 - sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);

                        break;
                    case "*":
                        sonuc = sayi1 * sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);

                        break;
                    case "/":
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);

                        break;
                    case "%":
                        sonuc = sayi1 % sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);

                        break;
                    case "E":
                        Console.WriteLine("Üst Menüye Geçiliyor...");
                        durum = false;
                        break;
                    default:
                        Console.WriteLine("Tanımsız Operatör Seçildi.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void DaireAlanHesabi()
        {
            Console.Clear();
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("------ Dairenin Alan Hesabı ------\n" +
                "------------------------------------\n" +
                "Üst Menüye Geç___________________(E)\n");

                Console.Write("Yarıçap Giriniz: ");
                string yaricap = Console.ReadLine();

                if (yaricap.Substring(0, 1) == "E")
                {
                    durum = false;
                    Console.WriteLine("Üst Menüye Geçiliyor..");
                }
                else
                {
                    double r = Convert.ToDouble(yaricap);
                    double pi = Math.PI;
                    double sonuc = pi * r * r;
                    Console.WriteLine("Dairenin Alan Hesap Sonucu: "+sonuc);
                }
                Console.ReadLine();
                Console.Clear();

            }
        }
        public void DaireCevreHesabi()
        {
            Console.Clear();
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("------ Dairenin Çevre Hesabı ------\n" +
                "------------------------------------\n" +
                "Üst Menüye Geç___________________(E)\n");

                Console.Write("Yarıçap Giriniz: ");
                string yaricap = Console.ReadLine();

                if (yaricap.Substring(0, 1) == "E")
                {
                    durum = false;
                    Console.WriteLine("Üst Menüye Geçiliyor..");
                }
                else
                {
                    double r = Convert.ToDouble(yaricap);
                    double pi = Math.PI;
                    double sonuc = 2*pi * r;
                    Console.WriteLine("Dairenin Çevre Hesap Sonucu: "+sonuc);
                }
                Console.ReadLine();
                Console.Clear();

            }
        }
        public void DikdortgenAlanHesabi()
        {
            Console.Clear();
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("------ Dikdörtgen Alan Hesabı ------\n" +
                "------------------------------------\n" +
                "Üst Menüye Geç___________________(E)\n");

                Console.Write("Uzun Kenar: ");
                string uzunKenar = Console.ReadLine();

                Console.Write("Kısa Kenar: ");
                string kisaKenar = Console.ReadLine();

                if (uzunKenar.Substring(0, 1) == "E" || kisaKenar.Substring(0, 1) == "E")
                {
                    durum = false;
                    Console.WriteLine("Üst Menüye Geçiliyor..");
                }
                else
                {
                    double uk = Convert.ToDouble(uzunKenar);
                    double kk = Convert.ToDouble(kisaKenar);
                    double sonuc = uk*kk;
                    Console.WriteLine("Dikdörtgen Alan Hesab Sonucu: " + sonuc);
                }
                Console.ReadLine();
                Console.Clear();

            }
        }
        public void DikdortgenCevreHesabi()
        {
            Console.Clear();
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("------ Dikdörtgen Çevre Hesabı ------\n" +
                "------------------------------------\n" +
                "Üst Menüye Geç___________________(E)\n");

                Console.Write("Uzun Kenar: ");
                string uzunKenar = Console.ReadLine();

                Console.Write("Kısa Kenar: ");
                string kisaKenar = Console.ReadLine();

                if (uzunKenar.Substring(0, 1) == "E" || kisaKenar.Substring(0, 1) == "E")
                {
                    durum = false;
                    Console.WriteLine("Üst Menüye Geçiliyor..");
                }
                else
                {
                    double uk = Convert.ToDouble(uzunKenar);
                    double kk = Convert.ToDouble(kisaKenar);
                    double sonuc = 2*(uk + kk);
                    Console.WriteLine("Dikdörtgen Çevre Hesab Sonucu: " + sonuc);
                }
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}