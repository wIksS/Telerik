using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AddANewProduct
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
                "INSERT INTO Products (ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued)" +
                "VALUES (@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder,@ReorderLevel, @Discontinued)";

            // Specify the parameter value. 
            string productName = "Your personal PC ADO.NET";
            int supplierID = 1;
            int categoryID = 1;
            string quantityPerUnit = "24 - 250 g pkgs.";
            decimal unitPrice = 13.250m;
            int unitsInStock = 36;
            int unitsOnOrder = 0;
            int reorderLevel = 20;
            bool discontinued = true;

            // Create and open the connection in a using block. This 
            // ensures that all resources will be closed and disposed 
            // when the code exits. 
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@supplierID", supplierID);
                command.Parameters.AddWithValue("@categoryID", categoryID);
                command.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
                command.Parameters.AddWithValue("@unitPrice", unitPrice);
                command.Parameters.AddWithValue("@unitsInStock", unitsInStock);
                command.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
                command.Parameters.AddWithValue("@reorderLevel", reorderLevel);
                command.Parameters.AddWithValue("@discontinued", discontinued);               

                // Open the connection in a try/catch block.  
                // Create and execute the DataReader, writing the result 
                // set to the console window. 
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}",
                            reader[0], reader[1], reader[2]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
