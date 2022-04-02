using exam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Service
{
   public interface ICityService
    {
        List<City> loadcit();
    }
}
