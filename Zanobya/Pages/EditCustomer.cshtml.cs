using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zanobya.Data;
using Zanobya.Model;
using Zanobya.Services;

namespace Zanobya.Pages
{
    public class EditCustomerModel : PageModel
    {

        private readonly CustomerServices service;
        [BindProperty]
        public CustomerBinding customerBinding { get; set; }
        public EditCustomerModel(CustomerServices service)
        {
            this.service = service;
        }
        public Customers cust { get; set; }
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }

        public void OnGet()
        {
            cust = service.getCustomerById(Id);
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Customers c = service.Edit(Id, customerBinding);
                return RedirectToPage("AllCustomers");
            }
            return Page();
        }
    }
}
