using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DTO;

namespace BLL.Functions
{
    public class CityBLL : IcityBLL
    {
        IcityDAL c1;
        IMapper mapper;
        public CityBLL(IcityDAL _c1)
        {
            c1 = _c1;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            mapper = config.CreateMapper();
        }
        public List<CityDTO> GetAllCitiesBLL()
        {
            return mapper.Map<List<City>, List<CityDTO>>(c1.GetAllCities());
        }

        public CityDTO GetCityBLL(int id)
        {
            return mapper.Map<City, CityDTO>(c1.GetCity(id));
        }
    }
}
