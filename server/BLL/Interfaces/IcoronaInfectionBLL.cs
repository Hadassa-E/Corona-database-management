using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL.Interfaces
{
    public interface IcoronaInfectionBLL
    {
        List<CoronaInfectionDTO> GetAllCoronaInfectionsBLL();
        CoronaInfectionDTO GetCoronaInfectionBLL(int id);
        int AddCoronaInfectionBLL(CoronaInfectionDTO coronaInfection);
        bool UpdateCoronaInfection_ToDateBLL(int id, DateOnly date);
        bool DeleteCoronaInfectionBLL(int id);
    }
}
