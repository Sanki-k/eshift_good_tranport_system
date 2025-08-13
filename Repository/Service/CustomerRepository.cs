using eshift_good_tranport_system.Models;
using eshift_good_tranport_system.Repository.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace eshift_good_tranport_system.Repository.Service
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string connectionString = "server=localhost;user id=root;password=1234;database=eshift;";

        public CustomerModel GetCustomerByUsername(string username)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "SELECT customer_id, name, email, phone, address FROM customers WHERE username = @username";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new CustomerModel
                {
                    CustomerId = reader.GetInt32("customer_id"),
                    Name = reader.GetString("name"),
                    Email = reader.GetString("email"),
                    Phone = reader.GetString("phone"),
                    Address = reader.GetString("address")
                };
            }

            return null;
        }



        public void Register(CustomerModel customer)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = @"INSERT INTO customers (name, email, phone, address, password)
                             VALUES (@Name, @Email, @Phone, @Address, @Password)";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", customer.Name);
            cmd.Parameters.AddWithValue("@Email", customer.Email);
            cmd.Parameters.AddWithValue("@Phone", customer.Phone);
            cmd.Parameters.AddWithValue("@Address", customer.Address);
            cmd.Parameters.AddWithValue("@Password", customer.Password); // Consider hashing
            cmd.ExecuteNonQuery();
        }

        public void UpdateCustomer(CustomerModel customer)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = @"UPDATE customers SET name = @name, email = @email, phone = @phone, address = @address 
                     WHERE username = @username";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", customer.Name);
            cmd.Parameters.AddWithValue("@email", customer.Email);
            cmd.Parameters.AddWithValue("@phone", customer.Phone);
            cmd.Parameters.AddWithValue("@address", customer.Address);
            cmd.Parameters.AddWithValue("@username", customer.Username);

            cmd.ExecuteNonQuery();
        }

        //public bool IsCustomerExists(string username)
        //{
        //    using var conn = new MySqlConnection(connectionString);
        //    conn.Open();

        //    string query = "SELECT COUNT(*) FROM customers WHERE username = @username";
        //    using var cmd = new MySqlCommand(query, conn);
        //    cmd.Parameters.AddWithValue("@username", username);

        //    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        //}

        public void RegisterCustomer(CustomerModel customer)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = @"INSERT INTO customers (name, email, phone, address, password)
                     VALUES (@Name, @Email, @Phone, @Address, @Password)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", customer.Name);
            cmd.Parameters.AddWithValue("@Email", customer.Email);
            cmd.Parameters.AddWithValue("@Phone", customer.Phone);
            cmd.Parameters.AddWithValue("@Address", customer.Address);
            cmd.Parameters.AddWithValue("@Password", customer.Password); // Ideally hash this
            cmd.ExecuteNonQuery();
        }

        public bool IsCustomerExists(string username)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "SELECT COUNT(*) FROM customers WHERE email = @username"; // email is used as username
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }
}
