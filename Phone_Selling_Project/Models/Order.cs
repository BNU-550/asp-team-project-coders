using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Phone_Selling_Project.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("ID")]
        public int PersonID { get; set; }

        [ForeignKey("ID")]
        public int CustomerID { get; set; }

        [Required]
        [DisplayName("Date"), DataType(DataType.Date)]
        public DateTime Date { get; set; }

        private decimal _CurrentPrice;
        [Required, DisplayName("Current Price")]
        public decimal CurrentPrice 
        {
            get { return Math.Round(_CurrentPrice, 2); }

            set { _CurrentPrice = value; }
        }

        [Required]
        [DisplayName("Order Date"), DataType(DataType.Date)]
        public DateTime DateOrdered { get; set; }

        [Required]
        [DisplayName("Date Delivered"), DataType(DataType.Date)]
        public DateTime DateDelivered { get; set; }

        
    }


}
