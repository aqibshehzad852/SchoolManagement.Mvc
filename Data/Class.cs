using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Mvc.Data;

public partial class Class
{
    public int Id { get; set; }
    [Display(Name = "Lecturer:")]
    public int? LecturerId { get; set; }
    [Display(Name = "Course:")]
    public int? CourseId { get; set; }
    [Display(Name = "Time Slot:")]
    public TimeSpan? Time { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<Enrollment> Enrollments { get; } = new List<Enrollment>();

    public virtual Lecturer? Lecturer { get; set; }
}
