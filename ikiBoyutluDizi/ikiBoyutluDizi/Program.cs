namespace ikiBoyutluDizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 BOYUTLU DİZİ");

            string[] isimler = new string[3]; //tek boyutlu dizi

            string[,] kullanicilar = new string[3,4]; //matris oluşturdum 3 satır iken 4 sütunu açar

            //Dizinin 1. satırı
            kullanicilar[0, 0] = "Erhan"; //1.satır 1.sütun
            kullanicilar[0, 1] = "Kaya"; //1.satır 2.sütun
            kullanicilar[0, 2] = "33"; //1.satır 3.sütun
            kullanicilar[0, 3] = "Erkek"; //1.satır 4.sütun

            //Dizinin 2. satırı
            kullanicilar[1, 0] = "Yasir";
            kullanicilar[1, 1] = "Akkaya";
            kullanicilar[1, 2] = "25";
            kullanicilar[1, 3] = "Erkek";

            //Dizinin 3. satırı
            kullanicilar[2, 0] = "Süheyla";
            kullanicilar[2, 1] = "Kenet";
            kullanicilar[2, 2] = "24";
            kullanicilar[2, 3] = "Kadın";

            //bu diziyi yazdırmak için
            for (int i = 0; i < kullanicilar.GetLength(0); i++)
                //GetLength çok boyutlu dizilerde kullanılır
            {
                Console.Write(kullanicilar[i, 0]);
                Console.Write(kullanicilar[i, 1]);
                Console.Write(kullanicilar[i, 2]);

            }

            Console.WriteLine("\n ------------------------");

            string[,] users = new string[3, 3]
            {
                {"Erhan", "Kaya", "33" },
                {"Yasir", "Akkaya", "25" },
                {"Süheyla", "Kenet", "24" }
            };

            for (int i = 0; i < users.GetLength(0); i++)
            {
                for (int j = 0; j < users.GetLength(1); j++)
                {
                    Console.Write(users[i,j]+"\t");
                }
                Console.WriteLine();
            }


















        }
    }
}