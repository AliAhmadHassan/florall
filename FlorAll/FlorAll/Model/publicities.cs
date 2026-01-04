using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class publicities : common
    {
        public int business_id { get; set; }

        public DateTime publicity_start { get; set; }

        public DateTime publicity_end { get; set; }

        public decimal quota { get; set; }


    }
}
