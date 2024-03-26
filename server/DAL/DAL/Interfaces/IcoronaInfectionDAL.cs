using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;


namespace DAL.Interfaces
{
    public interface IcoronaInfectionDAL
    {
        List<CoronaInfection> GetAllCoronaInfections();
        CoronaInfection GetCoronaInfection(int id);
        CoronaInfection GetCoronaInfectionToMember(string id);
        int AddCoronaInfection(CoronaInfection coronaInfection);
        bool UpdateCoronaInfection_ToDate(int id, DateOnly date);
        bool DeleteCoronaInfection(int id);
    }
}
