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
    public class CoronaInfectionBLL : IcoronaInfectionBLL
    {
        IcoronaInfectionDAL ci;
        IMapper mapper;
        public CoronaInfectionBLL(IcoronaInfectionDAL _ci)
        {
            ci = _ci;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            mapper = config.CreateMapper();
        }
        public int AddCoronaInfectionBLL(CoronaInfectionDTO coronaInfection)
        {
            if (coronaInfection.CoronaInfectionToDate==null||coronaInfection.CoronaInfectionFromDate<=coronaInfection.CoronaInfectionToDate)
                return ci.AddCoronaInfection(mapper.Map<CoronaInfectionDTO, CoronaInfection>(coronaInfection));
            return -1;
        }

        public bool DeleteCoronaInfectionBLL(int id)
        {
            return ci.DeleteCoronaInfection(id);
        }

        public List<CoronaInfectionDTO> GetAllCoronaInfectionsBLL()
        {
            return mapper.Map<List<CoronaInfection>, List<CoronaInfectionDTO>>(ci.GetAllCoronaInfections());
        }

        public CoronaInfectionDTO GetCoronaInfectionBLL(int id)
        {
            return mapper.Map<CoronaInfection, CoronaInfectionDTO>(ci.GetCoronaInfection(id));
        }

        public CoronaInfectionDTO GetCoronaInfectionToMemberBLL(string id)
        {
            return mapper.Map<CoronaInfection, CoronaInfectionDTO>(ci.GetCoronaInfectionToMember(id));
        }

        public bool UpdateCoronaInfection_ToDateBLL(int id, DateOnly date)
        {
            CoronaInfection cc=ci.GetCoronaInfection(id);
            if (date>=cc.CoronaInfectionFromDate)
                return ci.UpdateCoronaInfection_ToDate(id, date);
            return false;
        }
    }
}
