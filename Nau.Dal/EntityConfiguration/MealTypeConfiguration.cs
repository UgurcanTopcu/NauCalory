using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.EntityConfiguration
{
    public class MealTypeConfiguration : EntityTypeConfiguration<MealType>
    {
        public MealTypeConfiguration()
        {
            Property(c => c.MealTypeName).HasMaxLength(50).IsRequired();
        }
    }
}
