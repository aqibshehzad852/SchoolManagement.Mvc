using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Mvc.Data;

public partial class Lecturer
{
    public int Id { get; set; }
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = null!;
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;

    public virtual ICollection<Class> Classes { get; } = new List<Class>();
}
