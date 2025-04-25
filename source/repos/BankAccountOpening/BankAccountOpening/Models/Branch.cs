using System.ComponentModel.DataAnnotations;

namespace BankAccountOpening.Models
{
    public class Branch
    {
        [Key]
        public int BranchCode { get; set; }
        public string BranchName { get; set; }
        public int BranchCityCode { get; set; }
    }
}
