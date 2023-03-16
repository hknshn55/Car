using Car.Core.DataAccess.EntityFramework;
using Car.DataAccess.Abstract;
using Car.DataAccess.Concrete.EntityFramework.Context;
using Car.Entities.Concrete;
using Car.Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.DataAccess.Concrete.EntityFramework
{
    public class ArabaDal : RepositoryBase<Araba>, IArabaDal
    {
        public ArabaDal(CarContext context) : base(context)
        {
        }


        //Fluent Syntax
        public async Task<List<ArabaDetaylariDto>> ArabaIleHasar(Araba araba)
        {
            return await _set.Include(x => x.Hasarlar).Select(x => new ArabaDetaylariDto
            {
                Model = x.Model,
                Marka = x.Marka,
                CarId = x.Id,
                Hasars = x.Hasarlar.Select(y => new HasarDto
                {
                    Title = y.Title,
                    Description = y.Description
                }).ToList(),
            }).ToListAsync();
        }

        //Query Syntax
        public async Task< List<ArabaDetaylariDto>> ArabaveHasar(Araba araba)
        {
            return await (from x in _db.Set<Araba>()
                    join y in _db.Set<Hasar>()
                    on x.Id equals y.ArabaId
                    select new ArabaDetaylariDto
                    {
                        CarId = x.Id,
                        Marka = x.Marka,
                        Model = x.Model,
                        Hasars = x.Hasarlar.Select(hasar => new HasarDto
                        {
                            ArabaId = hasar.ArabaId,
                            Title = hasar.Title
                        }).ToList()
                    }).ToListAsync();
        }
    }
}
