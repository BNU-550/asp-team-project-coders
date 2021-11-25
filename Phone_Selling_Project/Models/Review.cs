using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Phone_Selling_Project.Models
{
    public class Review
    {
        [Key]
        public int ID { get; set; }

        public int ProductID { get; set; }

        public int PersonID { get; set; }

        [Required (ErrorMessage = "Please Enter Your Review")]
        [StringLength(256), DataType(DataType.MultilineText]
        public string Text { get; set; }
    }
}
