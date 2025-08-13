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
    public class TransportUnitService : ITransportUnitService
    {
        private readonly ITransportUnitRepository _repo;

        public TransportUnitService(ITransportUnitRepository repo)
        {
            _repo = repo;
        }

        public List<TransportUnitModel> GetAll() => _repo.GetAll();

        public void Add(TransportUnitModel model) => _repo.Add(model);

        public void Update(TransportUnitModel model) => _repo.Update(model);

        public void Delete(int id) => _repo.Delete(id);

        public List<TransportUnitModel> GetAllUnits()
        {
            return _repo.GetAllUnits();
        }
        public void UpdateUnit(TransportUnitModel unit)
        {
            _repo.UpdateUnit(unit);
        }

    }

}
