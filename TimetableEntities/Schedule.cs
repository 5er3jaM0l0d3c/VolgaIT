using System;
using System.Collections.Generic;

namespace TimetableEntities;

public partial class Schedule
{
    public int id { get; set; }

    public int hospitalid { get; set; }

    public int doctorid { get; set; }

    public DateOnly from { get; set; }

    public DateOnly to { get; set; }

    public int roomid { get; set; }
}
