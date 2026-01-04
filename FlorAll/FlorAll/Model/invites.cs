using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.Models
{
    public class invites : common
    {
        public int page_id { get; set; }

        public string email { get; set; }

        public DateTime sended { get; set; }
    }
}
