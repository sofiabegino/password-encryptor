using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Dominio
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<DataBreachesResult> DataBreachesResults { get; set; }
        public List<Password> SharedPasswords { get; set; }

        public User()
        {
             
        }

        public User(string name, string password)
        {
          this.Name = name;

          this.Password = EncryptPassword(password);

          this.DataBreachesResults = new List<DataBreachesResult>();
          
          this.SharedPasswords = new List<Password>();

        }

        public void UpdatePassword(string newPassword)
        {
            Password = EncryptPassword(newPassword);
        }

        public override string ToString()
        {
            return this.Name;
        }

        public DataBreachesResult GetDataBreaches(DataBreachesResult dataBreaches)
        {
            return DataBreachesResults.Find(x => x.Date == dataBreaches.Date && x.Time == dataBreaches.Time);
        }

        public void AddDataBreaches(DataBreachesResult dataBreaches)
        {
             DataBreachesResults.Add(dataBreaches);
        }
    
        public string EncryptPassword(string password)
        {
            IEncryptor target = new Adapter();
            string pass = target.Encrypt(password);
            return pass;
        }

        public string DecryptPassword(string password)
        {
            IEncryptor target = new Adapter();
            string pass = target.Decrypt(password);
            return pass;
        }
    }
}