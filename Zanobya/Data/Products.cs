using System.Collections.Generic;

namespace Zanobya.Data
{
    public class Products
    {
        public int ProductsId { get; set; }

        public string Description { get; set; }

        public bool Available { get; set; }

        public float PurchasePrice { get; set; }

        public float SellingPrice { get; set; }

        public float Weight { get; set; }

        public string StorageLocation { get; set; }

        public ICollection<OrderLine> OrderLine { get; set; }
    }
}
