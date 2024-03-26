using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Functions;
using DAL.Models;

namespace DAL.Interfaces
{
    public interface IvaccineDAL
    {
        List<Vaccine> GetAllVaccines();
        List<Vaccine> GetAllVaccinesToMember(string id);

        Vaccine GetVaccine(int id);
        bool DeleteVaccine(int id);
        int AddVaccine(Vaccine vaccine);
        bool UpdateVaccine(Vaccine vaccine);

    }
}
