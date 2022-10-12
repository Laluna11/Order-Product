using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zanobya.Data;
using Zanobya.Model;
using Zanobya.Services;

namespace Zanobya.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CustomerServices _customerService;
        private readonly ProductServices _productService;
        private readonly OrderServices _orderService;
        public IndexModel(CustomerServices _customerService, ProductServices productService, OrderServices orderService)
        {
            this._customerService = _customerService;
            this._productService = productService;
            this._orderService = orderService;
        }

        [BindProperty]
        public OrderBinding Order { get; set; }


        public IEnumerable<SelectListItem> Customers { get; set; }
        public IEnumerable<SelectListItem> Products { get; set; }

        public void OnGet()
        {
            List<SelectListItem> CustomerItems = new List<SelectListItem>();
            List<SelectListItem> ProductItems = new List<SelectListItem>();

            List<Customers> AllCustomers = this._customerService.getAllCustomers();
            foreach (Customers customer in AllCustomers)
            {
                CustomerItems.Add(new SelectListItem
                {
                    Text = customer.FirstName + customer.LastName,
                    Value = customer.CustomersId.ToString()
                   
                });
            }

            Customers = CustomerItems;


            List<Products> AllProducts = this._productService.GetAllProducts();
            foreach (Products product in AllProducts)
            {
                if (product.Available == true)
                {
                    ProductItems.Add(new SelectListItem
                    {
                        Text = product.Description,
                        Value = product.ProductsId.ToString()
                   
                    });
                }
                else
                {

                    ProductItems.Add(new SelectListItem
                    {
                        Text = product.Description,
                        Value = product.ProductsId.ToString(),
                        Disabled = true,

                    });

                }
                
            }

            Products = ProductItems;


        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _orderService.CreateOrder(Order);
                return RedirectToPage("complete");
            }

            return Page();
        }


    }
}
