using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP02.Data.Models
{
    public class Entry
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime StartTime { get; set; }
        public int ServiceId { get; set; }
        public int ClientId { get; set; }
    }
}
