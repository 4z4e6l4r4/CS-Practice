namespace inputFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------User List--------------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Add User Count: ");
            int count = Convert.ToInt32(Console.ReadLine());

            string[] userList = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write((i+1)+".  User: ");
                userList[i] = Console.ReadLine();
            }



            Console.WriteLine("-------------------------------------");
            Console.WriteLine("--------------User List--------------");
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine((i+1)+". " + userList[i]);
            }





























        }
    }
}