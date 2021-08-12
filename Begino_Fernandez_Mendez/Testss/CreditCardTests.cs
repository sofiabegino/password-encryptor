using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class CreditCardTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateCreditCardWithWrongParams()
        {
            CreditCard card = new CreditCard("Category", "Name", "Type", "1", "123", "date", "notes");
        }

      
        [TestMethod]
        public void GetNotes()
        {
            CreditCard credit = new CreditCard("category", "Visa", "type", "1111111111111111","2222", "12/02","notes" );
            Assert.IsTrue(credit.Notes == "notes");
        }
        [TestMethod]
        public void GetCode()
        {
            CreditCard credit = new CreditCard("category", "Visa", "type", "1111111111111111", "2222", "12/02", "notes");
            Assert.IsTrue(credit.Code == "2222");
        }
        [TestMethod]
        public void GetExpirationDate()
        {
            CreditCard credit = new CreditCard("category", "Visa", "type", "1111111111111111", "2222", "12/02", "notes");
            Assert.IsTrue(credit.ExpirationDate == "12/02");
        }
        [TestMethod]
        public void GetType()
        {
            CreditCard credit = new CreditCard("category", "Visa", "type", "1111111111111111", "2222", "12/02", "notes");
            Assert.IsTrue(credit.Type == "type");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidCreditCardNumber()
        {
            CreditCard card = new CreditCard("Category", "Name", "Type", "1", "123", "date", "notes");
        }



        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidCreditCardCode()
        {
            CreditCard card = new CreditCard("Category", "Name", "Type", "1234123412341234", "1", "date", "notes");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidCreditCardType()
        {
            CreditCard card = new CreditCard("Category", "Name", "T", "1234123412341234", "123", "date", "notes");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidCreditCardName()
        {
            CreditCard card = new CreditCard("Category", "N", "Type", "1234123412341234", "123", "date", "notes");
        }

        [TestMethod]
        public void ToStringIsOk()
        {
            CreditCard credit = new CreditCard("category", "Visa", "type", "1111111111111111", "2222", "12/02", "notes");
            Assert.IsTrue(credit.ToString() == "[Visa] [type] [1111111111111111]");
        }
    }
}
