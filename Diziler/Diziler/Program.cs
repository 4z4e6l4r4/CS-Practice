using System.ComponentModel;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TEK BOYUTLU DİZİLER!");

            //Dizinin Değişken Türü [] ismi = Dizinin Değerleri
            string[] isimler = { "Erhan", "Ferdi", "Dilara" }; //initializr = ön tanımlı değer atama 
            string[] isimler2 = new string[] { "isim1", "isim2", "isim3" }; //initializr = ön tanımlı değer atama 

            Console.WriteLine(isimler[2]);

            Console.WriteLine(isimler[1]); //Ferdi'yi olarak ekrana yazıldı
            isimler[1]="Merve";
            Console.WriteLine(isimler[1]); //Ferdi'nin yerine Merve ismini getirip yazdırdık

            //Dizi oluşturduktan sonra oluşturulan dizi eleman sayısı neyse o şekilde devam eder. Ek bir eleman ekleyemezsin.
            //Dizinin boyutu belli olmalı sonrasında eleman ekleyemezsin

            Console.WriteLine(isimler); //Hangi türde olduğunu yazdırır


            isimler[3] = "Ahmet"; //Dizi oluştuğunda 3 eleman olarak oluştuğundan 4. eleman diziye eklenemez
            Console.WriteLine(isimler[3]); //Dizi boyutunu geçtiği için bound hatası (boyut aşıldı) alınır

            int[] sayilar = new int[5]; //Bu dizi 5 eleman alabilir demek.
            //diziye verilern dizi boyutu sayısı count (lenght) olarak değerlendirilir.
            //Eleman eklerken n-1 değerine count kadar eleman eklenir.
            sayilar[0] = 2;
            sayilar[1] = 3;
            sayilar[2] = 4;
            sayilar[3] = 5;
            sayilar[4] = 6;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

















        }
    }
}