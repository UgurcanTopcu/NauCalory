using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.SeedConfiguration
{
    public class MealTypeSeed
    {
        public MealTypeSeed(NauDbContext context)
        {
            context.MealTypes.Add(new MealType() { MealTypeName = "Kahvaltı" });
            context.MealTypes.Add(new MealType() { MealTypeName = "Öğle Yemeği" });
            context.MealTypes.Add(new MealType() { MealTypeName = "Akşam Yemeği" });
            context.MealTypes.Add(new MealType() { MealTypeName = "Ara Öğün" });

            context.SaveChanges();
        }
    }
}
