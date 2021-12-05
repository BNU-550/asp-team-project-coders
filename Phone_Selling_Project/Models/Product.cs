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

        [Required(ErrorMessage = "Enter a product description"), StringLength(256)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Range(500, 2000), DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        [Required, DisplayName("Price")]  // = 500.00m;
        public decimal Price { get; set; }

        [Range(0, 10)]
        public int StockLevel { get; set; }

        [Range(128, 512)]
        [Required(ErrorMessage = "Enter a Storage Value in Gbs"), StringLength(4)]
        public int MemoryStorage { get; set; }

        [Required(ErrorMessage = "Enter a Colour")]
        public Colours Colour { get; set; } = Colours.SpaceGrey;

        [Required(ErrorMessage = "Enter a Screen Size in Inches"), StringLength(3)]
        public double ScreenSize { get; set; }

        // How to store image on database? base64?
        // Limited scope for uploading images due to solo? 
        public string ImageFileName { get; set; }

        [Required(ErrorMessage ="Enter Ram size in Gbs"), Range(3, 16)]
        public int Ram { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
