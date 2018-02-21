using NSAS_PROJECT.Core.Features.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSAS_PROJECT.Core.Features.Users
{
    public class User
    {
        public int UserId { get; set; }

        public string Fullname { get; set; }

        public int Phonenumber { get; set; }

        public DateTime Dateregistered { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public Address Address { get; set; }
    }
}
