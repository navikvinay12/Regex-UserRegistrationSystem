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
                "Press 2: To Register your Last Name \n" +
                "Press 3: To enter your Email ID .\n" +
                "Press 4: to enter your Mobile Number.\n" +
                "Press 5: To set your password (minimum 8 characters).\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UserDetails.FirstName();
                        break;
                    case 2:
                        UserDetails.LastName();
                        break;
                    case 3:
                        UserDetails.EmailID();
                        break;
                    case 4:
                        UserDetails.MobileNumber();
                        break;
                    case 5:
                        UserDetails.PassMin8Char();
                        break;
                    default:
                        Console.WriteLine("Invalid option selected ,Please try again !");
                        break;
                }
            }
        }
    }
}