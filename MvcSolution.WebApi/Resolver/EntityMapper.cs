using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSolution.WebApi.Resolver
{
    public class EntityMapper
    {
        public static IMapper _mapper;
        public static void Map()
        {
            MapperConfiguration _mapperConfig = new MapperConfiguration(
                _configuiration =>
            {
                _configuiration.CreateMap<Entity.Employee, Models.Employee>()
                .ForMember(_destination => _destination.ID, _option => _option.MapFrom(_source => _source.ID))
                .ForMember(_destination => _destination.Name, _option => _option.MapFrom(_source => _source.Name))
                .ForMember(_destination => _destination.Code, _option => _option.MapFrom(_source => _source.Code))
                .ForMember(_destination => _destination.ManagerID, _option => _option.MapFrom(_source => _source.ManagerID));
            });
            _mapper = _mapperConfig.CreateMapper();
        }
    }
}