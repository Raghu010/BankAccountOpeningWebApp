using System.ComponentModel.DataAnnotations;

namespace BankAccountOpening.Models
{
    public class Languages
    {
        [Key]
        public int languageCode { get; set; }
        public string languageName { get; set; }
    }
}
