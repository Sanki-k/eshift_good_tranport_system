using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshift_good_tranport_system.Models
{
    public class JobModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; }
        public string Username { get; set; }
        public int? LorryId { get; set; }
        public string LorryName { get; set; }

    }
}
