using eshift_good_tranport_system.Business.Interface;
using eshift_good_tranport_system.Models;
using eshift_good_tranport_system.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_good_tranport_system.Business.Service
{
    public class CustomerDashboardService : ICustomerDashboardService
    {
        private readonly ICustomerDashboardRepository _repo;

        public CustomerDashboardService(ICustomerDashboardRepository repo)
        {
            _repo = repo;
        }

        public CustomerModel GetCustomerDetails(string username) => _repo.GetCustomerDetails(username);
        public List<JobModel> GetJobsByCustomer(string username) => _repo.GetJobsByCustomer(username);
    }
}
