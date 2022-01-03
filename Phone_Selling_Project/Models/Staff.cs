using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phone_Selling_Project.Models
{
    public class Staff : Person
    {
        [Display(Name = "StaffRole"), StringLength(30), Required]
        public string StaffRole { get; set; }

       
    }
}
