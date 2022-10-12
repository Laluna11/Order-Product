using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zanobya.Model;
using Zanobya.Services;

namespace Zanobya.Pages
{
    public class CustomersModel : PageModel
    {

        private readonly CustomerServices service;
        [BindProperty]
        public CustomerBinding customerBinding { get; set; }
        public CustomersModel(CustomerServices service)
        {
            this.service = service;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                service.createCustomer(customerBinding);
                return RedirectToPage("Index");
            }
            return Page();
        }

    }

   
}
