using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zanobya.Model;
using Zanobya.Services;

namespace Zanobya.Pages
{
    public class ProductsModel : PageModel
    {

        private readonly ProductServices product;

        public ProductsModel(ProductServices product)
        {
            this.product = product;
        }

        [BindProperty]
        public ProductBinding prod { get; set; }
        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                product.CreateProduct(prod);
                return RedirectToPage("Index");
            }
            return Page();
            

        }
    }
}
