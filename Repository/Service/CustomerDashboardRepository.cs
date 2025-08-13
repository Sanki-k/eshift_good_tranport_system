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
    public class CustomerDashboardRepository : ICustomerDashboardRepository
    {
        private string connectionString = "server=localhost;user id=root;password=1234;database=eshift;";

        public CustomerModel GetCustomerDetails(string username)
        {
            CustomerModel customer = null;

            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM customers WHERE username = @username";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                customer = new CustomerModel
                {
                    CustomerId = reader.GetInt32("customer_id"),
                    Username = reader.GetString("username"),
                    Email = reader.GetString("email"),
                    Phone = reader.GetString("phone"),
                    Address = reader.GetString("address")
                };
            }

            return customer;
        }

        public List<JobModel> GetJobsByCustomer(string username)
        {
            var jobs = new List<JobModel>();

            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = @"SELECT j.* FROM jobs j 
                             JOIN customers c ON j.customer_id = c.customer_id
                             WHERE c.username = @username";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                jobs.Add(new JobModel
                {
                    Id = reader.GetInt32("id"),
                    CustomerId = reader.GetInt32("customer_id"),
                    PickupLocation = reader.GetString("pickup_location"),
                    DeliveryLocation = reader.GetString("delivery_location"),
                    RequestDate = reader.GetDateTime("request_date"),
                    Status = reader.GetString("status")
                });
            }

            return jobs;
        }
    }
}
