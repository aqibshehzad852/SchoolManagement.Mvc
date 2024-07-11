using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Mvc.Models
{
    public class NewsletterSubscription
    {
     
        public int Id { get; set; }

        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
