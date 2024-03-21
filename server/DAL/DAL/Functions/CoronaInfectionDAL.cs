using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Interfaces;
using DAL.Models;
using System.Reflection.PortableExecutable;

namespace DAL.Functions
{
    public class CoronaInfectionDAL : IcoronaInfectionDAL
    {
        CoronaProjectContext db;
        public CoronaInfectionDAL(CoronaProjectContext _db)
        {
            db = _db;
        }
        public int AddCoronaInfection(CoronaInfection coronaInfection)
        {
            db.CoronaInfections.Add(coronaInfection);
            db.SaveChanges();
            return db.CoronaInfections.FirstOrDefault(c=>c.CoronaInfectionMemberId.Equals(coronaInfection.CoronaInfectionMemberId)).CoronaInfectionId;
        }

        public bool DeleteCoronaInfection(int id)
        {
            CoronaInfection ci = db.CoronaInfections.FirstOrDefault(c => c.CoronaInfectionId == id);
            if (ci == null)
                return false;
            db.CoronaInfections.Remove(db.CoronaInfections.FirstOrDefault(c => c.CoronaInfectionId == id));
            db.SaveChanges();
            return true;
        }

        public List<CoronaInfection> GetAllCoronaInfections()
        {
            return db.CoronaInfections.ToList();
        }

        public CoronaInfection GetCoronaInfection(int id)
        {
            return db.CoronaInfections.FirstOrDefault(c => c.CoronaInfectionId == id);
        }

        public bool UpdateCoronaInfection_ToDate(int id, DateOnly date)
        {
            CoronaInfection ci = db.CoronaInfections.FirstOrDefault(c => c.CoronaInfectionId == id);
            if (ci == null)
                return false;
            ci.CoronaInfectionToDate = date;
            db.SaveChanges();
            return true;
        }
    }
}
