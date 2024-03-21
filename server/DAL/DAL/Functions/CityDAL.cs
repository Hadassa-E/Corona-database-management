using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;

namespace DAL.Functions
{
    public class CityDAL : IcityDAL
    {
        CoronaProjectContext db;
        public CityDAL(CoronaProjectContext _db)
        {
            db = _db;    
        }
        public List<City> GetAllCities()
        {
            return db.Cities.ToList();
        }

        public City GetCity(int id)
        {
           return db.Cities.FirstOrDefault(c => c.CityId == id);
        }
    }
}
