using System;
using System.Data.SqlClient;
namespace ExecuteReader
{
    class Program
    {
        static void Main(string[] args)
        {

            //string data = "datasource = .; database= Details; Intergrated security = SSPI";
            using (SqlConnection connection = new SqlConnection("data source = .; database= Details; Integrated security = SSPI"))
            {
                // command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlCommand command = new SqlCommand("select MAX(SOLD) from  Software", connection);
                connection.Open();
                /* using data reader function:
                 using (SqlDataReader sqlDataReader = command.ExecuteReader())
                {

                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine("{0}", sqlDataReader[0]);

                    }
                }
                */

                //DataAdapter:
              

            }
        }
    }
}