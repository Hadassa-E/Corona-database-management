using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CoronaInfectionDTO
    {
        public int CoronaInfectionId { get; set; }

        public string CoronaInfectionMemberId { get; set; } = null!;

        public DateOnly CoronaInfectionFromDate { get; set; }

        public DateOnly? CoronaInfectionToDate { get; set; }
        //public string? CoronaInfectionMemberFullName { get; set; }

    }
}
