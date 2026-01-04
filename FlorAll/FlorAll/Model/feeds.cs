using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class feeds : common
    {
        public int page_id { get; set; }

        public string title { get; set; }

        public string file_patch { get; set; }

        public bool active { get; set; }
    }
}
