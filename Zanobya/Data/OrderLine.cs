namespace Zanobya.Data
{
    public class OrderLine
    {
        public int OrderLineId { get; set; }

        public Orders Orders { get; set; }

        public Products Products { get; set; }

        public int Quantity { get; set; }
    }
}
