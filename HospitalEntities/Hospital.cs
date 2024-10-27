using System;
using System.Collections.Generic;

namespace HospitalEntities;

public partial class Hospital
{
    public int id { get; set; }

    public string name { get; set; } = null!;

    public string address { get; set; } = null!;

    public string contactphone { get; set; } = null!;

}
