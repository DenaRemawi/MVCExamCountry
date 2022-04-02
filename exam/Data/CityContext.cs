using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Data
{
    public class CityContext : DbContext
    {
        IConfiguration configuration;
        public CityContext(IConfiguration _iconfiguration)
        {
            configuration = _iconfiguration;
        }
        public DbSet <City> cities { set; get; }

        public DbSet <Country> countries { set; get; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source= localhost; initial catalog=Cities; integrated security=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }

   
}
