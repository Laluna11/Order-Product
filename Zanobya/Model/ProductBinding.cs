using System.ComponentModel.DataAnnotations;

namespace Zanobya.Model
{
    public class ProductBinding
    {
        [Display(Name="Enter Product desc")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Availability ")]
        [Required]
        public bool Available { get; set; }
        [Display(Name = "Enter Product PurchasePrice")]
        [Required]
        public float PurchasePrice { get; set; }
        [Display(Name = "Enter Product SellingPrice")]
        [Required]
        public float SellingPrice { get; set; }
        [Display(Name = "Enter Product Weight")]
        [Required]
        public float Weight { get; set; }
        [Display(Name = "Enter Product StorageLocation")]
        [Required]
        public string StorageLocation { get; set; }

    }
}
