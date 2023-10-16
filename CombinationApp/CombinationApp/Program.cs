namespace KombinasyonUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Dışarıdan Girilen Sayının 1-n (3lü Kombinasyon) arasındaki sayıların kombinasyonunu bulup ekrana yazdırın
            //Ve toplamda kaç kombinasyon olduğunu en sona yazdırın


            //int sayi1 = 5;
            //int sayi2 = 8;

            // Console.WriteLine("sayı 1:"+sayi1+"sayi 2:"+sayi2);
            // Console.WriteLine($"Sayi 1: {sayi1} \nSayi 2: {sayi2}");
            //Console.WriteLine("Sayi 1: {0} \nSayi 2: {1} \nisim: {4}",sayi1,sayi2,2,5,"Erhan");



            Console.Write("Kombinasyonu Alınacak Sayı Aralığını Giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());//1-n değerlerin kombinasyonunu bulma



            for (int i = 1; i <= n; i++)//Tekli Kombinasyon
            {
                for (int j = 1; j <= n; j++)//İkili Kombinasyon
                {
                    for (int k = 1; k <= n; k++)//Üçlü Kombinasyon
                    {
                        Console.WriteLine($"{i}, {j}, {k}");
                    }

                }

            }



            int[] sifre = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            int s1 = 4, s2 = 7, s3 = 1, s4 = 9;//4719
            int hatasayisi = 0;

            for (int i = 0; i < sifre.Length; i++)//Tekli Kombinasyon
            {
                for (int j = 0; j < sifre.Length; j++)//İkili Kombinasyon
                {
                    for (int k = 0; k < sifre.Length; k++)//Üçlü Kombinasyon
                    {
                        for (int m = 0; m < sifre.Length; m++)
                        {

                            if (s1 == i && s2 == j && s3 == k && s4 == m)
                            {
                                Console.WriteLine("Doğru Şifre Aşağıdaki");
                            }
                            Console.WriteLine($"{i}, {j}, {k}, {m}");
                            hatasayisi++;
                            if (hatasayisi == 3)
                            {
                                Console.WriteLine("3 Hatalı Giriş Yapıldı Şifre Bloke Oldu");
                                break;
                            }
                        }
                        if (hatasayisi == 3) break;
                    }
                    if (hatasayisi == 3) break;
                }
                if (hatasayisi == 3) break;
            }
        }
    }
}