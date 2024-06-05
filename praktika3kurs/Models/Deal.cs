using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika3kurs.Models
{
    public class Deal
    {
        public int DemandId { get; set; }
        public int SupplyId { get; set; }

        public Demand Demand { get; set; }
        public Supply Supply { get; set; }
    }
}
