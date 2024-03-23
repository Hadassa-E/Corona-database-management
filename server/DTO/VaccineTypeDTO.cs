using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VaccineTypeDTO
    {
        public int VaccineTypeId { get; set; }

        public string VaccineTypeManufacturer { get; set; } = null!;

        public int VaccineTypeNumOfVaccinated { get; set; }
    }
}
