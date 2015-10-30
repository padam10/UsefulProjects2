using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CommandTimeOutDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string connectionString = "";
            //wait for 5 seconds delay in command
            string queryString = "Wait for delay '00:00:05'";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(queryString,connection);
                //setting command time out to 1 second
                command.CommandTimeout = 1;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Got Expected SqlException due to command timeout");
                    Console.WriteLine(e);
                }
            }
            {
                
            }

        }
    }
}
