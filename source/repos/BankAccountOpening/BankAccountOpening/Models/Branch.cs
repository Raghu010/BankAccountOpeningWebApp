using System.ComponentModel.DataAnnotations;

namespace BankAccountOpening.Models
{
    public class Branch
    {
        [Key]
        public int BranchCode { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Branch Name can not exceed 20 chars.")]
        public string BranchName { get; set; }
        public int BranchCityCode { get; set; }
    }
}
