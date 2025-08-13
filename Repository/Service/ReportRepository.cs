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
    public class ReportRepository : IReportRepository
    {
        private readonly string connectionString = "server=localhost;user id=root;password=1234;database=eshift;";

        public List<JobModel> GetAllJobs()
        {
            return GetJobs("SELECT j.id, c.username, j.pickup_location, j.delivery_location, j.request_date, j.status FROM jobs j JOIN customers c ON j.customer_id = c.customer_id");
        }

        public List<JobModel> GetJobsByStatus(string status)
        {
            return GetJobs("SELECT j.id, c.username, j.pickup_location, j.delivery_location, j.request_date, j.status FROM jobs j JOIN customers c ON j.customer_id = c.customer_id WHERE j.status = @status",
                ("@status", status));
        }

        public List<JobModel> GetJobsByDateRange(DateTime from, DateTime to)
        {
            return GetJobs("SELECT j.id, c.username, j.pickup_location, j.delivery_location, j.request_date, j.status FROM jobs j JOIN customers c ON j.customer_id = c.customer_id WHERE j.request_date BETWEEN @from AND @to",
                ("@from", from), ("@to", to));
        }

        private List<JobModel> GetJobs(string query, params (string, object)[] parameters)
        {
            var jobs = new List<JobModel>();
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            using var cmd = new MySqlCommand(query, conn);
            foreach (var (param, value) in parameters)
                cmd.Parameters.AddWithValue(param, value);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                jobs.Add(new JobModel
                {
                    Id = reader.GetInt32("id"),
                    Username = reader.GetString("username"),
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
