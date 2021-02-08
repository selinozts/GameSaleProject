using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject
{
    class Gamer
    {
        private string firstName;
        private string lastName;

        public int Id { get; set; }

        public string IdentityNo { get; set; }

        public string FirstName
        {
            get => firstName.ToUpper();
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName.ToUpper();
            set => lastName = value;
        }

        public DateTime BirthDate { get; set; }

    }
}
