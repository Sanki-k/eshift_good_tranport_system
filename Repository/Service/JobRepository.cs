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
    public class JobRepository : IJobRepository
    {
        private readonly string connectionString = "server=localhost;user id=root;password=1234;database=eshift;";

        public List<JobModel> GetJobsByUsername(string username)
        {
            var jobs = new List<JobModel>();

            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = @"SELECT j.id, j.customer_id, j.pickup_location, j.delivery_location, j.request_date, j.status
                             FROM jobs j
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

        public void AddJob(JobModel job)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string getIdQuery = "SELECT customer_id FROM customers WHERE username = @username";
            int customerId;

            using (var cmd = new MySqlCommand(getIdQuery, conn))
            {
                cmd.Parameters.AddWithValue("@username", job.Username);
                customerId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            string insertQuery = @"INSERT INTO jobs (customer_id, pickup_location, delivery_location, request_date, status)
                                   VALUES (@cid, @pickup, @delivery, @date, 'Pending')";

            using var insertCmd = new MySqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@cid", customerId);
            insertCmd.Parameters.AddWithValue("@pickup", job.PickupLocation);
            insertCmd.Parameters.AddWithValue("@delivery", job.DeliveryLocation);
            insertCmd.Parameters.AddWithValue("@date", DateTime.Now);
            insertCmd.ExecuteNonQuery();
        }

        public void UpdateJob(JobModel job)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "UPDATE jobs SET pickup_location = @pickup, delivery_location = @delivery WHERE id = @id";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@pickup", job.PickupLocation);
            cmd.Parameters.AddWithValue("@delivery", job.DeliveryLocation);
            cmd.Parameters.AddWithValue("@id", job.Id);
            cmd.ExecuteNonQuery();
        }

        public void DeleteJob(int jobId)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "DELETE FROM jobs WHERE id = @id";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", jobId);
            cmd.ExecuteNonQuery();
        }
        public List<JobModel> GetAllJobs()
        {
            List<JobModel> jobs = new();
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = @"SELECT j.id, j.pickup_location, j.delivery_location, j.request_date, 
                         j.status, c.username, j.lorry_id, l.vehicle_number
                         FROM jobs j 
                         JOIN customers c ON j.customer_id = c.customer_id
                         LEFT JOIN lorries l ON j.lorry_id = l.lorry_id";

            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                jobs.Add(new JobModel
                {
                    Id = reader.GetInt32("id"),
                    PickupLocation = reader.GetString("pickup_location"),
                    DeliveryLocation = reader.GetString("delivery_location"),
                    RequestDate = reader.GetDateTime("request_date"),
                    Status = reader.GetString("status"),
                    Username = reader.GetString("username"),
                    LorryId = reader["lorry_id"] == DBNull.Value ? null : (int?)reader.GetInt32("lorry_id"),
                    LorryName = reader["vehicle_number"]?.ToString()
                });
            }
            return jobs;
        }

        public void UpdateJobStatus(int jobId, string status)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = "UPDATE jobs SET status = @status WHERE id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", jobId);
            cmd.ExecuteNonQuery();
        }

        public void ApproveJobWithLorry(int jobId, string status, int lorryId)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = "UPDATE jobs SET status = @status, lorry_id = @lorryId WHERE id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@lorryId", lorryId);
            cmd.Parameters.AddWithValue("@id", jobId);
            cmd.ExecuteNonQuery();
        }
        public List<JobModel> GetJobsByStatus(string status)
        {
            var jobs = new List<JobModel>();

            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = @"SELECT j.id, j.customer_id, c.username, j.pickup_location, 
                            j.delivery_location, j.request_date, j.status, 
                            j.lorry_id, l.vehicle_number
                     FROM jobs j
                     JOIN customers c ON j.customer_id = c.customer_id
                     LEFT JOIN lorries l ON j.lorry_id = l.lorry_id
                     WHERE j.status = @status";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", status);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                jobs.Add(new JobModel
                {
                    Id = reader.GetInt32("id"),
                    CustomerId = reader.GetInt32("customer_id"),
                    Username = reader.GetString("username"),
                    PickupLocation = reader.GetString("pickup_location"),
                    DeliveryLocation = reader.GetString("delivery_location"),
                    RequestDate = reader.GetDateTime("request_date"),
                    Status = reader.GetString("status"),
                    LorryId = reader["lorry_id"] == DBNull.Value ? null : (int?)reader.GetInt32("lorry_id"),
                    LorryName = reader["vehicle_number"]?.ToString()
                });
            }

            return jobs;
        }
        public void AssignLorryToJob(int jobId, int lorryId)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "UPDATE jobs SET lorry_id = @lorryId WHERE id = @jobId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@lorryId", lorryId);
            cmd.Parameters.AddWithValue("@jobId", jobId);

            cmd.ExecuteNonQuery();
        }

    }
}
