using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class DataAccessCategory: IDataAccess<Category>
    {
        public Category Get(Category entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Categories.FirstOrDefault(c => c.Id == entity.Id);
            }
        }

        public Category GetByName(string name, User aUser)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Categories.FirstOrDefault(c => c.Name == name && c.User.Id == aUser.Id);
            }
        }

        public Category GetById(int Id)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Categories.FirstOrDefault(c => c.Id == Id);
            }
        }

        public void Add(Category category)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Users.Attach(category.User);
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public IEnumerable<Category> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Categories.ToList();
            }
        }
        public IEnumerable<Category> GetAllByUser(User user)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Categories.Include("User").Where(x=>x.User.Id == user.Id).ToList();
            }
        }
        public void Delete(Category entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category categoryToDelete = context.Categories.FirstOrDefault(c => c.Id == entity.Id);
                context.Categories.Remove(categoryToDelete);
                context.SaveChanges();
            }
        }

        public void Modify(Category entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Category categoryToModify = context.Categories.FirstOrDefault(c => c.Id == entity.Id);
                categoryToModify.Name = entity.Name;
                context.SaveChanges();
            }
        }
    }
}
