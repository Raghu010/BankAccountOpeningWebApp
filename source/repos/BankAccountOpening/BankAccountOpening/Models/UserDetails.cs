using System.ComponentModel.DataAnnotations;

namespace BankAccountOpening.Models
{
    public class UserDetails
    {
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime dateTime { get; set; }
        public int FormNo { get; set; }
        [Required]
        public Title title { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Name can not exceed 50 chars.")]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Name can not exceed 50 chars.")]
        public string LastName { get; set; }
        [Required]
        public Gender Sex { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Contact Number")]
        public string MobileNo {  get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailId { get; set; }
        [Required]
        [Display(Name = "Branch Name")]
        public string Branch { get; set; }
        [Required]
        [Display(Name = "Account Type")]
        public AccountType TypeOfAccount { get; set; }

    }
}
