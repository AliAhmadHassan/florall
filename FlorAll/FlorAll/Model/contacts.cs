using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class contacts : common
    {
        public int city_id { get; set; }

        public int page_id { get; set; }

        public int phone_ddi { get; set; }

        public int phone_ddd { get; set; }

        public long phone_number { get; set; }

    }
}
