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

        public int PersonID { get; set; }

        [Required, DisplayName("Date")]
        [Range(1,12)]
        public int ExpiryMonth { get; set; }

        [Required, DisplayName("Date")]
        [Range(2021, 2030)]
        public int ExpiryYear { get; set; }

        [Required, DisplayName("Card Number"), DataType(DataType.CreditCard)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Not a valid Csc Code")]
        private int CardNumber { get; set; }

        [Required, DisplayName("Csc Code"), StringLength(3)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Not a valid Csc Code")]
        protected int SecurityCode { get; set; }

        public virtual Person People { get; set; }
    }
}
