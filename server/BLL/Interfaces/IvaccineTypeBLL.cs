using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL.Interfaces
{
    public interface IvaccineTypeBLL
    {
        List<VaccineTypeDTO> GetAllVaccineTypesBLL();
        VaccineTypeDTO GetVaccineTypeBLL(int id);
        bool DeleteVaccineTypeBLL(int id);
        int AddVaccineTypeBLL(VaccineTypeDTO vaccineType);
    }
}
