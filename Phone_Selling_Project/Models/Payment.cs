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
        protected int ID { get; set; }

        [ForeignKey("ID")]
        public int PersonID { get; set; }

        [Required, DisplayName("Date"), DataType(DataType.Date)]
        public int Date { get; set; }

        private decimal _Amount;
        [Required, DisplayName("Amount")]
        public decimal Amount { 
            get { return Math.Round(_Amount,2); }
            
            set { _Amount = value; } 
        }         

        [Required, DisplayName("Card Number"), DataType(DataType.CreditCard)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Not a valid Csc Code")]
        private int CardNumber { get; set; }

        [Required, DisplayName("Expiry Date"), DataType(DataType.Date)]
        protected int ExpiryDate { get; set; }

        [Required, DisplayName("Csc Code"), StringLength(3)]
        [RegularExpression(@"^[0-9]*$", ErrorMessage = "Not a valid Csc Code")]
        protected int CscCode { get; set; }



    }
}
