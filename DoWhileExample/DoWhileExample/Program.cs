namespace DoWhileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int i = 0;

            //do
            //{
            //    Console.WriteLine("Şart sağlanıyor");
            //}
            //while (i>5);
            //{
            //    Console.WriteLine("şart sağlanmıyor");
            //}

            string sifre;

            do
            {
                Console.WriteLine("Şifre giriniz: ");
                sifre = Console.ReadLine();

                if (sifre == "123")
                {
                    Console.WriteLine("Giriş Başarılı");
                }
                else
                {
                    Console.WriteLine("Hatalı Şifre");
                    break;
                }
            }
            while (!String.IsNullOrEmpty(sifre));



























        }
    }
}