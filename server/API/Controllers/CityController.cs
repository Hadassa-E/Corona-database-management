using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.Interfaces;
using DAL.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        IcityBLL c;
        public CityController(IcityBLL _c)
        {
            c = _c;
        }
        [HttpGet("GetAllCities")]
        public ActionResult<List<City>> GetAllCities()
        {
            return Ok(c.GetAllCitiesBLL());
        }
        [HttpGet("GetCityById/{id}")]
        public ActionResult<City> GetCityById(int id)
        {
            return Ok(c.GetCityBLL(id));
        }
    }
}
