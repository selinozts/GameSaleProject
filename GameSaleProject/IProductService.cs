using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject
{
    interface IProductService : IBase<Product>
    {
        void Buy(Product product, Gamer gamer, Campaign campaign, int amount);
    }
}
