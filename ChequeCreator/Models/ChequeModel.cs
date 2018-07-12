using System;
using System.ComponentModel.DataAnnotations;

namespace ChequeCreator.Models
{
    public class ChequeModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string PayeeName { get; set; }
        [Required]
        [RegularExpression(@"-?\d+(?:\.\d{0,2})?", ErrorMessage = "Please enter your numeric amount without any special symbols")]
        [DataType(DataType.Currency)]
        [Range(0, 10000000000000, ErrorMessage = "Amount must be a value between 0 and 10000000000000")]
        public double DollarAmount { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime IssueDate { get; set; }
    }
}
