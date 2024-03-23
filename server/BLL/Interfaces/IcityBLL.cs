using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL.Interfaces
{
    public interface IcityBLL
    {
        List<CityDTO> GetAllCitiesBLL();
        CityDTO GetCityBLL(int id);
    }
}
