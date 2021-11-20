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

        [ForeignKey("ID")]
        public int ProductID { get; set; }


        [ForeignKey("ID")]
        public int PersonID { get; set; }

        [Required (ErrorMessage = "Please Enter Your Review"), StringLength(256), ]
        public int Text { get; set; }
    }
}
