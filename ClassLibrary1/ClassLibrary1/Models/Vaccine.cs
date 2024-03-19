using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Vaccine
{
    public int VaccineId { get; set; }

    public DateTime VaccineDate { get; set; }

    public int VaccineVaccineTypeId { get; set; }

    public string VaccineMemberId { get; set; } = null!;

    public virtual Member VaccineMember { get; set; } = null!;

    public virtual VaccineType VaccineVaccineType { get; set; } = null!;
}
