using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Zanobya.Model
{
    public class OrderBinding
    {
        [Display(Name="Choose a customer: ")]
        [Required]
        public int Customer { get; set; }

        [Display(Name ="Order Date: ")]
        [DataType(DataType.Date)]
        [Required]
        public string OrderDate { get; set; }

        [Display(Name = "Order Location: ")]
        [Required]
        public string OrderLocation { get; set; }

        public List<int> Products { get; set; }
    }
}
