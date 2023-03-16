using Car.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Business.Abstract
{
    public interface IArabaService
    {
        Task<ArabaDto> GetAraba(int id);
        Task<List<ArabaDto>> GetAllAraba();
        Task<List<ArabaDto>> GetAllByMarka(string marka);

        Task ArabaAdd(ArabaDto arabaDto);
        Task ArabaUpdate(ArabaDto arabaDto);
        Task ArabaDelete(int id);
        Task<List<ArabaDetaylariDto>> GetArabaDetails(int carId);

    }
}
