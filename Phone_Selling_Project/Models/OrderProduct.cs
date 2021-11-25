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
        [ForeignKey("ID"), Key]
        public int OrderID { get; set; }

        [ForeignKey("ID"), Key]
        public int ProductID { get; set; }
        
        [Range(0, 2000), DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal UnitPrice  { get; set; }

        [Required, StringLength(2), DisplayName("Quantity")]
        public int Quantity { get; set; } = 1;

        
    }
}
