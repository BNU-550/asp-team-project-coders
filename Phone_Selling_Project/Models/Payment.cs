using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Phone_Selling_Project.Models
{
    public class Payment
    {
        [Key]
        public int ID { get; set; }

        [Required, DisplayName("Expiry Month")]
        [Range(1,12)]
        public int ExpiryMonth { get; set; }

        [Required, DisplayName("Expiry Year")]
        [Range(2021, 2030)]
        public int ExpiryYear { get; set; }

        [Required, DisplayName("Card Number"), DataType(DataType.CreditCard)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Not a valid Csc Code")]
        public int CardNumber { get; set; }

        [Required, DisplayName("Csc Code")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Not a valid Csc Code")]
        public int SecurityCode { get; set; }

    }
}
