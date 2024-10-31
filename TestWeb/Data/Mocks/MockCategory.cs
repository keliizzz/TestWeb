using TestWeb.Data.Interfaces;
using TestWeb.Data.Models;

namespace TestWeb.Data.Mocks
{
    public class MockCategory : IItemsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>()
                {
                    new Category {CategoryName = "Lipsticks", Description = "Products for lips"},
                    new Category {CategoryName = "Mascara", Description = "Products for eyelashes"}
                };
            }
        }
    }
}
