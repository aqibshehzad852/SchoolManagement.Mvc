using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Mvc.Data;

public partial class Student
{
    public int Id { get; set; }

    [Display(Name = "First Name")]
    public string FirstName { get; set; } = null!;
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;
    [Display(Name = "Date of birth")]
    public DateTime? DateOfBirth { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; } = new List<Enrollment>();
}
