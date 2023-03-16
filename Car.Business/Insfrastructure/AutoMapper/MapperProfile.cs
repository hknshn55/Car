using AutoMapper;
using Car.Entities.Concrete;
using Car.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Business.Insfrastructure.AutoMapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Araba, ArabaDto>().ReverseMap();
            CreateMap<Hasar, HasarDto>().ReverseMap();
        }
    }
}
