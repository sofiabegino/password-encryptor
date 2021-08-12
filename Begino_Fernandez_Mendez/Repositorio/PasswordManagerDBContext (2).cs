using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    class PasswordManagerDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CreditCard> Cards { get; set; }
        public DbSet<Password> Passwords { get; set; }

        public PasswordManagerDBContext() : base("name=PasswordManagerDBContext")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().HasKey(x => x.Name);
            //modelBuilder.Entity<Category>().HasKey(x => x.Name);
            //modelBuilder.Entity<CreditCard>().HasKey(x => x.Number);
            //modelBuilder.Entity<Password>().HasKey(x =>new { x.Username, x.Site});
        }
    }
}
