using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Member
{
    public string MemberId { get; set; } = null!;

    public string MemberFirstname { get; set; } = null!;

    public string MemberLastname { get; set; } = null!;

    public string? MemberPic { get; set; }

    public string MemberAddress { get; set; } = null!;

    public int MemberCityId { get; set; }

    public string MemberPhone { get; set; } = null!;

    public string MemberTelephone { get; set; } = null!;

    public virtual City MemberCity { get; set; } = null!;

    public virtual CoronaInfection MemberNavigation { get; set; } = null!;

    public virtual ICollection<Vaccine> Vaccines { get; set; } = new List<Vaccine>();
}
