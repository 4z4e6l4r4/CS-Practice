namespace UserInformationAndProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- User Information Register System -----");
            Console.WriteLine("--------------------------------------------");
            Console.Write("How Many User Information: ");

            //Kaç Kullanıcı Bilgisi Alınacağını Belirleme
            int userInformationCount = Convert.ToInt32(Console.ReadLine());

            //Alınan Kullanıcı Bilgisi Sayısı ile Kullanıcı Bilgilerinini Başlıkları Dizisini Oluşturma
            string[] informationArray = new string[userInformationCount];

            Console.WriteLine("------- Define User Information Title ------");
            Console.WriteLine("--------------------------------------------");
            //Oluşturulan Diziye Dışarıdan Başlık İsmi Ekleme
            for (int i = 0; i < informationArray.Length; i++)
            {
                Console.Write((i+1)+". Information Name: ");
                informationArray[i] = Console.ReadLine();
            }

            Console.WriteLine("------------ Define User Count -------------");
            Console.WriteLine("--------------------------------------------");
            Console.Write("Enter the Number of Users to Add: ");

            //Kullanıcı Listesi Oluşturmak ve Kaç Kullanıcı Ekleneceğini Belirleme
            int userCount = Convert.ToInt32(Console.ReadLine());


            //2 Boyutlu Bir Kullanıcı Dizisi Oluşturmak için userCount ve userInformationCount ile dizi oluşturma
            string[,] userList = new string[userCount, userInformationCount];

            Console.WriteLine("---------- Define User Informations --------");
            Console.WriteLine("--------------------------------------------");

            //Kullanıcı Dizisini Doldurmak için For Döngüsü ile Kullanıcı sayısına ve Özellik sayısına göre dışarıdan bilgi alma
            for (int i = 0; i < userList.GetLength(0); i++)
            {
                Console.WriteLine("--------------------------------------------");

                Console.WriteLine((i+1)+ ". Enter the User's Information");
                for (int j = 0; j < userList.GetLength(1); j++)
                {
                    Console.Write(informationArray[j]+": ");//Kullanıcı Bilgilerinin İsimlerini Yazdırma
                    userList[i, j] = Console.ReadLine();
                }
            }


            Console.WriteLine("---------------- User List -----------------");
            Console.WriteLine("--------------------------------------------");
            //Bütün Kullanıcı Bilgileri alındıktan Sonra Önce Kullanıcı Bilgi Başlıklarını Yazdırma
            for (int i = 0; i < informationArray.Length; i++)
            {
                Console.Write(informationArray[i]+"\t\t");
            }
            Console.WriteLine();

            //Kullanıcı Bilgilerini Yazdırma
            for (int i = 0; i < userList.GetLength(0); i++)
            {

                for (int j = 0; j < userList.GetLength(1); j++)
                {
                    Console.Write(userList[i, j] + "\t\t");
                }
                Console.WriteLine();
            }
        }
    }
}