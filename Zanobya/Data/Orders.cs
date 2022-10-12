using System.Collections.Generic;

namespace Zanobya.Data
{
    public class Orders
    {
        public int OrdersId { get; set; }

        public Customers Customers { get; set; }

        public string OrderDate { get; set; }

        public string OrderLocation { get; set; }

        public ICollection<OrderLine> OrderLine { get; set; }
    }
}
