using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.SeedConfiguration
{
    public class ActivityTypeSeed
    {
        public ActivityTypeSeed(NauDbContext context)
        {
            context.ActivityTypes.Add(new ActivityType() { ActivityName = "Aktivite Yok" });
            context.ActivityTypes.Add(new ActivityType() { ActivityName = "Az Aktif" });
            context.ActivityTypes.Add(new ActivityType() { ActivityName = "Aktif" });
            context.ActivityTypes.Add(new ActivityType() { ActivityName = "Çok Aktif" });
            context.SaveChanges();
        }
    }
}
