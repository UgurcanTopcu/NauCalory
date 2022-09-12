using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.Repository
{
    public class FoodRepository
    {
        NauDbContext db;
        public FoodRepository()
        {
            db = new NauDbContext();
        }


        public List<Food> GetAll()
        {
            return db.Foods.OrderBy(c => c.CategoryID).ToList();
        }


        public List<Food> GetAllByUser(int userid)
        {
            return db.Foods.Where(x => (x.UserID == 1 || x.UserID == userid) && x.State == true).OrderBy(c => c.CategoryID).ToList();
        }

        public List<Food> FindFood(string word)
        {
            return db.Foods.Where(x => x.Name.Contains(word)).ToList();
        }

        public List<Food> FindFoodByUser(int userid, string word)
        {
            return db.Foods.Where(x => x.Name.Contains(word) && (x.UserID == 1 || x.UserID == userid) && x.State == true).ToList();
        }

        public Food FindFoodByID(int id)
        {
            return db.Foods.Find(id);
        }

        public bool Insert(Food food)
        {
            db.Foods.Add(food);
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool Update(Food food)
        {
            Food updatedFood = db.Foods.SingleOrDefault(x => x.FoodID == food.FoodID);
            updatedFood.Name = food.Name;
            updatedFood.CategoryID = food.CategoryID;
            updatedFood.PortionSize = food.PortionSize;
            updatedFood.Per100Cal = food.Per100Cal;
            updatedFood.Grams = food.Grams;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool DelistFood(int foodid)
        {
            Food food = db.Foods.SingleOrDefault(x => x.FoodID == foodid);
            db.Foods.Remove(food);
            int affRows = db.SaveChanges();
            return affRows > 0;
        }
    }
}
