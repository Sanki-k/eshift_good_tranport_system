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
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _repository;

        public LoginService(ILoginRepository repository)
        {
            _repository = repository;
        }

        public bool Login(LoginModel model)
        {
            return _repository.ValidateLogin(model);
        }

        //internal CustomerModel GetCustomerByUsername(object text)
        //{
        //    throw new NotImplementedException();
        //}
    }
}