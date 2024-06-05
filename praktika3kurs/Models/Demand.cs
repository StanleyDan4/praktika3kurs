using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika3kurs.Models
{
    public class Demand
    {
        public int Id { get; set; }
        public string AddressCity { get; set; }
        public string AddressStreet { get; set; }
        public string AddressHouse { get; set; }
        public int AddressNumber { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public int AgentId { get; set; }
        public int ClientId { get; set; }
        public decimal MinArea { get; set; }
        public decimal MaxArea { get; set; }
        public int MinRooms { get; set; }
        public int MaxRooms { get; set; }
        public int MinFloor { get; set; }
        public int MaxFloor { get; set; }
        public int TypeObjectId { get; set; }
    }
}
