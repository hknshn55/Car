using Car.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.DataAccess.Concrete.EntityFramework.Map
{
    public class ArabaMap : IEntityTypeConfiguration<Araba>
    {
        public void Configure(EntityTypeBuilder<Araba> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x => x.Marka).HasMaxLength(50);
            builder.Property(x => x.Model).IsRequired();
        }
    }
}
