namespace TimeAndDate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time and Date");

            //   Console.WriteLine( "Merhaba ");
            // Thread.Sleep(5000);//1 saniyelik sistem uyutulur.
            //Console.WriteLine("Merhaba C# Dersi");

            //Koordinat sistemini kullanabilmemek için

            //Console.SetCursorPosition(10, 10);
            //Console.WriteLine("Erhan");

            //Console.SetCursorPosition(13, 10);
            //Console.WriteLine("KAYA");

            while (true)
            {
                Console.SetCursorPosition(20, 10);
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("* ");
                    Thread.Sleep(300);
                }
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(40, 10 + i);
                    Console.Write("*");
                    Thread.Sleep(300);
                }
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(40 - (i * 2), 20);
                    Console.Write("* ");
                    Thread.Sleep(300);
                }
                for (int i = 0; i < 10; i++)
                {
                    Console.SetCursorPosition(20, 20 - i);
                    Console.Write("*");
                    Thread.Sleep(300);
                }

                Console.Clear();
            }





            //for (int j = 0;j < 8; j++)
            //{
            //    Console.SetCursorPosition(2, 17);
            //    Console.WriteLine("");
            //    Thread.Sleep(100);

            //    int n = 17;
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write(i<n-1 ? " " : "*");
            //    }

            //}


































        }
    }
}