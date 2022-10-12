using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Zanobya.Data;
using Zanobya.Services;

namespace Zanobya.Pages
{
    public class AllProductsModel : PageModel
    {
        private readonly ProductServices product;
        public AllProductsModel(ProductServices product)
        {
            this.product = product;
        }

        public List<Products> prod { get; set; }

        public void OnGet()
        {
            prod = product.GetAllProducts();
        }
    }
}
