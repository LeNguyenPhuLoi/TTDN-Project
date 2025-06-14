using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AutoConnect
    {
        private readonly string connectionString;

        public AutoConnect()
        {
            string host = Dns.GetHostName();
            string[] instanceOptions = { host, host + "\\SQLEXPRESS" };

            connectionString = instanceOptions
                .Select(instance => $"Data Source={instance};Initial Catalog=QLNH;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=2;")
                .FirstOrDefault(TestConnection);

            if (connectionString == null)
            {
                throw new Exception("Không thể kết nối đến SQL Server!");
            }
        }

        public string GetConnection()
        {
            return connectionString;
        }

        private bool TestConnection(string connStr)
        {
            try
            {
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
