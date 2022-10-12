using System.Collections.Generic;
using System.Linq;
using Zanobya.Data;
using Zanobya.Model;

namespace Zanobya.Services
{
    public class ProductServices
    {

        private readonly ApplicationDbContext _context;

        public ProductServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateProduct(ProductBinding product)
        {
            Products p = new Products
            {
                Description = product.Description,
                SellingPrice = product.SellingPrice,
                PurchasePrice = product.PurchasePrice,
                Weight = product.Weight,
                StorageLocation = product.StorageLocation,
                Available= product.Available,
            };

            _context.Products.Add(p);
            _context.SaveChanges();

        }

        public Products GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public List<Products> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Products Edit(ProductBinding p , int id)
        {
            Products products = _context.Products.Find(id);

            products.Description = p.Description;
            products.PurchasePrice = p.PurchasePrice;
            products.SellingPrice = p.SellingPrice;
            products.StorageLocation = p.StorageLocation;
            products.Weight = p.Weight;
            products.Available = p.Available;

            _context.SaveChanges();
            return products;

        }

        public void DeleteProduct(int id)
        {
            Products p = _context.Products.Find(id);
            if (p != null)
            {
                _context.Remove(p);
                _context.SaveChanges();
            }

        }
    }
}
