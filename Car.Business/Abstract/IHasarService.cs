using Car.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Business.Abstract
{
    public interface IHasarService
    {
        Task<HasarDto> GetHasar(int id);
        Task<List<HasarDto>> GetAllHasar(int arabaId);
        Task HasarAdd(HasarDto hasarDto);
        Task HasarUpdate(HasarDto hasarDto);
        Task HasarDelete(int id);
    }
}
