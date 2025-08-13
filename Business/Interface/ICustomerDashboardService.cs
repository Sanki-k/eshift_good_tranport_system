using eshift_good_tranport_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_good_tranport_system.Business.Interface
{
    public interface ICustomerDashboardService
    {
        CustomerModel GetCustomerDetails(string username);
        List<JobModel> GetJobsByCustomer(string username);
    }
}
