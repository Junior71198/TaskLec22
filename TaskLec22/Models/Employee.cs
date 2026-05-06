using System;
using System.Collections.Generic;

namespace TaskLec22.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public decimal? Salary { get; set; }

    public virtual ICollection<EmployeeLog> EmployeeLogs { get; set; } = new List<EmployeeLog>();

    public virtual ICollection<EmployeesLog> EmployeesLogs { get; set; } = new List<EmployeesLog>();
}
