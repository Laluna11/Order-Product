using System.ComponentModel.DataAnnotations;

namespace Zanobya.Model
{
    public class CustomerBinding
    {
        [Display(Name="Enterr Your first name: ")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Enterr Your LAst name: ")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Enterr Your Country: ")]
        [Required]
        public string Country { get; set; }

        [Display(Name = "Enterr Your city: ")]
        [Required]
        public string City { get; set; }

        [Display(Name = "Enterr Your Postal Code: ")]
        [Required]
        public int PostalCode { get; set; }

        [Display(Name = "Enterr Your Street: ")]
        [Required]
        public string Street { get; set; }
        [Display(Name = "Enterr Your House Number: ")]
        [Required]
        public int HouseNumber { get; set; }

       
    }
}
