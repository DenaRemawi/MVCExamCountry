using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Data
{
    [Table("Cities")]
    public class City
    {
        public int ID { set; get; }

        [Required]
        public string city_Name { set; get; }

        public Country country { set; get; }
        [ForeignKey("country")]
        public int Counrey_ID { set; get; }


    }
}
