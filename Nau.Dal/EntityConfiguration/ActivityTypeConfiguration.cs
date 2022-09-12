using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.EntityConfiguration
{
    public class ActivityTypeConfiguration : EntityTypeConfiguration<ActivityType>
    {
        public ActivityTypeConfiguration()
        {
            Property(c => c.ActivityName).IsRequired().HasMaxLength(100);
        }
    }
}
