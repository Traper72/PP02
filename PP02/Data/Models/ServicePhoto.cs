using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP02.Data.Models
{
    public class ServicePhoto
    {
        public int ID { get; set; } = 0;
        public int ServiceID { get; set; }
        public string PhotoPath { get; set; }
    }
}
