using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Range(0, 2000), DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Required, DisplayName("Price")]
        public decimal Price { get; set; }

        [Range(0, 10)]
        public int StockLevel { get; set; }

        [Range(3, 16)]
        [Required(ErrorMessage = "Enter a Storage Value in Mbs"), StringLength(4)]
        public int MemoryStorage { get; set; }

        [Required(ErrorMessage = "Enter a Colour"), StringLength(15)]
        public string Colour { get; set; }

        [Required(ErrorMessage = "Enter a Screen Size in Inches"), StringLength(3)]
        public double ScreenSize { get; set; }

        // How to store image on database? base64?
        public string Image { get; set; }

        [Required(ErrorMessage ="Enter Ram size")]
        public int Ram { get; set; }
    }
}
