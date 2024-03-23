using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccineDTO
    {
        public int VaccineId { get; set; }

        public DateOnly VaccineDate { get; set; }

        public int VaccineVaccineTypeId { get; set; }

        public string VaccineMemberId { get; set; } = null!;
        public string? VaccineMemberFullName { get; set; }


    }
}
