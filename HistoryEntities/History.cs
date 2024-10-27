using System;
using System.Collections.Generic;

namespace HistoryEntities;

public partial class History
{
    public int id { get; set; }

    public DateOnly date { get; set; }

    public int pacientid { get; set; }

    public int hospitalid { get; set; }

    public int doctorid { get; set; }

    public int roomid { get; set; }

    public string? data { get; set; }
}
