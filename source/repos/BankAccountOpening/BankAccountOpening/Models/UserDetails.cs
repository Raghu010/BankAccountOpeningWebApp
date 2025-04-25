using System.ComponentModel.DataAnnotations;

namespace BankAccountOpening.Models
{
    public class UserDetails
    {
        public int FormNo { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime dateTime = DateTime.Now;
        [Required]
        public Title title { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage ="FirstName can not exceed 30 chars.")]
        public string FirstName { get; set; }
        [MaxLength(30, ErrorMessage = "MiddleName can not exceed 30 chars.")]
        public string MiddleName { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "LastName can not exceed 30 chars.")]
        public string LastName { get; set; }
        [Required]
        public Gender Sex { get; set; }
        public DateOnly DateOfBirth { get; set; }
        [Required]
        public int Age => DateTime.Now.Year - DateOfBirth.Year;
        [MaxLength(10, ErrorMessage = "Mobile Number can not exceed 10 chars.")]
        public string StdCode { get; set; }
        [MaxLength(10, ErrorMessage = "Mobile Number can not exceed 10 chars.")]
        public string Telephone { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Contact Number")]
        [MaxLength(10, ErrorMessage = "Mobile Number can not exceed 10 chars.")]
        public string MobileNo {  get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(255, ErrorMessage = "Email Address can not exceed 255 chars.")]
        [Display(Name = "Email Address")]
        public string EmailId { get; set; }
        [Required]
        [Display(Name = "State Name")]
        public string State { get;set; }
        [Required]
        [Display(Name = "City Name")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Branch Name")]
        public string BranchName { get; set; }
        [Required]
        [Display(Name = "Account Type")]
        public AccountType TypeOfAccount { get; set; }
        [Required]
        public string PrefferedLanguage { get; set; }

    }
}
