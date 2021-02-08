using System;

namespace GameSaleProject
{
    internal class ProductManager : IProductService
    {
        private readonly IOrderService _order;

        public ProductManager(IOrderService order)
        {
            _order = order;
        }

        public void Add(Product entity)
        {
            Console.WriteLine($"{entity.Name} veritabanına eklendi.");
        }

        public void Delete(Product entity)
        {
            Console.WriteLine($"{entity.Name} veritabanından silindi.");
        }

        public void Buy(Product product, Gamer gamer, Campaign campaign, int amount)
        {
            _order.Add(new Order()
            {
                Id = 1,
                ProductId = product.Id,
                GamerId = gamer.Id
            });

            Console.WriteLine(campaign == null
                ? $"{product.Name}, {gamer.FirstName} adlı oyuncuya satıldı."
                : $"{product.Name}, {gamer.FirstName} adlı oyuncuya %{campaign.Discount} indirimle satıldı.");
        }

        public void Update(Product entity)
        {
            Console.WriteLine($"{entity.Name} güncellendi.");
        }
    }
}