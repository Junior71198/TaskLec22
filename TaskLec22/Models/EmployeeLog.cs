using System;
using System.Collections.Generic;

namespace TaskLec22.Models;

public partial class EmployeeLog
{
    public int Id { get; set; }

    public int? EmployeeId { get; set; }

    public string? Action { get; set; }

    public DateTime? ActionDate { get; set; }

    public virtual Employee? Employee { get; set; }
}
