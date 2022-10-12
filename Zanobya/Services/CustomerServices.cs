using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Zanobya.Data;
using Zanobya.Model;

namespace Zanobya.Services
{
    public class CustomerServices
    {
        private readonly ApplicationDbContext _context;

        public CustomerServices(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void createCustomer(CustomerBinding customerBinding)
        {
            Customers customer = new Customers
            {
                FirstName = customerBinding.FirstName,
                LastName = customerBinding.LastName,
                City = customerBinding.City,
                Country = customerBinding.Country,
                PostalCode = customerBinding.PostalCode,
                Street = customerBinding.Street,
                HouseNumber = customerBinding.HouseNumber,

            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public Customers getCustomerById(int id)
        {
            return _context.Customers.Find(id);

        }

        public List<Customers> getAllCustomers()
        {
            return _context.Customers.ToList();
        }
        //public List<SelectListItem> getAllOrders(List<SelectListItem> list, int id)
        //{
        //    List<Orders> o = _context.Orders.Where(s => s.Customers.CustomerID == id).Select(n => n).ToList();
        //    foreach (var order in o)
        //    {
        //        SelectListItem l = new SelectListItem()
        //        {
        //            Value = order.OrderID.ToString(),
        //            Text = "Order Name",
        //            Selected = true,
        //            Disabled = true
        //        };
        //    }
        //    return o;
        //}

        public Customers Edit(int id, CustomerBinding customer)
        {

            Customers ct = _context.Customers.Where(n => n.CustomersId == id).Single();

            ct.FirstName = customer.FirstName;
            ct.LastName = customer.LastName;
            ct.City = customer.City;
            ct.Country = customer.Country;
            ct.PostalCode = customer.PostalCode;
            ct.Street = customer.Street;
            ct.HouseNumber = customer.HouseNumber;

            _context.SaveChanges();
            return ct;

        }

        public void deleteCustomer(int id)
        {
            Customers customer = _context.Customers.Find(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }

        }
    }
}
