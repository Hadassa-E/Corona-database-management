using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces;
using DAL.Functions;
using DAL.Interfaces;
using DAL.Models;
using DTO;


namespace BLL.Functions
{
    public class VaccineBLL : IvaccineBLL
    {
        IvaccineDAL v;
        IMapper mapper;
        public VaccineBLL(IvaccineDAL _v)
        {
            v = _v;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            mapper = config.CreateMapper();
        }

        public int AddVaccineBLL(VaccineDTO vaccine)
        {
            return v.AddVaccine(mapper.Map<VaccineDTO, Vaccine>(vaccine));
        }

        public bool DeleteVaccineBLL(int id)
        {
            return v.DeleteVaccine(id); 
        }

        public List<VaccineDTO> getAllVaccinesBLL()
        {
            return mapper.Map<List<Vaccine>, List<VaccineDTO>>(v.getAllVaccines());
        }

        public VaccineDTO GetVaccineBLL(int id)
        {
            return mapper.Map<Vaccine, VaccineDTO>(v.GetVaccine(id));
        }
    }
}
