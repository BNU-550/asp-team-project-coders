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

        [ForeignKey("ID")]
        public int PersonID { get; set; }

        [Required, StringLength(25), DisplayName("House Name")]
        public string HouseName { get; set; }

        //Not required not all houses have numbers
        [DisplayName("House Number")]
        public int? HouseNumber { get; set; }

        [Required, DisplayName("Post Code"), DataType(DataType.PostalCode)]
        public string PostCode { get; set; }

        [Required ,DisplayName("Country")]
        [RegularExpression(@"/^[A-Z]+$/i", ErrorMessage = "Please only enter numbers")]
        public string Country { get; set; }

        

        
    }
}
