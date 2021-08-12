using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class CategoryTests
    {

        [TestMethod]
        public void CategoryConstructor()
        {
            string name = "catego";
            Category Cat = new Category();
            Cat.Name = name;
            Assert.IsTrue("catego".Equals(Cat.Name));

        }
        [TestMethod]
        public void ToStringIsOk()
        {
            Category Cat = new Category("catego");
            Assert.IsTrue("catego".Equals(Cat.ToString()));

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidCategoryLength()
        {
            string ShortString = "ca";
            Category Cat = new Category(ShortString);
        }
     
    }
}
