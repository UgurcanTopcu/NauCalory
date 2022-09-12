using Nau.Dal.Repository;
using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Model
{
    public class MealMethod
    {
        MealRepository mealRepository;
        public MealMethod()
        {
            mealRepository = new MealRepository();
        }

        public Meal GetMealByID(int id)
        {
            if (id < 0) throw new Exception("Meal id hatalı");
            return mealRepository.GetMealByID(id);
        }

        public List<Meal> GetAll()
        {
            return mealRepository.GetAll();
        }
        public List<Meal> GetUserMeals(int userid)
        {
            return mealRepository.GetUserMeals(userid);
        }

        public List<Meal> GetUserMeals(int userid, DateTime baslangic, DateTime bitis)
        {
            TarihKontrol(baslangic, bitis);
            return mealRepository.GetUserMeals(userid, baslangic, bitis);
        }

        public List<MealDetail> GetAllByCategory(int categoryId)
        {
            return mealRepository.GetAllByCategory(categoryId);
        }

        public List<MealDetail> GetAllByCategory(int categoryId, DateTime baslangic, DateTime bitis)
        {
            return mealRepository.GetAllByCategory(categoryId, baslangic, bitis);
        }

        public bool Insert(Meal entity)
        {
            MealDetailControl(entity.MealDetails);
            if (entity.RegisterationDate == null) throw new Exception("Tarih alanı boş olamaz.");
            return mealRepository.Insert(entity);
        }

        public bool Update(Meal entity)
        {
            MealDetailControl(entity.MealDetails);
            return mealRepository.Update(entity);
        }

        public bool Delete(int mealId)
        {
            return mealRepository.Delete(mealId);
        }

        void TarihKontrol(DateTime baslangic, DateTime bitis)
        {
            if (bitis < baslangic) throw new Exception("Bitiş tarihi başlangıç tarihinden küçük olamaz.");
        }

        void MealDetailControl(ICollection<MealDetail> mealDetails)
        {
            if (mealDetails.Count == 0) throw new Exception("Öğün detayı girişi yapılmamış ! ");

            foreach (MealDetail item in mealDetails)
            {
                if (item.FoodID <= 0) throw new Exception("Food girişi hatalı.");
                if (item.Calory <= 0) throw new Exception("Kalori bilgisi hatalı.");
                if (item.Grams <= 0) throw new Exception("Gram bilgisi hatalı");
            }
        }
    }
}
