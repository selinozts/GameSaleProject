using System;

namespace GameSaleProject
{
    internal class OrderManager : IOrderService
    {
        public void Add(Order entity)
        {
            Console.WriteLine($"{entity.Id} nolu sipariş veritabanına eklendi.");
        }

        public void Delete(Order entity)
        {
            Console.WriteLine($"{entity.Id} nolu sipariş veritabanından silindi.");
        }

        public void Update(Order entity)
        {
            Console.WriteLine($"{entity.Id} nolu sipariş güncellendi.");
        }
    }
}