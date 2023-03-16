using Car.Core.DataAccess;
using Car.Entities.Concrete;
using Car.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.DataAccess.Abstract
{
    public interface IArabaDal:IRepositoryBase<Araba>
    {
        Task<List<ArabaDetaylariDto>> ArabaIleHasar(Araba araba);
        Task<List<ArabaDetaylariDto>> ArabaveHasar(Araba araba);


    }
}
