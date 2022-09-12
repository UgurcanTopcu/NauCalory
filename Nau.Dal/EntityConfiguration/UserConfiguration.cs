using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.EntityConfiguration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.LastName).IsRequired().HasMaxLength(50);
            Property(c => c.UserName).IsRequired().HasMaxLength(50);
            Property(c => c.Password).IsRequired().HasMaxLength(50);
            Ignore(c => c.Age);
        }

    }
}
