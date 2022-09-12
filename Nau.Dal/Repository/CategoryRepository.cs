using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.Repository
{
    public class CategoryRepository
    {
        NauDbContext db = new NauDbContext();
        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }
        public bool Insert(Category category)
        {
            db.Categories.Add(category);
            return db.SaveChanges() > 0;
        }
        public bool Update(Category category)
        {
            Category category1 = db.Categories.Where(x => x.CategoryID == category.CategoryID).SingleOrDefault();
            category1.Name = category.Name;
            return db.SaveChanges() > 0;
        }
        public Category GetCategoryById(int id)
        {
            return db.Categories.Find(id);
        }
    }
}
