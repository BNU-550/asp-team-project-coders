using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Phone_Selling_Project.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }

        public int AddressID {get;set;}
        public int PaymentID { get; set; }

        [Required (ErrorMessage = "The First name address is required"), StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The Last name address is required"), StringLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [DisplayName("Date of Birth"), DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Email address"), StringLength(80), DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "The email address is required")]
        //[EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        //ToDo: Regex or datatype check when built!
       // [RegularExpression(@"^(?([0-9]{3}))?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"
       // , ErrorMessage = "Not a valid phone number")]
        public string MobileNumber { get; set; }

        public bool isStaff { get; set; } = false;

        // Calculated Fields
        public string FullName { get { return FirstName + ", " + LastName; } }

        // navigation property

        public virtual Address Address { get; set; }
        // ToDo:Picking up FK check.
        public virtual Payment Payment { get; set; }

    }
}
