using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class comments_feeds : common
    {
        public int page_id { get; set; }

        public int feed_id { get; set; }

        public string description { get; set; }
    }
}
