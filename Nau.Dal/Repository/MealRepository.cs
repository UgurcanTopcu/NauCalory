using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.Repository
{
    public class MealRepository
    {
        NauDbContext db;
        public MealRepository()
        {
            db = new NauDbContext();
        }

        public Meal GetMealByID(int id)
        {
            return db.Meals.Find(id);
        }

        public List<Meal> GetAll()
        {
            return db.Meals.Where(x => x.State == true).ToList();
        }

        public List<Meal> GetAll(DateTime baslangic, DateTime bitis)
        {
            return db.Meals.Where(x => x.State == true && x.RegisterationDate >= baslangic && x.RegisterationDate <= bitis).ToList();
        }


        public List<Meal> GetUserMeals(int userid)
        {
            return db.Meals.Where(x => x.State == true && x.UserID == userid).ToList();
        }


        public List<Meal> GetUserMeals(int userid, DateTime baslangic, DateTime bitis)
        {
            return db.Meals.Where(x => x.State == true && x.UserID == userid && x.RegisterationDate >= baslangic && x.RegisterationDate <= bitis).ToList();
        }

        public List<MealDetail> GetAllByCategory(int categoryId)
        {
            return db.MealDetails.Where(x => x.Meal.State == true && x.Food.CategoryID == categoryId).ToList();
        }

        public List<MealDetail> GetAllByCategory(int categoryId, DateTime baslangic, DateTime bitis)
        {
            return db.MealDetails.Where(x => x.Meal.State == true && x.Food.CategoryID == categoryId && x.Meal.RegisterationDate >= baslangic && x.Meal.RegisterationDate <= bitis).ToList();
        }

        public bool Insert(Meal entity)
        {

            db.Meals.Add(entity);
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool Update(Meal entity)
        {
            Meal updatedMeal = db.Meals.SingleOrDefault(x => x.MealID == entity.MealID);
            updatedMeal = entity;

            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool Delete(int mealId)
        {
            Meal deletedMeal = db.Meals.Find(mealId);
            deletedMeal.State = false;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

    }
}
