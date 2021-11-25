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

        [Required]
        [DisplayName("Date"), DataType(DataType.Date)]
        public DateTime Date { get; set; }


        [Required]
        [DisplayName("Order Date"), DataType(DataType.Date)]
        public DateTime DateOrdered { get; set; }

        [DisplayName("Date Delivered"), DataType(DataType.Date)]
        public DateTime DateDelivered { get; set; }

        // Navigation Property

        public Person Customer { get; set; }
    }


}
