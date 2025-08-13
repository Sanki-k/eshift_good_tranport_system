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
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _repo;

        public AdminService(IAdminRepository repo)
        {
            _repo = repo;
        }

        public List<AdminModel> GetAllAdmins() => _repo.GetAllAdmins();
        public void AddAdmin(AdminModel admin) => _repo.AddAdmin(admin);
        public void UpdateAdmin(AdminModel admin) => _repo.UpdateAdmin(admin);
        public void DeleteAdmin(int id) => _repo.DeleteAdmin(id);
    }
}  
