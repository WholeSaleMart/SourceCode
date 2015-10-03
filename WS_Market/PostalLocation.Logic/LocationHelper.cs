using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostalLocation.Logic
{
    public class LocationHelper
    {
        public IEnumerable<City> GetCityList()
        {
            PostalLocationEntities db = new PostalLocationEntities();
            return db.Cities;
        }
    }
}
