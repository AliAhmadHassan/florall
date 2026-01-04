using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class users : common
    {
        public int users_origem_id { get; set; }

        public string name { get; set; }

        public string email { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string language_ptbr { get; set; }

        public bool active { get; set; }
    }
}
