using TestWeb.Data.Interfaces;
using TestWeb.Data.Models;

namespace TestWeb.Data.Mocks
{
    public class MockItem : IAllItems
    {
        private readonly IItemsCategory _itemsCategory = new MockCategory();
        public IEnumerable<Item> Items 
        {
            get
            {
                return new List<Item>()
                {
                    new Item() {
                        Name = "Red lipstick", 
                        ShortDescription = "Bold red lipstick for a classic, alluring look. Long-lasting and richly pigmented.", 
                        LongDescription = "This red lipstick embodies confidence and elegance. Its rich, luxurious color is ideal for " +
                        "evening makeup and special events. The long-wear formula lasts for hours, keeping lips soft and seductive. " +
                        "Stand out in any setting with this iconic shade!", 
                        Img = "https://t3.ftcdn.net/jpg/00/58/38/12/360_F_58381204_IRRMEENV2CoIO0zR5MXdrSplEW0li7Cq.jpg", 
                        Price = 460, 
                        IsFavourite = true, 
                        Available = true, 
                        Category = _itemsCategory.AllCategories.First() 
                    },
                    new Item() {
                        Name = "Brown mascara", 
                        ShortDescription = "Brown mascara for a natural, soft look. Accentuates lashes with a hint of volume.",
                        LongDescription = "This brown mascara is the perfect choice for those who prefer a natural appearance. " +
                        "It gently lengthens lashes and adds subtle volume, ideal for daytime makeup. " +
                        "Easy to apply and gentle on the eyes, it creates a defined yet understated look.", 
                        Img = "https://sweetness.com.ua/13035-thickbox_default/farmstay-princess-curl-longlash-mascara.jpg", 
                        Price = 345, 
                        IsFavourite = true,
                        Available = true, 
                        Category = _itemsCategory.AllCategories.Last() 
                    },
                    new Item() {
                        Name = "Pink lipstick", 
                        ShortDescription = "A lightweight pink lipstick with a silky finish that gives lips a soft, fresh tint all day long.",
                        LongDescription = "This pink lipstick adds a subtle yet captivating tint to enhance natural beauty. " +
                        "Its light texture provides smooth coverage, while moisturizing ingredients keep lips soft and hydrated. " +
                        "Perfect for daily wear and romantic occasions, it adds a touch of freshness and elegance to your style.", 
                        Img = "https://t4.ftcdn.net/jpg/08/82/00/39/360_F_882003912_6d7jKwB5vMLhqKJeZeVcMJHzuLqDN1AK.jpg", 
                        Price = 600, 
                        IsFavourite = true,
                        Available = true, 
                        Category = _itemsCategory.AllCategories.First() 
                    },
                    new Item() {
                        Name = "Black mascara", 
                        ShortDescription = "Classic black mascara for intense, eye-catching lashes. Lengthens and adds volume.",
                        LongDescription = "This black mascara enhances eyes, creating a deeper, more captivating look. " +
                        "A specially designed brush applies evenly, lengthening and adding volume to each lash. " +
                        "The long-lasting formula resists smudging, keeping lashes perfect from morning to night.", 
                        Img = "https://static.independent.co.uk/2022/06/10/16/Mii%20superboost%20lash%20lover%202-in-1%20conditioning%20%20growth%20boosting%20serum%20mascara%20.jpg", 
                        Price = 566, 
                        IsFavourite = true,
                        Available = true,
                        Category = _itemsCategory.AllCategories.Last() 
                    },
                    new Item() {
                        Name = "Waterproof mascara", 
                        ShortDescription = "Waterproof mascara that stays put in all conditions. Ideal for humid weather and active lifestyles.",
                        LongDescription = "This waterproof mascara is designed for those with an active lifestyle or who need long-lasting wear. " +
                        "Its moisture-resistant formula holds up all day without flaking or smudging. " +
                        "The special brush adds both length and volume, ensuring your lashes stay beautifully defined in any situation.", 
                        Img = "https://static.independent.co.uk/2022/06/20/15/Lanco%CC%82me%20lash%20ido%CC%82le%20waterproof%20mascara%20.jpg", 
                        Price = 799, 
                        IsFavourite = true, 
                        Available = true, 
                        Category = _itemsCategory.AllCategories.Last() 
                    }
                };
            }
        }
        public IEnumerable<Item> GetFavouriteItems { get; set; }

        public Item GetItem(int carID)
        {
            throw new NotImplementedException();
        }
    }
}
