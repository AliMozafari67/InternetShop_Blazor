using InternetShop_Blazor.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace InternetShop_Blazor.Data.CRUD_Services
{
    public class ProductServices
    {
        private readonly ApplicationDbContext _context;
        public ProductServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public Products productByID(int ProductId)
        {
            //Left Join
            return _context.Ta_Products.Include(p=>p.category).FirstOrDefault(c => c.ProductId == ProductId);

            //SplitQuery 
            //return _context.Ta_Products.AsSplitQuery().Include(p=>p.category).FirstOrDefault(c => c.ProductId == ProductId);
        }

        public List<Products> GetProductList()
        {
             return _context.Ta_Products.Include(p => p.category).ToList();
            
        }

        public bool CreateProduct(Products products)
        {
            _context.Ta_Products.Add(products);
            _context.SaveChanges();
            return true; 
        }

        public bool UpdateProduct(Products products)
        {
            var FindFild = _context.Ta_Products.FirstOrDefault(c => c.ProductId == products.ProductId);
            if (FindFild != null)
            {
                _context.Ta_Products.Update(FindFild);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveProduct(Products products)
        {
            var FindFild = _context.Ta_Products.FirstOrDefault(c => c.ProductId == products.ProductId);
            if (FindFild != null)
            {
                _context.Ta_Products.Remove(FindFild);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Category> CategoryList()
        {
            return _context.Ta_Category.ToList();
        }
    }
}
