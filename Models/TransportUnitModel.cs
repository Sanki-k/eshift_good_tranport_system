using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_good_tranport_system.Models
{
    public class TransportUnitModel
    {
        public int LorryId { get; set; }
        public string VehicleNumber { get; set; }
        public string DriverName { get; set; }
        public string AssistantName { get; set; }
        public string ContainerInfo { get; set; }
        public int UnitId { get; internal set; }
    }
}
