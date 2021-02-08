using System;

namespace GameSaleProject
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine($"{entity.Id} nolu kampanya veritabanına eklendi.");
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine($"{entity.Id} nolu kampanya veritabanından silindi.");
        }

        public void Update(Campaign entity)
        {
            Console.WriteLine($"{entity.Id} nolu kampanya güncellendi.");
        }
    }
}