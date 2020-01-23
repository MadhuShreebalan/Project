using System;
using System.Collections.Generic;
using Online_Cab_Booking.Database;

namespace Online_Cab_Booking.LoginManager
{
    class UserDetails

    {
        UserDatabase userDatabase = new UserDatabase();

        public string Name { get; set; }
        public string Password { get; set; }
        public string MailId { get; set; }
        public string Phone { get; set; }
       
        public UserDetails(string name,string pass,string mail,string num)
        {
            this.Name = name;
            this.Password = pass;
            this.MailId = mail;
            this.Phone=num;
        }
    }
}
