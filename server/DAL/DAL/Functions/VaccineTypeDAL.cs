using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Functions
{
    public class VaccineTypeDAL : IvaccineTypeDAL
    {
        CoronaProjectContext db;
        public VaccineTypeDAL(CoronaProjectContext _db)
        {
            db = _db;
        }
        public int AddVaccineType(VaccineType vaccineType)
        {
            db.VaccineTypes.Add(vaccineType);
            db.SaveChanges();
            return db.VaccineTypes.FirstOrDefault(v => v.VaccineTypeManufacturer.Equals(vaccineType.VaccineTypeManufacturer)).VaccineTypeId;
        }

        public bool DeleteVaccineType(int id)
        {
            if (db.VaccineTypes.FirstOrDefault(v => v.VaccineTypeId == id) == null)
                return false;
            db.VaccineTypes.Remove(db.VaccineTypes.FirstOrDefault(v => v.VaccineTypeId == id));
            db.SaveChanges();
            return true;
        }

        public List<VaccineType> GetAllVaccineTypes()
        {
            return db.VaccineTypes.ToList();
        }

        public VaccineType GetVaccineType(int id)
        {
            return db.VaccineTypes.FirstOrDefault(v => v.VaccineTypeId == id);
        }
    }
}
