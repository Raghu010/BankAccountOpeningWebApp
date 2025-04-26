using System.ComponentModel.DataAnnotations;

namespace BankAccountOpening.Models
{
    public class UserDetails
    {
        [Key]
        public int FormNo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Required]
        public Title title { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage ="FirstName can not exceed 30 chars.")]
        public string FirstName { get; set; }
        [MaxLength(30, ErrorMessage = "MiddleName can not exceed 30 chars.")]
        public string? MiddleName { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "LastName can not exceed 30 chars.")]
        public string LastName { get; set; }
        [Required]
        public Gender Sex { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public int Age { get; set; }
        [MaxLength(10, ErrorMessage = "Mobile Number can not exceed 10 chars.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only numeric digits are allowed.")]
        public string StdCode { get; set; }
        [MaxLength(10, ErrorMessage = "Mobile Number can not exceed 10 chars.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only numeric digits are allowed.")]
        [Phone]
        public string Telephone { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Contact Number")]
        [MaxLength(10, ErrorMessage = "Mobile Number can not exceed 10 chars.")]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Enter a valid 10-digit mobile number.")]
        public string MobileNo {  get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(255, ErrorMessage = "Email Address can not exceed 255 chars.")]
        [Display(Name = "Email Address")]
        public string EmailId { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [Display(Name = "City Name")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Branch Name")]
        public string BranchName { get; set; }
        [Required(ErrorMessage = "Account type can not be empty.")]
        [Display(Name = "Account Type")]
        public AccountType TypeOfAccount { get; set; }
        [Required]
        public string PrefferedLanguage { get; set; } = string.Empty;

    }
}
