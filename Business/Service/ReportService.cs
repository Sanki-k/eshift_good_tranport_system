using eshift_good_tranport_system.Business.Interface;
using eshift_good_tranport_system.Models;
using eshift_good_tranport_system.Repository.Interface;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_good_tranport_system.Business.Service
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _repo;

        public ReportService(IReportRepository repo)
        {
            _repo = repo;
        }

        public List<JobModel> GetAllJobs() => _repo.GetAllJobs();
        public List<JobModel> GetJobsByStatus(string status) => _repo.GetJobsByStatus(status);
        public List<JobModel> GetJobsByDateRange(DateTime from, DateTime to) => _repo.GetJobsByDateRange(from, to);
    }
}
