using System;
using System.Collections.Generic;

namespace ThbLesson10EFDbFirst.Models;

public partial class ThbMember
{
    public long Id { get; set; }

    public string? ThbUserName { get; set; }

    public string? ThbPassword { get; set; }

    public string? ThbFullName { get; set; }

    public string? ThbEmail { get; set; }

    public string? ThbPhone { get; set; }

    public bool? ThbStatus { get; set; }
}
