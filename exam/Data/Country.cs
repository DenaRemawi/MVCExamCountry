using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Data
{
    [Table("Countries")]
    public class Country
    {
        public int ID { set; get; }
        [Required]
        public string Country_Name { set; get;  }

        public int Code { set; get; }

        public List<City> cites { set; get; }

      
    }
}
