
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore;


namespace SchoolManagement.Mvc.Data;

public class StudentMetaData
{

    [Display(Name = "First Name")]
    public string FirstName { get; set; } = null!;
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;
    [Display(Name = "Date of birth")]
    public DateTime? DateOfBirth { get; set; }

}

[MetadataType(typeof(StudentMetaData))]
public partial class Student{};

