using BLL.Interfaces;
using DAL.Models;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        ImemberBLL m;
        public MemberController(ImemberBLL _m)
        {
            m = _m;
        }
        //GetAll- Member
        [HttpGet("GetAllMembers")]
        public ActionResult<List<Member>> GetAllMembers()
        {
            return Ok(m.GetAllMemberBLL());
        }
        //GetById-Member
        [HttpGet("GetMemberById/{id}")]
        public ActionResult<Member> GetMemberById(string id)
        {
            return Ok(m.GetMemberBLL(id));
        }
        //Add-Member
        [HttpPost("AddMember")]
        public ActionResult<bool> AddMember([FromBody] MemberDTO member)
        {

            return Ok(m.AddMemberBLL(member));
        }
        //Update-Member
        [HttpPut("UpdateMember")]
        public ActionResult<bool> UpdateMember([FromBody] MemberDTO member)
        {
            return Ok(m.UpdateMemberBLL(member));
        }

        //Delete-Member
        [HttpDelete("DeleteMember/{id}")]
        public ActionResult<bool> DeleteMember(string id)
        {
            return Ok(m.DeleteMemberBLL(id));
        }
    }
}
