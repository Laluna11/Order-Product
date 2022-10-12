using System.Collections.Generic;
using Zanobya.Data;
using Zanobya.Model;

namespace Zanobya.Services
{
    public class OrderServices
    {
        private readonly ApplicationDbContext context;

        public OrderServices(ApplicationDbContext context)
        {
            this.context = context;
        }

        
        
        public void CreateOrder(OrderBinding Order)
        {
            List<OrderLine> OrderLines = new List<OrderLine>();
            foreach (int productId in Order.Products)
            {
                OrderLines.Add(new OrderLine
                {
                    Products = context.Products.Find(productId),
                    Quantity = 1,
                });
            }

            Orders order = new Orders
            {
                Customers = context.Customers.Find(Order.Customer),
                OrderDate =Order.OrderDate,
                OrderLocation = Order.OrderLocation,
                OrderLine = OrderLines
            };

            context.Orders.Add(order);
            context.SaveChanges();
        }
       

       
    }


}
