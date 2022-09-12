using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Dal.Repository
{
    public class UserRepository
    {
        NauDbContext db;
        public UserRepository()
        {
            db = new NauDbContext();
        }

        public User GetUserById(int id)
        {
            return db.Users.SingleOrDefault(c => c.UserID == id);
        }

        public List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }

        public List<User> GetPasiveUsers()
        {
            return db.Users.Where(x => x.State == false).ToList();
        }

        public bool UserActivate(int id)
        {
            User user = db.Users.SingleOrDefault(x => x.UserID == id);
            user.State = true;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool UserDeActivate(int id)
        {
            User user = db.Users.SingleOrDefault(x => x.UserID == id);
            user.State = false;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public List<User> FindUser(string word)
        {
            return db.Users.Where(x => x.Name.Contains(word) || x.LastName.Contains(word) || x.UserName.Contains(word)).ToList();
        }

        public bool Insert(User entity)
        {
            db.Users.Add(entity);
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool Update(User entity)
        {
            User updatedUser = db.Users.SingleOrDefault(c => c.UserID == entity.UserID);
            updatedUser = entity;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool ChangePassword(int userid, string password)
        {
            User updatedUser = db.Users.SingleOrDefault(c => c.UserID == userid);
            updatedUser.Password = password;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }


        public User CheckLogin(string username, string password)
        {
            User user;
            user = db.Users.SingleOrDefault(x => x.UserName == username && x.Password == password);
            return user;
        }
    }
}
