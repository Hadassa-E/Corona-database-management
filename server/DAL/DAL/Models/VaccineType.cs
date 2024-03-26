using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class VaccineType
{
    public int VaccineTypeId { get; set; }

    public string VaccineTypeManufacturer { get; set; } = null!;

    public int VaccineTypeNumOfVaccinated { get; set; }

    public virtual ICollection<Vaccine> Vaccines { get; set; } = new List<Vaccine>();
}
