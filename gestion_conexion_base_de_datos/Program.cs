using gestion_conexion_base_de_datos.tools;
using Microsoft.Data.SqlClient;
using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
       
       

        for (int i = 0;i < 50; i++)
        {
            try
            {
                SqlConnection connection1 = DatabaseConnection.GetSqlConnection();
                DatabaseConnection.GetInfoConnection();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
           
            
            
        }

      

      

        Console.ReadKey();



    }
}