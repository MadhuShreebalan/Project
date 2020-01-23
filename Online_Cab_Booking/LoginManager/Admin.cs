using System;
using System.Configuration;
using Online_Cab_Booking.Common;
namespace Online_Cab_Booking.LoginManager
{
    public class Admin
    {

        public static string adminValue = ConfigurationManager.AppSettings["admin"].ToString();
        public static string passwordValue = ConfigurationManager.AppSettings["password"].ToString();

        public void ToVerify()
        {
            Console.WriteLine("Enter  name:");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter password :");
            string Password = Console.ReadLine();


            if (Name.Equals(adminValue) && Password.Equals(passwordValue))
            {


                Console.WriteLine("Admin logged in!!");
            }

            else
            {
                User user = new User();
                user.CheckUser();
            }



        }
    }
}
    



