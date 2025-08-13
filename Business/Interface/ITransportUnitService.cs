using eshift_good_tranport_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_good_tranport_system.Business.Interface
{
    public interface ITransportUnitService
    {
        List<TransportUnitModel> GetAll();
        void Add(TransportUnitModel model);
        void Update(TransportUnitModel model);
        void Delete(int id);
        List<TransportUnitModel> GetAllUnits();

    }
}
