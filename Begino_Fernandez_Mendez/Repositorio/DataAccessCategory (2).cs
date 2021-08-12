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

        public void Add(Category category)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                // context.User.Attach(category.User); cambiar user en Category
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
                categoryToModify = entity;
                context.SaveChanges();
            }
        }
    }
}
