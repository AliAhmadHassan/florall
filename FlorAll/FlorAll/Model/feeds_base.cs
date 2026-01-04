using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class feeds_base
    {
        public int id { get; set; }

        public int feed_id { get; set; }

        public int page_id { get; set; }

        public DateTime created { get; set; }
    }
}
