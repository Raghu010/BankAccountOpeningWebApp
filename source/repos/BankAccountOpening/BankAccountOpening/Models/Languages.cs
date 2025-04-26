using System.ComponentModel.DataAnnotations;

namespace BankAccountOpening.Models
{
    public class Languages
    {
        [Key]
        public int languageCode { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "City Name Can not exceed 20 chars")]
        public string languageName { get; set; }
    }
}
