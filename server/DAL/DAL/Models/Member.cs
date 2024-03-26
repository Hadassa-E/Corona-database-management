using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Member
{
    public string MemberId { get; set; } = null!;

    public string MemberFirstname { get; set; } = null!;

    public string MemberLastname { get; set; } = null!;

    public string? MemberPic { get; set; }

    public string MemberAddressStreet { get; set; } = null!;

    public int MemberAddressBuildingNumber { get; set; }

    public int MemberCityId { get; set; }

    public DateOnly MemberBirthdate { get; set; }

    public string? MemberPhone { get; set; }

    public string? MemberTelephone { get; set; }

    public bool MemberWasSick { get; set; }

    public int MemberCountOfVaccines { get; set; }

    public virtual ICollection<CoronaInfection> CoronaInfections { get; set; } = new List<CoronaInfection>();

    public virtual City MemberCity { get; set; } = null!;

    public virtual ICollection<Vaccine> Vaccines { get; set; } = new List<Vaccine>();
}
