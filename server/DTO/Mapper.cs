using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Models;

namespace DTO
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<City, CityDTO>();
            CreateMap<CityDTO, City>();
            CreateMap<CoronaInfection, CoronaInfectionDTO>().ForMember(dest => dest.CoronaInfectionMemberFullName, opt => opt.MapFrom(src => src.CoronaInfectionMember.MemberFirstname + " " + src.CoronaInfectionMember.MemberLastname));
            CreateMap<CoronaInfectionDTO, CoronaInfection>();
            CreateMap<Member, MemberDTO>().ForMember(dest => dest.MemberCityName, opt => opt.MapFrom(src => src.MemberCity.CityName ));
            CreateMap<MemberDTO, Member>();
            CreateMap<Vaccine, VaccineDTO>().ForMember(dest => dest.VaccineMemberFullName, opt => opt.MapFrom(src => src.VaccineMember.MemberFirstname + " " + src.VaccineMember.MemberLastname));
            CreateMap<VaccineDTO, Vaccine>();
            CreateMap<VaccineType, VaccineTypeDTO>();
            CreateMap<VaccineTypeDTO, VaccineType>();
        }
    }
}
