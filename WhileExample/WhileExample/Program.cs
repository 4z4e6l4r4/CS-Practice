namespace WhileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int i = 0;
            //while (i < 5) //Sınırlı döngü
            //{
            //    Console.WriteLine("While Döngüsü");
            //    i++;
            //}




            while (true) //Sonsuz döngü olacak
            {
                string deger = Console.ReadLine();
                if (deger == "exit")
                {
                    break;
                }
                Console.WriteLine(deger);
            }







































            Console.ReadLine();


        }
    }
}