using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class follows : common
    {
        public int follows_id { get; set; }

        public int page_id { get; set; }

        public bool accepted { get; set; }

    }
}
