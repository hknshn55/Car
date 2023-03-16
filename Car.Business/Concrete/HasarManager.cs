using AutoMapper;
using Car.Business.Abstract;
using Car.DataAccess.Abstract;
using Car.Entities.Concrete;
using Car.Entities.Dtos;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Business.Concrete
{
    public class HasarManager : IHasarService
    {
        private readonly IHasarDal _hasarDal;
        private readonly IMapper _mapper;

        public HasarManager(IMapper mapper, IHasarDal hasarDal)
        {
            _hasarDal = hasarDal;
            _mapper = mapper;
        }

        public async Task<List<HasarDto>> GetAllHasar(int arabaId)
        { 
            List<HasarDto> hasarlar = new List<HasarDto>();
            foreach (var item in await _hasarDal.GetList(x=>x.ArabaId == arabaId))
            {
                hasarlar.Add(_mapper.Map<HasarDto>(item));
            }
            return hasarlar;
        }

        public async Task<HasarDto> GetHasar(int id)
        {
            Hasar hasar = await _hasarDal.Get(x=>x.Id == id);
            return _mapper.Map<HasarDto>(hasar);
        }


        public async Task HasarAdd(HasarDto hasarDto)
        {
            Hasar hasar = _mapper.Map<Hasar>(hasarDto);
            await _hasarDal.Add(hasar);
        }

        public async Task HasarDelete(int id)
        {
            Hasar hasar = await _hasarDal.Get(x => x.Id == id);
            await _hasarDal.Delete(hasar);
        }

        public async Task HasarUpdate(HasarDto hasarDto)
        {
            Hasar hasar = _mapper.Map<Hasar>(hasarDto);
            await _hasarDal.Update(hasar);
         
        }
    }
}
