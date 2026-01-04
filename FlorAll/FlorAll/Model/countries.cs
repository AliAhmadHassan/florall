using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class countrie : common
    {
        public string abbreviation { get; set; }

        public string name { get; set; }
    }

    public class Countries
    {
        public List<countrie> countries { get; set; }
    }
}
