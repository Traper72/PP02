using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP02.Data.Models
{
    public class Service
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; } = 0;
        public string MainImagePath { get; set; }
        public List<ServicePhoto> Photos { get; set; }
    }
}
