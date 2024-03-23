using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions
{
    public class VaccineDAL : IvaccineDAL
    {
        CoronaProjectContext db;
        public VaccineDAL(CoronaProjectContext _db)
        {
            db = _db;
        }
        public int AddVaccine(Vaccine vaccine)
        {
            db.Vaccines.Add(vaccine);
            db.SaveChanges();
            return db.Vaccines.FirstOrDefault(v =>v.VaccineMemberId==vaccine.VaccineMemberId&&v.VaccineDate.Equals(vaccine.VaccineDate)).VaccineId;
        }

        public bool DeleteVaccine(int id)
        {
            if (db.Vaccines.FirstOrDefault(v => v.VaccineId==id) == null)
                return false;
            db.Vaccines.Remove(db.Vaccines.FirstOrDefault(v => v.VaccineId==id));
            db.SaveChanges();
            return true;
        }

        public List<Vaccine> GetAllVaccines()
        {
            return db.Vaccines.ToList();
        }

        public Vaccine GetVaccine(int id)
        {
            return db.Vaccines.FirstOrDefault(v => v.VaccineId==id);
        }
    }
}
