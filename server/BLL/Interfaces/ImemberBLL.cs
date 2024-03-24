using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL.Interfaces
{
    public interface ImemberBLL
    {
        List<MemberDTO> GetAllMemberBLL();
        MemberDTO GetMemberBLL(string id);
        bool DeleteMemberBLL(string id);
        string AddMemberBLL(MemberDTO member);
        bool UpdateMemberBLL(MemberDTO member);
    }
}
