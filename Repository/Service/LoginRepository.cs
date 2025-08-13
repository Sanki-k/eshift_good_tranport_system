using eshift_good_tranport_system.Models;
using eshift_good_tranport_system.Repository.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_good_tranport_system.Repository.Service
{
    public class LoginRepository : ILoginRepository
    {
        private readonly string connectionString = "server=localhost;user id=root;password=1234;database=eshift;";

        public bool ValidateLogin(LoginModel model)
        {
            string table = model.Role.ToLower() == "admin" ? "admins" : "customers";
            string query = $"SELECT COUNT(*) FROM {table} WHERE username = @username AND password = @password";

            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", model.Username);
            cmd.Parameters.AddWithValue("@password", model.Password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }
}
