using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL.Interfaces;
using DAL.Models;
using DTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaInfectionController : ControllerBase
    {
        IcoronaInfectionBLL c;
        public CoronaInfectionController(IcoronaInfectionBLL _c)
        {
            c = _c;
        }
        //GetAll- CoronaInfection
        [HttpGet("GetAllCoronaInfections")]
        public ActionResult<List<CoronaInfection>> GetAllCoronaInfections()
        {
            return Ok(c.GetAllCoronaInfectionsBLL());
        }
        //GetById-CoronaInfection
        [HttpGet("GetCoronaInfectionById/{id}")]
        public ActionResult<CoronaInfection> GetCoronaInfectionById(int id)
        {
            return Ok(c.GetCoronaInfectionBLL(id));
        }
        //GetById-to member=CoronaInfection
        [HttpGet("GetCoronaInfectionByIdToMember/{id}")]
        public ActionResult<CoronaInfection> GetCoronaInfectionByIdToMember(string id)
        {
            return Ok(c.GetCoronaInfectionToMemberBLL(id));
        }
        //Add-CoronaInfection
        [HttpPost("AddCoronaInfection")]
        public ActionResult<bool> AddCoronaInfection([FromBody] CoronaInfectionDTO coronaInfection)
        {

            return Ok(c.AddCoronaInfectionBLL(coronaInfection));
        }
        //Update-CoronaInfection
        [HttpPut("UpdateCoronaInfection/{id}/{date}")]
        public ActionResult<bool> UpdateCoronaInfection(int id,DateOnly date)
        {
            return Ok(c.UpdateCoronaInfection_ToDateBLL(id, date));
        }

        //Delete-CoronaInfection
        [HttpDelete("DeleteCoronaInfection/{id}")]
        public ActionResult<bool> DeleteCoronaInfection(int id)
        {
            return Ok(c.DeleteCoronaInfectionBLL(id));
        }
    }
}
