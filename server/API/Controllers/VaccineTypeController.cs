using BLL.Interfaces;
using DAL.Models;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineTypeController : ControllerBase
    {
        IvaccineTypeBLL v;
        public VaccineTypeController(IvaccineTypeBLL _v)
        {
            v = _v;
        }
        //GetAll- VaccineType
        [HttpGet("GetAllVaccineTypes")]
        public ActionResult<List<VaccineType>> GetAllVaccineTypes()
        {
            return Ok(v.GetAllVaccineTypesBLL());
        }
        //GetById-VaccineType
        [HttpGet("GetVaccineTypeById/{id}")]
        public ActionResult<VaccineType> GetVaccineTypeById(int id)
        {
            return Ok(v.GetVaccineTypeBLL(id));
        }
        //Add-VaccineType
        [HttpPost("AddVaccineType")]
        public ActionResult<bool> AddVaccineType([FromBody] VaccineTypeDTO vaccineType)
        {

            return Ok(v.AddVaccineTypeBLL(vaccineType));
        }

        //Delete-VaccineType
        [HttpDelete("DeleteVaccineType/{id}")]
        public ActionResult<bool> DeleteVaccineType(int id)
        {
            return Ok(v.DeleteVaccineTypeBLL(id));
        }
    }
}
