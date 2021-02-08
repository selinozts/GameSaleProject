using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject
{
    class FakeUserValidationManager : IUserValidationService
    {
        public bool UserValidate(Gamer gamer)
        {
            return true;
        }
    }
}
