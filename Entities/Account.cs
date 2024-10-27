using System;
using System.Collections.Generic;

namespace Entities;

public partial class Account
{
    public int id { get; set; }

    public string username { get; set; } = null!;

    public string password { get; set; } = null!;

    public int roleid { get; set; }

    public string? firstname { get; set; }

    public string? lastname { get; set; }

    public virtual Role role { get; set; } = null!;
}
