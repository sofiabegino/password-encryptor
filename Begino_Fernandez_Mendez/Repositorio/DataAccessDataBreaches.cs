using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class DataAccessDataBreaches: IDataAccess<DataBreachesResult>
    {
        public DataBreachesResult Get(DataBreachesResult entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.DataBreachesResults.Include(x => x.PasswordsCompromised.Select(c => c.CategoryId)).Include(x => x.CardsCompromised.Select(c => c.CategoryId)).FirstOrDefault(c => c.Id == entity.Id);
            }
        }
        public void Add(DataBreachesResult entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Users.Attach(entity.User);
                entity.PasswordsCompromised.ForEach(delegate (Password pass)
                {                    
                      context.Passwords.Attach(pass);
                      context.Categories.Attach(pass.CategoryId);
                });
                entity.CardsCompromised.ForEach(delegate (CreditCard card)
                {
                    card.CategoryId = null;
                    context.Cards.Attach(card);
                });
                context.DataBreachesResults.Add(entity);
                context.SaveChanges();
            }
        }

        public IEnumerable<DataBreachesResult> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.DataBreachesResults.Include(x => x.PasswordsCompromised.Select(c => c.CategoryId)).Include(x => x.CardsCompromised.Select(c => c.CategoryId)).ToList();
            }
        }

        public IEnumerable<DataBreachesResult> GetAllByUser(User entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.DataBreachesResults.Include("User").Include(x => x.PasswordsCompromised.Select(c => c.CategoryId)).Include(x => x.CardsCompromised.Select(c => c.CategoryId)) .Where(c => c.User.Id == entity.Id).ToList();
            }
        }
        public void Delete(DataBreachesResult entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                DataBreachesResult dataToDelete = context.DataBreachesResults.FirstOrDefault(c => c.Id == entity.Id);
                context.DataBreachesResults.Remove(dataToDelete);
                context.SaveChanges();
            }
        }
        public void Modify(DataBreachesResult entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                DataBreachesResult dataToModify = context.DataBreachesResults.FirstOrDefault(c => c.Id == entity.Id);
                dataToModify = entity;
                context.SaveChanges();
            }
        }
    }
}
