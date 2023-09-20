using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_conexion_base_de_datos.tools
{
    public class DatabaseConnection
    {

        private static SqlConnection _SqlConnection = null;
        private static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        private static object _object = new object();

        public static SqlConnection GetSqlConnection()
        {
            IniConnection();

            _SqlConnection = new SqlConnection(builder.ConnectionString);
            _SqlConnection.Open();

            return _SqlConnection;
        }


        private static void IniConnection()
        {
            builder.DataSource = "DESKTOP-PFQ1Q9C";
            builder.InitialCatalog = "test_pool_conection";
            builder.UserID = "sa";
            builder.Password = "12345";
            builder.TrustServerCertificate = true;

            // Configuración de min y max pool size
            builder.MinPoolSize = 5; // Cantidad mínima de conexiones en el pool
            builder.MaxPoolSize = 40; // Cantidad máxima de conexiones en el pool    
            builder.ConnectTimeout = 60;
        }

        public static void GetInfoConnection() {

            Console.WriteLine($"{builder.Count}");
        
        }

    }
}
