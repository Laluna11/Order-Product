using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using Zanobya.Data;
using Zanobya.Services;

namespace Zanobya.Pages
{
    public class AllCustomersModel : PageModel
    {

        private readonly CustomerServices customer;
        public AllCustomersModel(CustomerServices customer)
        {
            this.customer = customer;
        }

        public List<Customers> cust { get; set; }

        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }

        public void OnGet()
        {
            cust = customer.getAllCustomers();
        }

        public IActionResult OnGetDelete()
        {
            customer.deleteCustomer(Id);
            return RedirectToPage("AllCustomers");
        }
    }
}
