using System;
using IdentityValidationServiceReference;

namespace GameSaleProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GamerManagerTest();
            ProductManagerTest();

            Console.ReadKey();
        }

        private static void ProductManagerTest()
        {
            ProductManager productManager = new ProductManager(new OrderManager());
            Product product = new Product()
            {
                Id = 1,
                Name = "Call of Duty"
            };

            productManager.Add(product);
            productManager.Update(product);
            productManager.Delete(product);

            Console.WriteLine("\n\n----------------------\n\n");

            productManager.Buy(
                product,
                new Gamer() { Id = 1, BirthDate = new DateTime(1991, 4, 5), FirstName = "Selin", IdentityNo = "12345678901", LastName = "Öztaş" },
                new Campaign() { Id = 1, Discount = 15 },
                2
                );

            Console.WriteLine("\n\n----------------------\n\n");

            productManager.Buy(
                product,
                new Gamer() { Id = 1, BirthDate = new DateTime(1991, 4, 5), FirstName = "Selin", IdentityNo = "12345678901", LastName = "Öztaş" },
                null,
                2
            );
        }

        private static void GamerManagerTest()
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager(new KPSPublicSoapClient(new KPSPublicSoapClient.EndpointConfiguration())));

            //GamerManager gamerManager = new GamerManager(new FakeUserValidationManager());

            Gamer gamer = new Gamer()
            {
                Id = 1,
                BirthDate = new DateTime(1901, 1, 1),
                IdentityNo = "1234567890",
                FirstName = "XXXXX",
                LastName = "ZZZZZ"
            };

            gamerManager.Add(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);
        }
    }
}