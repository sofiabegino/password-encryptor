using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class DataAccessPassword: IDataAccess<Password>
    {
        public Password Get(Password entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Passwords.Include("CategoryId").Include("SharedWith").FirstOrDefault(c => c.Id == entity.Id);
            }
        }

        public Password GetByPassword(string password, User entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Passwords.Include("CategoryId").Include("SharedWith").FirstOrDefault(c => c.Pass == password && c.CategoryId.User.Id == entity.Id);
            }
        }

        public Password GetBySiteUserName(string site, string username)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Passwords.Include("CategoryId").Include("SharedWith").FirstOrDefault(c => c.Site == site && c.Username == username);
            }
        }

        public void Add(Password password)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                context.Categories.Attach(password.CategoryId);
                context.Passwords.Add(password);
                context.SaveChanges();
            }
        }

        public IEnumerable<Password> GetAll()
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Passwords.Include("CategoryId").Include("SharedWith").ToList();
            }
        }
        public IEnumerable<Password> GetAllByUser(User entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Passwords.Include("CategoryId").Include("SharedWith").Where(x => x.CategoryId.User.Id == entity.Id).ToList();
            }
        }
        public IEnumerable<Password> GetByCategory(Category entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Passwords.Include("CategoryId").Include("SharedWith").Where(x => x.CategoryId.Id == entity.Id).ToList();
            }
        }

        public IEnumerable<Password> GetByStrength(Dominio.Password.ColorStrength strength, User entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Passwords.Include("CategoryId").Include("SharedWith").Where(x => x.CategoryId.User.Id == entity.Id).Where(x => x.Strength == strength).ToList();
            }
        }

        public int CountByStrength(Category entity, Dominio.Password.ColorStrength strength)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Passwords.Include("CategoryId").Include("SharedWith").Where(x => x.CategoryId.Id == entity.Id).Where(x => x.Strength == strength).ToList().Count;
            }
        }

        public void Delete(Password entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passwordToDelete = context.Passwords.FirstOrDefault(c => c.Id == entity.Id);
                context.Passwords.Remove(passwordToDelete);
                context.SaveChanges();
            }
        }

        public void ModifyShareWith(Password entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passwordToModify = context.Passwords.Include("CategoryId").Include("SharedWith").FirstOrDefault(c => c.Id == entity.Id);
                passwordToModify.Shared = entity.Shared;
                    passwordToModify.SharedWith = entity.SharedWith;
                    passwordToModify.SharedWith.ForEach(delegate (User user)
                    {
                        context.Users.Attach(user);
                    });
                context.SaveChanges();

            }
        }

        public void Modify(Password entity)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                Password passwordToModify = context.Passwords.Include("CategoryId").Include("SharedWith").FirstOrDefault(c => c.Id == entity.Id);
                if (entity.CategoryId.Id != passwordToModify.CategoryId.Id)
                {
                    passwordToModify.CategoryId = entity.CategoryId;
                    context.Categories.Attach(passwordToModify.CategoryId);
                }
                else
                {
                    passwordToModify.CategoryId = entity.CategoryId;
                }

                passwordToModify.Category = entity.CategoryId.Name;
                passwordToModify.Site = entity.Site;
                passwordToModify.Username = entity.Username;
                passwordToModify.Pass = entity.Pass;
                passwordToModify.PasswordLength = entity.Pass.Length;
                passwordToModify.UpperCase = entity.UpperCase;
                passwordToModify.LowerCase = entity.LowerCase;
                passwordToModify.Digits = entity.Digits;
                passwordToModify.Special = entity.Special;
                passwordToModify.Notes = entity.Notes;
                passwordToModify.Shared = entity.Shared;
                passwordToModify.isUpdated = entity.isUpdated;
                passwordToModify.DateModified = entity.DateModified;

                context.SaveChanges();
            }
        }
        public int GetCountOfEqualPasswordsByUser(User user,Password pass)
        {
            using (PasswordManagerDBContext context = new PasswordManagerDBContext())
            {
                return context.Passwords.Include("CategoryId").Include("SharedWith").Where(x => x.CategoryId.User.Id == user.Id).Where(x => x.Pass == pass.Pass).ToList().Count();
            }
        }
    }
}
