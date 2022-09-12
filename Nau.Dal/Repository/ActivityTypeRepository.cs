using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.Repository
{
    public class ActivityTypeRepository
    {
        NauDbContext db;

        public ActivityTypeRepository()
        {
            db = new NauDbContext();
        }


        public List<ActivityType> GetActivities()
        {
            return db.ActivityTypes.ToList();
        }
    }
}
