using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL.Interfaces
{
    public interface IvaccineBLL
    {
        List<VaccineDTO> GetAllVaccinesBLL();
        VaccineDTO GetVaccineBLL(int id);
        bool DeleteVaccineBLL(int id);
        int AddVaccineBLL(VaccineDTO vaccine);
        bool UpdateVaccineBLL(VaccineDTO vaccine);

    }
}
