
using SchoolManagement.Mvc.Data;
using SchoolManagement.Mvc.Models;

namespace SchoolManagement.Mvc.Models;

public class ClassEnrollmentViewModel
{
    public Class? Class { get; set; }

    public List<StudentEnrollmentViewModel> Students {get; set;} = new List<StudentEnrollmentViewModel>();
    
}