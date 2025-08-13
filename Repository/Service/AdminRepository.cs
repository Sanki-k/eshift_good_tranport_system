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
    public class AdminRepository : IAdminRepository
    {
        private readonly string connectionString = "server=localhost;user id=root;password=1234;database=eshift;";

        public List<AdminModel> GetAllAdmins()
        {
            var admins = new List<AdminModel>();

            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = "SELECT * FROM admins";

            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                admins.Add(new AdminModel
                {
                    Id = reader.GetInt32("id"),
                    Username = reader.GetString("username"),
                    Password = reader.GetString("password")
                });
            }

            return admins;
        }

        public void AddAdmin(AdminModel admin)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = "INSERT INTO admins (username, password) VALUES (@username, @password)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", admin.Username);
            cmd.Parameters.AddWithValue("@password", admin.Password);
            cmd.ExecuteNonQuery();
        }

        public void UpdateAdmin(AdminModel admin)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = "UPDATE admins SET username = @username, password = @password WHERE id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", admin.Username);
            cmd.Parameters.AddWithValue("@password", admin.Password);
            cmd.Parameters.AddWithValue("@id", admin.Id);
            cmd.ExecuteNonQuery();
        }

        public void DeleteAdmin(int id)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = "DELETE FROM admins WHERE id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
