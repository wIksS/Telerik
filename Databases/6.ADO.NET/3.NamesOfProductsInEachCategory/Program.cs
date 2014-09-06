using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.NamesOfProductsInEachCategory
{
    class Program
    {
        static void Main(string[] args)
        {
                        string connectionString =
            "Data Source=(local);Initial Catalog=Northwind;"
            + "Integrated Security=true";

            // Provide the query string with a parameter placeholder. 
            string queryString =
                "SELECT CategoryName,ProductName FROM Categories c "+
            "JOIN Products p ON p.CategoryID = c.CategoryID GROUP BY CategoryName,ProductName";


            // Specify the parameter value. 
            int paramValue = 5;

            // Create and open the connection in a using block. This 
            // ensures that all resources will be closed and disposed 
            // when the code exits. 
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@pricePoint", paramValue);

                // Open the connection in a try/catch block.  
                // Create and execute the DataReader, writing the result 
                // set to the console window. 
                Dictionary<string, List<string>> categoriesAndNames = new Dictionary<string, List<string>>();
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string key = reader[0].ToString();
                    string value = reader[1].ToString();
                    if (!categoriesAndNames.ContainsKey(key))
                    {
                        categoriesAndNames[key] = new List<string>();
                    }
                    categoriesAndNames[key].Add(value);
                }
                reader.Close();
                foreach (var item in categoriesAndNames)
                {
                    Console.Write(item.Key + " -->");
                    Console.WriteLine(String.Join(", ", item.Value));
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
