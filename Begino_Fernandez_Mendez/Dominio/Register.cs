using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Register
    {
        public List<User> Users { get; set; }

        public void AddUser(User user)
        {
            if(user.Password.Length > 5 && user.Password.Length < 20 
                && user.Name.Length > 5 && user.Name.Length < 20)
            {
                this.Users.Add(user);
            }
        }
        public Register()
        {
            this.Users = new List<User>();
        }

        public List<Category> GetUserCategories(User user)
        {
            //int index = UserList.IndexOf(user);
            User u1 = Users.Find(x => x.Name == user.Name);
            return u1.Categories;
        }

        public void sharePass(Password p, User u1, User u2)
        {
            Category cat = new Category("SharedPasswords");
            u1.AddCategory(cat);
            u2.AddCategory(cat);
            u1.Categories.Find(x => x.Name == cat.Name).AddPassword(p);
            u2.Categories.Find(x => x.Name == cat.Name).AddPassword(p);
            p.Shared = true;

        }

        public void stopSharing(Password p, User u1, User u2)
        {
            Password pass = u2.Categories.Find(x => x.Name == "SharedPasswords").Passwords.Find(x => x.Username == p.Username && x.Site == p.Site);
            u2.Categories.Find(x => x.Name == "SharedPasswords").Passwords.Remove(pass);
        }
    }
}