using InternetShop_Blazor.Data.Entity;

namespace InternetShop_Blazor.Data.CRUD_Services
{
    public class CategoryServices
    {
        private readonly ApplicationDbContext _context; // نمونه سازی از دیتابیس

        public CategoryServices(ApplicationDbContext context) //ctor - کانستراکتور
        {
            _context = context;//یک نمونه از دیتابیس را تعریف یا اینیشیال می کنیم
        }

        public Category GetCategoryByID(int CategoryId)
        {
            return _context.Ta_Category.FirstOrDefault(c => c.CategoryId == CategoryId);
        }

        public List<Category> CategoryList()
        {
            return _context.Ta_Category.ToList();
        }

        public bool CreateCategory(Category category)
        {
            _context.Ta_Category.Add(category);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateCategory(Category category)
        {
            var FindRow = _context.Ta_Category.FirstOrDefault(c => c.CategoryId == category.CategoryId);

            if (FindRow != null)
            {
                FindRow.CategoryName= category.CategoryName;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCategory(Category category)
        {
            var FindRow = _context.Ta_Category.FirstOrDefault(c => c.CategoryId == category.CategoryId);

            if (FindRow != null)
            {
                _context.Ta_Category.Remove(FindRow);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    } 
}
