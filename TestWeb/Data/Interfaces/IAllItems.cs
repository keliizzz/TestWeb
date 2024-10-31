using TestWeb.Data.Models;

namespace TestWeb.Data.Interfaces
{
    public interface IAllItems
    {
        IEnumerable<Item> Items { get; }
        IEnumerable<Item> GetFavouriteItems { get; set; }
        Item GetItem(int carID);
    }
}
