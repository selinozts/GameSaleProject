using System;

namespace GameSaleProject
{
    internal class GamerManager : IGamerService
    {
        private readonly IUserValidationService _validationService;

        public GamerManager(IUserValidationService validationService)
        {
            _validationService = validationService;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine(_validationService.UserValidate(gamer)
                ? $"{gamer.FirstName} {gamer.LastName} veritabanına eklendi."
                : "Oyuncu doğrulanamadı.");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName} {gamer.LastName} veritabanından silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName} {gamer.LastName} güncellendi.");

        }
    }
}