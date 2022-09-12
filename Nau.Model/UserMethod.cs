using Nau.Dal.Repository;
using Nau.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nau.Model
{
    public class UserMethod
    {
        UserRepository userRepository;
        public UserMethod()
        {
            userRepository = new UserRepository();
        }

        public User CheckLogin(string username, string password)
        {
            return userRepository.CheckLogin(username, password);
        }

        public User GetUserById(int id)
        {
            return userRepository.GetUserById(id);
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }

        public List<User> GetPasiveUsers()
        {
            return userRepository.GetPasiveUsers();
        }

        public bool UserActivate(int id)
        {
            return userRepository.UserActivate(id);
        }

        public bool UserDeActivate(int id)
        {
            return userRepository.UserDeActivate(id);
        }

        public List<User> FindUser(string word)
        {
            return userRepository.FindUser(word);
        }

        public bool Insert(User entity)
        {
            CheckRequired(entity);
            CheckEmailValid(entity.UserName);
            return userRepository.Insert(entity);
        }


        public bool Update(User entity)
        {
            CheckRequired(entity);
            return userRepository.Update(entity);
        }


        public bool ChangePassword(int userid, string password)
        {
            if (userid <= 0) throw new Exception("UserID 0'dan büyük olmalı.");
            if (string.IsNullOrWhiteSpace(password)) throw new Exception("Şifre alanı boş olamaz.");
            if (password.Length < 6) throw new Exception("Şifre en az 6 hane olmalıdır.");

            return userRepository.ChangePassword(userid, password);
        }

        void CheckRequired(User user)
        {
            if (string.IsNullOrEmpty(user.Name)) throw new Exception("İsim boş olamaz.");
            if (string.IsNullOrEmpty(user.LastName)) throw new Exception("Soyad alanı boş olamaz.");
            if (string.IsNullOrEmpty(user.UserName)) throw new Exception("Username alanı boş olamaz.");
            if (string.IsNullOrEmpty(user.Password)) throw new Exception("Şifre alanı boş olamaz.");
            if (string.IsNullOrWhiteSpace(user.Height.ToString()) || string.IsNullOrWhiteSpace(user.Weight.ToString())) throw new Exception("Boy ve kilo alanlarını giriniz.");
            if (user.Age < 18) throw new Exception("Kullanıcı 18 yaşından büyük olmalıdır.");
        }

        void CheckEmailValid(string value)
        {
            if (!value.Contains("@") || !value.Contains(".")) throw new Exception("Email adresi geçersiz.");
        }
    }
}
