using TestWeb.Data.Models;

namespace TestWeb.Data.Interfaces
{
    public interface IItemsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
