using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class pages : common
    {
        public int user_id { get; set; }

        public string name { get; set; }

        public string photo_patch { get; set; }

        public bool privacity { get; set; }

        public bool businesses { get; set; }

    }
}
