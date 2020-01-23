//using System;
//using System.Data.SqlClient;
//namespace Online_Cab_Booking
//{
//    class UserSQL
//    {
//        SqlConnection con = new SqlConnection("Data source = .; Database = UserDetails; Integrated Security = SSPI");
//        SqlCommand cmd = new SqlCommand( );
        
//        public void GetUserDetails(SqlConnection connection)
//        {

//            Console.Write("Enter username: ");
//            string Name = Console.ReadLine();
//            Console.Write("Enter user mail id: ");
//            string MailId = Console.ReadLine();
//            Console.Write("Enter user mob no: ");
//            string Mobile = Console.ReadLine();
//            string insertValue = "INSERT INTO USERDETAIL (Name,Mail-ID,Mobile) VALUES(@Name,@MailId,@Mobile)";
//            SqlCommand sqlCommand = new SqlCommand(insertValue, connection);
//            sqlCommand.Parameters.AddWithValue("@Name", Name);
//            sqlCommand.Parameters.AddWithValue("@Mail-ID", MailId);
//            sqlCommand.Parameters.AddWithValue("@Mobile", Mobile);
//            sqlCommand.ExecuteNonQuery();
//        }
//        public void DisplayUserDetail(SqlConnection connection)
//        {
//            string query = "SELECT Name,Mail-ID,Mobile FROM USERDETAIL";
//            SqlCommand sqlCommand = new SqlCommand(query, connection);
//            SqlDataReader reader = sqlCommand.ExecuteReader();
//            while (reader.Read())
//            {
//                Console.WriteLine("NAME: {0}\nMail-ID: {1}\nMobile: {2}\n", reader.GetString(0), reader.GetString(1), reader.GetString(2));
//            }
//            reader.Close();
//        }
        
//        public void UpdateUserName(SqlConnection connection)
//        {
//            Console.WriteLine("Enter the mail id");
//            string MailId = Console.ReadLine();
//            Console.WriteLine("Enter the updated name: ");
//            String Name = Console.ReadLine();
//            string updateUser = "UPDATE USERDETAIL SET USERNAME = @Name WHERE MAILID = @MailId;";
//            SqlCommand command = new SqlCommand(updateUser, connection);
//            command.Parameters.Add("@MAIL-ID", System.Data.SqlDbType.VarChar);
//            command.Parameters.Add("@Name", System.Data.SqlDbType.VarChar);
//            command.Parameters["@MAIL-ID"].Value = MailId;
//            command.Parameters["@Name"].Value = Name;
//            command.ExecuteNonQuery();

//        }
//        public void UpdateUserMobNo(SqlConnection connection)
//        {
//            Console.WriteLine("Enter the updated mob no: ");
//            String Mobile = Console.ReadLine();
//            string updateUser = "UPDATE USERDETAIL SET MOBNO = @mobNo WHERE MAILID = @MailId;";
//            SqlCommand command = new SqlCommand(updateUser, connection);
//            command.Parameters.Add("@Mobile", System.Data.SqlDbType.VarChar);
//            command.Parameters["@Mobile"].Value = Mobile;
//            command.ExecuteNonQuery();
//        }
        
//        public void DeleteUserDetail(SqlConnection connection)
//        {
//            Console.WriteLine("Enter the mail id to delete : ");
//            string MailId = Console.ReadLine();
//            string deleteUser = "DELETE FROM USERDETAIL where username = @MailId";
//            SqlCommand command = new SqlCommand(deleteUser, connection);
//            command.Parameters.Add("@Mail-ID", System.Data.SqlDbType.VarChar);
//            command.Parameters["@Mail-ID"].Value = MailId;
//            command.ExecuteNonQuery();
//        }
//    }
//}
