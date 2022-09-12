using Nau.Dal.Repository;
using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Model
{
    public class FoodMethod
    {
        FoodRepository foodRepository;
        public FoodMethod()
        {
            foodRepository = new FoodRepository();
        }

        public List<Food> GetAll()
        {
            return foodRepository.GetAll();
        }

        public List<Food> GetAllByUser(int userid)
        {
            return foodRepository.GetAllByUser(userid);
        }

        public List<Food> FindFood(string word)
        {
            return foodRepository.FindFood(word);
        }

        public List<Food> FindFoodByUser(int userid, string word)
        {
            return foodRepository.FindFoodByUser(userid, word);
        }

        public Food FindFoodByID(int id)
        {
            if (id < 0) throw new Exception("Food id hatalı");
            return foodRepository.FindFoodByID(id);
        }

        public bool Insert(Food food)
        {
            ControlBlanks(food);
            return foodRepository.Insert(food);
        }


        public bool Update(Food food)
        {
            ControlBlanks(food);
            return foodRepository.Update(food);
        }

        public bool DelistFood(int foodid)
        {
            return foodRepository.DelistFood(foodid);
        }

        void ControlBlanks(Food food)
        {
            if (string.IsNullOrWhiteSpace(food.Name) || string.IsNullOrWhiteSpace(food.Grams.ToString()) || string.IsNullOrWhiteSpace(food.Per100Cal.ToString()) || string.IsNullOrWhiteSpace(food.CategoryID.ToString()) || string.IsNullOrWhiteSpace(food.UserID.ToString()) || string.IsNullOrWhiteSpace(food.PortionSize.ToString()))
                throw new Exception("Lütfen bütün alanları doldurunuz.");
        }
    }
}
