using IdentityValidationServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameSaleProject
{
    class UserValidationManager : IUserValidationService
    {
        KPSPublicSoapClient _client;

        public UserValidationManager(KPSPublicSoapClient client)
        {
            _client = client;
        }

        public bool UserValidate(Gamer gamer)
        {
            Task<TCKimlikNoDogrulaResponse> isValidated = _client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.IdentityNo), gamer.FirstName, gamer.LastName, gamer.BirthDate.Year);

            return isValidated.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
