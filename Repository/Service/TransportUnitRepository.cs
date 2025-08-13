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
    public class TransportUnitRepository : ITransportUnitRepository
    {
        private readonly string connectionString = "server=localhost;user id=root;password=1234;database=eshift;";

        public TransportUnitModel unit { get; private set; }

        public List<TransportUnitModel> GetAll()
        {
            var list = new List<TransportUnitModel>();
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "SELECT * FROM lorries";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new TransportUnitModel
                {
                    LorryId = reader.GetInt32("lorry_id"),
                    VehicleNumber = reader.GetString("vehicle_number"),
                    DriverName = reader.GetString("driver_name"),
                    AssistantName = reader.GetString("assistant_name"),
                    ContainerInfo = reader.GetString("container_info")
                });
            }

            return list;
        }

        public void Add(TransportUnitModel model)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = @"INSERT INTO lorries (vehicle_number, driver_name, assistant_name, container_info)
                             VALUES (@vehicle, @driver, @assistant, @container)";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@vehicle", model.VehicleNumber);
            cmd.Parameters.AddWithValue("@driver", model.DriverName);
            cmd.Parameters.AddWithValue("@assistant", model.AssistantName);
            cmd.Parameters.AddWithValue("@container", model.ContainerInfo);

            cmd.ExecuteNonQuery();
        }

        public void Update(TransportUnitModel model)
        {
            UpdateUnit(model);

        }

        public void Delete(int id)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = "DELETE FROM lorries WHERE lorry_id = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public List<TransportUnitModel> GetAllUnits()
        {
            List<TransportUnitModel> units = new List<TransportUnitModel>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM lorries";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        units.Add(new TransportUnitModel
                        {
                            LorryId = reader.GetInt32("lorry_id"),
                            VehicleNumber = reader.GetString("vehicle_number"),
                            DriverName = reader.GetString("driver_name"),
                            AssistantName = reader.GetString("assistant_name"),
                            ContainerInfo = reader.GetString("container_info")
                        });
                    }
                }
            }

            return units;
        }

        public void UpdateUnit(TransportUnitModel unit)
        {
            using var conn = new MySqlConnection(connectionString);
            conn.Open();

            string query = @"UPDATE lorries 
                     SET vehicle_number = @vehicle, 
                         driver_name = @driver, 
                         assistant_name = @assistant, 
                         container_info = @container 
                     WHERE lorry_id = @id";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@vehicle", unit.VehicleNumber);
            cmd.Parameters.AddWithValue("@driver", unit.DriverName);
            cmd.Parameters.AddWithValue("@assistant", unit.AssistantName);
            cmd.Parameters.AddWithValue("@container", unit.ContainerInfo);
            cmd.Parameters.AddWithValue("@id", unit.LorryId);

            cmd.ExecuteNonQuery();
        }
    }   
}
