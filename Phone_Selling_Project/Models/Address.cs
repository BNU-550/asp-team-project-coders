using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Phone_Selling_Project.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(25), DisplayName("House Name or Number")]
        public string HouseNameNumber { get; set; }

        [Required, DisplayName("Post Code"), DataType(DataType.PostalCode)]
        public string PostCode { get; set; }

        

        
    }
}
