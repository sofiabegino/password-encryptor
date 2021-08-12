using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class DataBreachesTests
    {
        [TestMethod]

        public void CreateDataBreaches()
        {
            DataBreachesResult dataBreaches = new DataBreachesResult(new DateTime().Date, new DateTime().TimeOfDay);
            Assert.IsNotNull(dataBreaches);
        }

        [TestMethod]

        public void PasswordListIsInitialized()
        {
            DataBreachesResult dataBreaches = new DataBreachesResult(new DateTime().Date, new DateTime().TimeOfDay);
            Assert.IsNotNull(dataBreaches.PasswordsCompromised);
        }

        [TestMethod]

        public void CardsListIsInitialized()
        {
            DataBreachesResult dataBreaches = new DataBreachesResult(new DateTime().Date, new DateTime().TimeOfDay);
            Assert.IsNotNull(dataBreaches.CardsCompromised);
        }

        [TestMethod]

        public void AddPassword()
        {
            DataBreachesResult dataBreaches = new DataBreachesResult(new DateTime().Date, new DateTime().TimeOfDay);
            Password pass = new Password("CategoryX", "com", "Usua", 3, false, true, false, false, "notes");
            dataBreaches.AddPassword(pass);
            Assert.IsNotNull(dataBreaches.PasswordsCompromised.Find(x => x.Site == pass.Site && x.Username == pass.Username));
        }

        [TestMethod]

        public void GetPassword()
        {
            DataBreachesResult dataBreaches = new DataBreachesResult(new DateTime().Date, new DateTime().TimeOfDay);
            Password pass = new Password("CategoryX", "com", "Usua", 3, false, true, false, false, "notes");
            dataBreaches.AddPassword(pass);
            Assert.IsNotNull(dataBreaches.GetPassword(pass));
        }

        [TestMethod]

        public void AddCard()
        {
            DataBreachesResult dataBreaches = new DataBreachesResult(new DateTime().Date, new DateTime().TimeOfDay);
            CreditCard card = new CreditCard("CategoryX", "Juaan", "typeee", "1234567890123456", "123", "12/9/2028", "notes");
            dataBreaches.AddCard(card);
            Assert.IsNotNull(dataBreaches.CardsCompromised.Find(x => x.Number == card.Number));
        }

    }
}
