using AutoMapper;
using Car.Business.Abstract;
using Car.Business.ValidationRules.FluentValidation;
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
    public class ArabaManager : IArabaService
    {
        private readonly IArabaDal _arabaDal;
        private readonly IMapper _mapper;

        ArabaValidator rules = new ArabaValidator();
        public ArabaManager(IMapper mapper, IArabaDal arabaDal)
        {
            _arabaDal = arabaDal;
            _mapper = mapper;
        }

        public ValidationResult Validator(Araba araba)
        {
            return rules.Validate(araba);
        }

        public async Task ArabaAdd(ArabaDto arabaDto)
        {
            Araba araba = _mapper.Map<Araba>(arabaDto);
            var result = Validator(araba);
            if (result.IsValid)
            {
                await _arabaDal.Add(araba);
            }
        }

        public async Task ArabaDelete(int id)
        {
           Araba araba = await _arabaDal.Get(x => x.Id == id);
           await _arabaDal.Delete(araba);
        }

        public async Task ArabaUpdate(ArabaDto arabaDto)
        {
            Araba araba = _mapper.Map<Araba>(arabaDto);
            var result = Validator(araba);
            if (result.IsValid)
            {
                await _arabaDal.Update(araba);
            }
            
        }

        public async Task<List<ArabaDto>> GetAllAraba()
        {
            List<ArabaDto> arabalar = new List<ArabaDto>();
            foreach (var item in await _arabaDal.GetList())
            {
                arabalar.Add(_mapper.Map<ArabaDto>(item));
            }
            return arabalar;
        }

        public async Task<List<ArabaDto>> GetAllByMarka(string marka)
        {
            List<ArabaDto> arabalar = new List<ArabaDto>();
            foreach (var item in await _arabaDal.GetList(x=>x.Marka == marka))
            {
                arabalar.Add(_mapper.Map<ArabaDto>(item));
            }
            return arabalar;
        }

        public async Task<ArabaDto> GetAraba(int id)
        {
            Araba araba = await _arabaDal.Get(x => x.Id == id);
            return _mapper.Map<ArabaDto>(araba);
        }

        public async Task<List<ArabaDetaylariDto>> GetArabaDetails(int carId)
        {
            Araba araba = await _arabaDal.Get(x => x.Id == carId);
            List<ArabaDetaylariDto> arabaDetaylariDto = await _arabaDal.ArabaIleHasar(araba);
            return arabaDetaylariDto;
        }
    }
}
