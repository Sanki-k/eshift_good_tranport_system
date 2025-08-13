using eshift_good_tranport_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_good_tranport_system.Repository.Interface
{
    public interface IAdminRepository
    {
        List<AdminModel> GetAllAdmins();
        void AddAdmin(AdminModel admin);
        void UpdateAdmin(AdminModel admin);
        void DeleteAdmin(int id);
    }
}
