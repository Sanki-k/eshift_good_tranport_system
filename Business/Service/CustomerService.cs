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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public CustomerModel GetCustomerByUsername(string username)
        {
            return _repo.GetCustomerByUsername(username);
        }


        public bool RegisterCustomer(CustomerModel customer, out string message)
        {
            if (_repo.IsCustomerExists(customer.Username))
            {
                message = "Username already exists. Try logging in.";
                return false;
            }

            _repo.RegisterCustomer(customer);
            message = "Customer registered successfully.";
            return true;
        }
        public void UpdateCustomer(CustomerModel customer)
        {
            _repo.UpdateCustomer(customer);
        }



    }
}
