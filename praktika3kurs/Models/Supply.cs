using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika3kurs.Models
{
    public class Supply
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int AgentId { get; set; }
        public int ClientId { get; set; }
        public int RealEstateId { get; set; }
    }
}
