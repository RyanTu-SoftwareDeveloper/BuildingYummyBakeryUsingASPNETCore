
namespace YummyBakery.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public readonly YummyBakeryDbContext _yummyBakeryDbContext;

        public CategoryRepository(YummyBakeryDbContext yummyBakeryDbContext)
        {
            _yummyBakeryDbContext = yummyBakeryDbContext;
        }

        public IEnumerable<Category> AllCategories =>
            _yummyBakeryDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
