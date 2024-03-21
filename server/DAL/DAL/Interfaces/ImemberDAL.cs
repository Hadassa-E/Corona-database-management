using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Interfaces
{
    public interface ImemberDAL
    {
        List<Member> getAllMember();
        Member GetMember(string id);
        bool DeleteMember(string id);
        string AddMember(Member member);
        bool UpdateMember(Member member);
    }
}
