using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Phone_Selling_Project.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter a product name"), StringLength(30)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Enter a product description"), StringLength(50)]
        public string Description { get; set; }

        private decimal _Price;
        [Required, DisplayName("Price")]
        public decimal Price
        {
            get { return Math.Round(_Price, 2); }

            set { _Price = value; }
        }

        [StringLength(10)]
        public int? StockLevel { get; set; }

        [Required(ErrorMessage = "Enter a storage Value"), StringLength(4)]
        public int MemoryStorage { get; set; }

        [Required(ErrorMessage = "Enter a Colour"), StringLength(15)]
        public string Colour { get; set; }

        [Required(ErrorMessage = "Enter a Screen Size"), StringLength(3)]
        public int ScreenSize { get; set; }

        // How to store image on database? base64?
        [Required]
        public string Image { get; set; }

        [Required(ErrorMessage ="Enter Ram size"), StringLength(3)]
        public int Ram { get; set; }
    }
}
//PDF gett