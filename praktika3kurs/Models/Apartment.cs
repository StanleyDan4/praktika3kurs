using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika3kurs.Models
{

    public class Apartment
    {
        public int Id { get; set; }
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public string AddressHouse { get; set; }
        public int AddressNumber { get; set; }
        public int IdDistricts { get; set; }
        public decimal TotalArea { get; set; }
        public int Rooms { get; set; }
        public int Floor { get; set; }
        public int TypeObjectId { get; set; }

    }

}
