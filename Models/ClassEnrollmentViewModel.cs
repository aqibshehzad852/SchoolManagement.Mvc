using SchoolManagement.Mvc.Data;
using SchoolManagement.Mvc.Models;

namespace SchoolManagement.Mvc.Models;

public class ClassEnrollmentViewModel
{
    public Class? Class { get; set; }

    public List<StudentEnrollmentViewModel> Enrollments {get; set;} = new List<StudentEnrollmentViewModel>();
    
}

public class StudentEnrollmentViewModel{
    public StudentEnrollmentViewModel()
    {
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsEnrolled { get; set; }

}