using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void CreateUserNotEmpty()
         {
           User user = new User("Juancito", "12345");
           Assert.IsTrue(user.Name != "" && user.Password != "");
         }
      
        [TestMethod]
        public void ToStringIsOk()
        {
            User u = new User("usuario", "contras");
            Assert.IsTrue(u.ToString() == "usuario");
        }

        [TestMethod]
        public void AddDataBreaches()
        {
            User u = new User("usuario", "contras");
            DataBreachesResult data = new DataBreachesResult();
            u.AddDataBreaches(data);
            Assert.IsTrue(u.DataBreachesResults.Contains(data));
        }

        [TestMethod]
        public void GetDataBreaches()
        {
            User u = new User("usuario", "contras");
            DataBreachesResult data = new DataBreachesResult(DateTime.Now, DateTime.Now.TimeOfDay);
            u.AddDataBreaches(data);
            Assert.IsNotNull(u.GetDataBreaches(data));
        }

        [TestMethod]
        public void EncryptorPasswordUser()
        {
            User user = new User("usuario", "contraa123");
            string passwordEncr = user.EncryptPassword(user.Password);
            string passwordDecr = user.DecryptPassword(user.Password);
            Assert.IsTrue("contraa123".Equals(passwordDecr));
        }

    }
}
