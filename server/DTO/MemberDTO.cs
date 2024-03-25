using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MemberDTO
    {
        public string MemberId { get; set; } = null!;

        public string MemberFirstname { get; set; } = null!;

        public string MemberLastname { get; set; } = null!;

        public string? MemberPic { get; set; }

        public string MemberAddressStreet { get; set; } = null!;

        public int MemberAddressBuildingNumber { get; set; }

        public int MemberCityId { get; set; }

        public string? MemberPhone { get; set; }

        public string? MemberTelephone { get; set; }

        public bool MemberWasSick { get; set; }

        public int MemberCountOfVaccines { get; set; }

       // public  string MemberCityName { get; set; }

    }
}
