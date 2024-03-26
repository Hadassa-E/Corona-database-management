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
    public class MemberBLL:ImemberBLL
    {
        ImemberDAL m;
        IMapper mapper;
        public MemberBLL(ImemberDAL _m)
        {
            m = _m;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DTO.Mapper>();
            });
            mapper = config.CreateMapper();
        }

        public string AddMemberBLL(MemberDTO member)
        {
            if (ChecksBLL.IsValidHebrewText(member.MemberFirstname) &&
                 ChecksBLL.IsValidHebrewText(member.MemberLastname) &&
                 ChecksBLL.IsValidHebrewText(member.MemberAddressStreet) &&
                 ChecksBLL.IsValidPhone(member.MemberPhone) &&
                 ChecksBLL.IsValidTelephone(member.MemberTelephone)&&
                 member.MemberBirthdate<= DateOnly.FromDateTime(DateTime.Today))
                return m.AddMember(mapper.Map<MemberDTO, Member>(member));
            return "0";
        }

        public bool DeleteMemberBLL(string id)
        {
            return m.DeleteMember(id);
        }

        public List<MemberDTO> GetAllMemberBLL()
        {
            return mapper.Map<List<Member>, List<MemberDTO>>(m.GetAllMember());
        }

        public MemberDTO GetMemberBLL(string id)
        {
            return mapper.Map<Member, MemberDTO>(m.GetMember(id));
        }

        public bool UpdateMemberBLL(MemberDTO member)
        {
            if (ChecksBLL.IsValidHebrewText(member.MemberFirstname) &&
                       ChecksBLL.IsValidHebrewText(member.MemberLastname) &&
                       ChecksBLL.IsValidHebrewText(member.MemberAddressStreet) &&
                       ChecksBLL.IsValidPhone(member.MemberPhone) &&
                       ChecksBLL.IsValidTelephone(member.MemberTelephone)&&
                       member.MemberBirthdate <= DateOnly.FromDateTime(DateTime.Today))
                return m.UpdateMember(mapper.Map<MemberDTO, Member>(member));
            return false;
        }
    }
}
