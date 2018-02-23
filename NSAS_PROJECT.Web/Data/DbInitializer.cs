using Microsoft.EntityFrameworkCore;
using NSAS_PROJECT.Core.Features.Shared;
using NSAS_PROJECT.Core.Features.Users;
using System;
using System.Linq;

namespace NSAS_PROJECT.Web.Data
{
    public class DbInitializer
    {
        public static void SeedData(DbContext datacontext)
        {
            SeedUsers(datacontext);
        }
        private static void SeedUsers(DbContext datacontext)
        {
            var users = datacontext.Set<User>();
            if (users.Any())
            {
               // AddAdminUser(datacontext);
                return;
            }
            //AddAdminUser(datacontext);
            for(int i = 0; i < 50; i++)
            {
                users.Add(new User
                {
                    Fullname = $"Abc{i}",
                    Phonenumber = 123456 + i,
                    Dateregistered = DateTime.Parse("Jan 1, 2009"),
                    Email = $"email{i}@selu.edu",
                    Gender = $"male / Female",                    
                    Address = new Address
                    {
                        Addressline1 = "abcd",
                        AddressLine2 = "def",
                        City = "Hammond",
                        State = "LA",
                        ZipCode = 70401
                    }             
                });
            }
            datacontext.SaveChanges();
        }
    }
}
