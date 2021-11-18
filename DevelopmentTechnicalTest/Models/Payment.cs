using System;
using System.ComponentModel.DataAnnotations;

namespace DevelopmentTechnicalTestFrontEnd.Models
{
    public class Payment
    {
        [Required(ErrorMessage = "*To is required")]
        public string To { get; set; }

        [Required(ErrorMessage = "*From is required")]
        public string From { get; set; }

        [Required(ErrorMessage = "*Amount is required")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        [Required(AllowEmptyStrings= false, ErrorMessage = "*Date To Send is required")]
        [Display(Name = "Date To Send")]
        [DataType(DataType.DateTime)]
        public DateTime DateToSend { get; set; }
    }
}
