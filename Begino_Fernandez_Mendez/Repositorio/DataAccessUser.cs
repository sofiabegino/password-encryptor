using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class DataAccessUser: IDataAccess<User>
    {
        public User Get(User entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Users.Include("SharedPasswords").FirstOrDefault(c => c.Id == entity.Id);
            }
        }

        public User GetByName(string entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Users.Include("SharedPasswords").FirstOrDefault(c => c.Name == entity);
            }
        }

        public void Add(User user)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Users.Include("SharedPasswords").ToList();
            }
        }

        public void Delete(User entity)
        {
            using(PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                User userToDelete = context.Users.FirstOrDefault(c => c.Id == entity.Id);
                context.Users.Remove(userToDelete);
                context.SaveChanges();
            }
        }

        public void Modify(User entity)
        {
            using(PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                User userToModify = context.Users.FirstOrDefault(c => c.Id == entity.Id);
                userToModify = entity;
                context.SaveChanges();
            }
        }
    }
}
