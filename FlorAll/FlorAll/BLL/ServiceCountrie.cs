using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlorAll.BLL
{
    public class ServiceCountrie : ClientHTTP.DataServices
    {
        public async Task<Models.Countries> GetAll()
        {
            return await GetAll<Models.Countries>("http://www.flor-all.com/florall/api/countries/getAll.json", "aaa");
        }
    }
}
