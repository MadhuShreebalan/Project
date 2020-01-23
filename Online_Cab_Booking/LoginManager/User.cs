using System;
using Online_Cab_Booking.LoginManager;
using Online_Cab_Booking.Common;
using Online_Cab_Booking.Database;
using System.Collections.Generic;

namespace Online_Cab_Booking.LoginManager
{
    public class User
    {
        //UserDatabase userDatabase = new UserDatabase();


        public void GetUserDetails()
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Enter EmailId:");
            string mailId = Console.ReadLine();
            Console.WriteLine("Enter Phone number:");
            string phone = Console.ReadLine();
            UserDatabase.UserRepository.Add(new UserDetails(name, password, mailId, phone));

        }

        //userDatabase.UserRepository.Add(name);
        //userDatabase.UserRepository.Add(password);
        //userDatabase.UserRepository.Add(mailId);
        //userDatabase.UserRepository.Add(phone);

        public void CheckUser()
        {
            try
            {
                
                
                    Console.WriteLine("Enter  name:");
                    string Name = Console.ReadLine();

                    Console.WriteLine("Enter password :");
                    string Password = Console.ReadLine();
                
                
                
                    if (UserDatabase.UserRepository. Equals(Name) && Password.Equals(Password))
                    {


                        Console.WriteLine("User logged in!!");
                    }
                  
                else
                {
                    Console.WriteLine("To Continue Booking Just Sign up");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
            }
       
        }

    }
}
