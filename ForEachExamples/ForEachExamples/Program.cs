using System.Collections.Concurrent;

namespace ForEachExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Erhan", "Adem", "Gülsüm", "Büşra" };

            foreach(string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            var isimler2 = new[] {//Dizi içinde dizi tanımlama
                new[]{ "Erhan","Kaya","33"},
                new[]{ "Ahmet","Kasım"},
                new[]{ "Zülal","Sarıoğlu"},
                new[]{ "Furkan","Ermiş"},
                new[]{ "Azra","Yüksel"}
            
            };

            foreach (var isim in isimler2)
            {
                foreach (var isim2 in isim)
                {
                    Console.Write(isim2+" ");
                }
                Console.WriteLine();
            }






        }
    }
}