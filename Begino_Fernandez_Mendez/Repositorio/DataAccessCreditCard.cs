using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class DataAccessCreditCard: IDataAccess<CreditCard>
    {
        public CreditCard Get(CreditCard entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Cards.Include("CategoryId").FirstOrDefault(c => c.Id == entity.Id);
            }
        }

        public CreditCard GetByNumber(string number, User entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Cards.Include("CategoryId").FirstOrDefault(c => c.Number == number && c.CategoryId.User.Id == entity.Id);
            }
        }

        public void Add(CreditCard card)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Categories.Attach(card.CategoryId); 
                context.Cards.Add(card);
                context.SaveChanges();
            }
        }

        public IEnumerable<CreditCard> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Cards.Include("CategoryId").ToList();
            }
        }
        public IEnumerable<CreditCard> GetAllByUser(User entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Cards.Include("CategoryId").Where(x => x.CategoryId.User.Id == entity.Id).ToList();
            }
        }
        public IEnumerable<CreditCard> GetByCategory(Category entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Cards.Include("CategoryId").Where(x => x.CategoryId.Id == entity.Id).ToList();
            }
        }

        public void Delete(CreditCard entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                CreditCard cardToDelete = context.Cards.FirstOrDefault(c => c.Id == entity.Id);
                context.Cards.Remove(cardToDelete);
                context.SaveChanges();
            }
        }

        public void Modify(CreditCard entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                CreditCard cardToModify = context.Cards.FirstOrDefault(c => c.Id == entity.Id);
                cardToModify.Category = entity.CategoryId.Name;
                cardToModify.CategoryId = entity.CategoryId;
                cardToModify.Name = entity.Name;
                cardToModify.Type = entity.Type;
                cardToModify.Number = entity.Number;
                cardToModify.Code = entity.Code;
                cardToModify.ExpirationDate = entity.ExpirationDate;
                cardToModify.Notes = entity.Notes;
                context.Categories.Attach(cardToModify.CategoryId);
                context.SaveChanges();
            }
        }
    }
}
