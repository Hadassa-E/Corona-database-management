using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CoronaInfection
{
    public int CoronaInfectionId { get; set; }

    public string CoronaInfectionMemberId { get; set; } = null!;

    public DateOnly CoronaInfectionFromDate { get; set; }

    public DateOnly? CoronaInfectionToDate { get; set; }

    public virtual Member CoronaInfectionMember { get; set; } = null!;
}
