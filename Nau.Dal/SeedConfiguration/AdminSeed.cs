using Nau.Data.Entities;
using Nau.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.SeedConfiguration
{
    public class AdminSeed
    {
        public AdminSeed(NauDbContext context)
        {
            User admin = new User()
            {
                Name = "admin",
                LastName = "admin",
                UserName = "admin",
                Password = "admin",
                UserType = UserType.Admin,
                ActivityTypeID = 1,
                BirthDate = DateTime.Now,
                Height = 180,
                Weight = 98,
                KiloGoal = 75,
                Gender = Gender.Erkek,
                State = true
            };

            context.Users.Add(admin);
            context.SaveChanges();
        }
    }
}
