using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccountOpening.Models
{
    public class Cities
    {
        [Key]
        public int CityId { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "City Name Can not exceed 20 chars")]
        public string CityName { get; set; }
        public int CityStateCode { get; set; }
    }
}
