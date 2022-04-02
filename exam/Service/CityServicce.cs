using exam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Service
{
    public class CityServicce :ICityService
    {
        CityContext context;

        public CityServicce(CityContext _contxt)
        {
            context = _contxt;
        }

        public List<City> loadcit()
        {
            List<City> cit = context.cities.ToList();
            return (cit);
        }
    }
}
