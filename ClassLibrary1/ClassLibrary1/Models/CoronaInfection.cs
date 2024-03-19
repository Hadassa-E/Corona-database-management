using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CoronaInfection
{
    public string CoronaInfectionId { get; set; } = null!;

    public DateTime CoronaInfectionFromDate { get; set; }

    public DateTime CoronaInfectionToDate { get; set; }

    public virtual Member? Member { get; set; }
}
