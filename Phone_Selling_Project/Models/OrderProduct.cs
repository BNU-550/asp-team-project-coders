using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Phone_Selling_Project.Models
{
    public class OrderProduct
    {
        [ForeignKey("ID")]
        public int OrderID { get; set; }

        [ForeignKey("ID")]
        public int ProductID { get; set; }


        private decimal _SalePrice;
        public decimal SalePrice 
        {
            get { return Math.Round(_SalePrice, 2); }

            set { _SalePrice = value; }
        }

        [Required, StringLength(2), DisplayName("Quantity")]
        public int Quantity { get; set; }

        
    }
}
