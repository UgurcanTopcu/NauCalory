using Nau.Dal.Repository;
using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Model
{
    public class ActivityTypeMethod
    {
        ActivityTypeRepository activityTypeRepository;

        public ActivityTypeMethod()
        {
            activityTypeRepository = new ActivityTypeRepository();
        }

        public List<ActivityType> GetActivities()
        {
            return activityTypeRepository.GetActivities();
        }
    }
}
