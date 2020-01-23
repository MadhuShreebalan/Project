using System;
using Online_Cab_Booking.Common;
using Online_Cab_Booking.LoginManager;

namespace Online_Cab_Booking.LoginManager
{
    public static class Login
    {
        internal static void SelectChoice()
        {
            try
            {
                Console.WriteLine("**************************WELCOME TO ONLINE BOOKING****************************");
                Console.WriteLine();

                Console.WriteLine("Enter your choice  1.Signup 2. login 3. Exit");
                int choice = int.Parse(Console.ReadLine());
                //     Console.WriteLine("Are you a 1.user or 2.admin?");
                //int Actor = int.Parse(Console.ReadLine());
                User user = new User();
                Admin adminuser = new Admin();

                switch (choice)
                {
                    case 1:
                            user.GetUserDetails();
                            break;
                    case 2:
                            adminuser.ToVerify();
                              break;
                    case 3:
                        user.CheckUser();
                        break;
                    default:
                        Console.WriteLine("Enter valid option!!");
                        break;
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}



