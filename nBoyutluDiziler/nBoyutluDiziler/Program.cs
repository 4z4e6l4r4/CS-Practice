namespace nBoyutluDiziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3 BOYUTLU DİZİLER");

            string[,,] degerler = new string[2, 4, 3]
            {
            { //1. satır (1.boyut)
                //derinlik (2.boyut)
                {"deger1", "deger2", "deger3"}, //1. sütun (2. boyut)
                {"deger4", "deger5", "deger6"}, //2. sütun (2. boyut)
                {"deger7", "deger8", "deger9"}, //3. sütun (2. boyut)
                {"deger10", "deger11", "deger12"} //4. sütun (2. boyut)

            },
                {//2. satır (1.boyut)
                // sütun (2.boyut)
                {"deger1", "deger2", "deger3"}, //derinlik (3. boyut)
                {"deger4", "deger5", "deger6"}, //derinlik (3. boyut)
                {"deger7", "deger8", "deger9"}, //derinlik (3. boyut)
                {"deger10", "deger11", "deger12"} //derinlik (3. boyut)
                }
            };

            //Çok boyutlu dizilerde verilen boyut değerlerinin sonuncusu olan sayısal değer
            //bizim her boyut için kaç değer alacağımızı belirtir
            //[3,4,5] her satırında 5'er değer olduğunu belirityoruz


            string[,,] strings = new string[2, 3, 4];

            strings[0, 0, 0] = "deger1";
            strings[0, 0, 1] = "deger2";
            strings[0, 0, 2] = "deger3";
            strings[0, 0, 3] = "deger4";

            strings[0, 1, 0] = "deger5";
            strings[0, 1, 1] = "deger6";
            strings[0, 1, 2] = "deger7";
            strings[0, 1, 3] = "deger8";

            strings[0, 2, 0] = "deger9";
            strings[0, 2, 1] = "deger10";
            strings[0, 2, 2] = "deger11";
            strings[0, 2, 3] = "deger12";

            strings[1, 0, 0] = "deger13";
            strings[1, 0, 1] = "deger14";
            strings[1, 0, 2] = "deger15";
            strings[1, 0, 3] = "deger16";

            strings[1, 1, 0] = "deger17";
            strings[1, 1, 1] = "deger18";
            strings[1, 1, 2] = "deger19";
            strings[1, 1, 3] = "deger20";

            strings[1, 2, 0] = "deger21";
            strings[1, 2, 1] = "deger22";
            strings[1, 2, 2] = "deger23";
            strings[1, 2, 3] = "deger24";


            for (var i = 0; i < strings.GetLength(0); i++) //Kendi döngüsü 2 toplamda 2 defa dönder
            {
               for (var j = 0; j < strings.GetLength(1); j++) // Kendi döngüsü 3 toplamda 6 defa döner
                {
                    for (var k = 0; k < strings.GetLength(2); k++) //kendi döngüsü 4 toplam 24 defa döner
                    {
                        Console.WriteLine(strings[i,j,k]);
                    }
                    Console.WriteLine("---------------");
                }
            }









































        }
    }
}