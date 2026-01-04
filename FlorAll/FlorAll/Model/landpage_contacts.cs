using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class landpage_contacts : common
    {
        public string name { get; set; }

        public string whereidfrom { get; set; }

        public string email { get; set; }

        public string message { get; set; }

        public DateTime readed { get; set; }
    }
}
