using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class panels : common
    {
        public int page_id { get; set; }

        public int paneltopic_id { get; set; }

        public string title { get; set; }

        public string description { get; set; }

        public bool privated { get; set; }

        public bool active { get; set; }


    }
}
