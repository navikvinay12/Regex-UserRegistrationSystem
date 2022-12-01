namespace UserRegistrationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration using Regex.\n");
            while(true)
            {
                Console.WriteLine("Please select any one from below :\n" +
                "Press 1 : To Register your First Name.\n" +
                "Press 2: To Register your Last Name ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UserDetails.FirstName();
                        break;
                    case 2:
                        UserDetails.LastName();
                        break;
                    default:
                        Console.WriteLine("Invalid option selected ,Please try again !");
                        break;
                }
            }
        }
    }
}