using exam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Service
{
    public class CountryService:ICountryService
    {
        CityContext context;

        public CountryService(CityContext _contxt)
        {
            context = _contxt;
        }

        public List<Country> loadcoun()
        {
            List<Country> countri = context.countries.ToList();
            return (countri);
        }

        public void insert(Country country)
        {
           context.countries.Add(country);
            context.SaveChanges();

        }

        

        
    }
}
