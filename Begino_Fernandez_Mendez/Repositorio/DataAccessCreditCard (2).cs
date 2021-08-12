using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    class DataAccessCreditCard: IDataAccess<CreditCard>
    {
        public CreditCard Get(CreditCard entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Cards.FirstOrDefault(c => c.Id == entity.Id);
            }
        }

        public void Add(CreditCard card)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                // context.User.Attach(category.User); cambiar user en Category
                context.Cards.Add(card);
                context.SaveChanges();
            }
        }

        public IEnumerable<CreditCard> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Cards.ToList();
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
                cardToModify = entity;
                context.SaveChanges();
            }
        }
    }
}
