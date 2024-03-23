using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
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
    public class VaccineTypeBLL:IvaccineTypeBLL
    {
        IvaccineTypeDAL vt;
        IMapper mapper;
        public VaccineTypeBLL(IvaccineTypeDAL _vt)
        {
            vt = _vt;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            mapper = config.CreateMapper();
        }

        public int AddVaccineTypeBLL(VaccineTypeDTO vaccineType)
        {
            if (ChecksBLL.IsValidEnglishText(vaccineType.VaccineTypeManufacturer))
                return vt.AddVaccineType(mapper.Map<VaccineTypeDTO, VaccineType>(vaccineType));
            return -1;
        }

        public bool DeleteVaccineTypeBLL(int id)
        {
            return vt.DeleteVaccineType(id);
        }

        public List<VaccineTypeDTO> GetAllVaccineTypesBLL()
        {
            return mapper.Map<List<VaccineType>, List<VaccineTypeDTO>>(vt.GetAllVaccineTypes());
        }

        public VaccineTypeDTO GetVaccineTypeBLL(int id)
        {
            return mapper.Map<VaccineType,VaccineTypeDTO>(vt.GetVaccineType(id));
        }
    }
}
