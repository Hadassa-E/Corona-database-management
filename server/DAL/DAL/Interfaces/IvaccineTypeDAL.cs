using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IvaccineTypeDAL
    {
        List<VaccineType> getAllVaccineTypes();
        VaccineType GetVaccineType(int id);
        bool DeleteVaccineType(int id);
        int AddVaccineType(VaccineType vaccineType);
    }
}
