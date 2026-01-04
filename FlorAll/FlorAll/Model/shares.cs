using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class shares : common
    {
        public int page_id { get; set; }

        public int eventtype_id { get; set; }

        public int subcategory_id { get; set; }

        public string description { get; set; }

        public DateTime date { get; set; }

        public string address { get; set; }

        public string event_name { get; set; }

        public string activity_area { get; set; }

        public decimal spend_from { get; set; }

        public decimal spend_to { get; set; }

        public bool donate { get; set; }

        public bool lend { get; set; }

        public bool active { get; set; }

    }
}
