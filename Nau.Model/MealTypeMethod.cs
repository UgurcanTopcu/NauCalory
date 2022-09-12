using Nau.Dal.Repository;
using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Model
{
    public class MealTypeMethod
    {
        MealTypeRepository mealTypeRepository;
        public MealTypeMethod()
        {
            mealTypeRepository = new MealTypeRepository();
        }

        public List<MealType> GetAllTypes()
        {
            return mealTypeRepository.GetAllTypes();
        }

        public bool Insert(MealType entity)
        {
            CheckName(entity.MealTypeName);
            return mealTypeRepository.Insert(entity);
        }

        public bool Update(MealType entity)
        {
            CheckName(entity.MealTypeName);
            return mealTypeRepository.Update(entity);
        }

        void CheckName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new Exception("Tür ismi boş olamaz.");
        }
    }
}
