using System;
using System.Collections.Generic;

namespace HospitalEntities;

public partial class Room
{
    public int id { get; set; }

    public string name { get; set; } = null!;

    public int hospitalid { get; set; }

    public virtual Hospital hospital { get; set; } = null!;
}
