using Car.DataAccess.Concrete.EntityFramework.Map;
using Car.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.DataAccess.Concrete.EntityFramework.Context
{
    public class CarContext:DbContext
    {
        public CarContext(DbContextOptions options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArabaMap());
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Araba> Arabalar { get; set; }
        public virtual DbSet<Hasar> Hasarlar { get; set; }

    }
}
