using System;
using System.Collections.Generic;
using Online_Cab_Booking.LoginManager;

namespace Online_Cab_Booking.Database
{
    public class UserDatabase
    {
       public  static Dictionary<string, string> userDetails = new Dictionary<string, string>();
             static UserDatabase()
        {
            userDetails.Add("jeffy@gmail.com", "1@3");
            userDetails.Add("jeevi@gmail.com", "*2!");
            userDetails.Add("hema@gmail.com", "87^");
        }

         internal static List<UserDetails> UserRepository = new List<UserDetails>();
        
    }
}
