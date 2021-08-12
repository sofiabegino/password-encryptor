using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tests
{
    [TestClass]
    public class PasswordTests
    {
        [TestInitialize]
        public void initializeTest()
        {
            User u1 = new User("Nitaaaa", "passss");
            User u2 = new User("Nitaaaa", "passss");
            User u3 = new User("Nitaaaa", "passss");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePasswordWithWrongParams()
        {            
            Password pass = new Password("CategoryX", "com", "Usua", "pass", 3 , true, true, true, true, "notes");

        }

        [TestMethod]
        public void GeneratePasswordWithUpperCase()
        {
            Password pass = new Password("CategoryX", "com", "Usua", 3, true, false, false, false, "notes");
            string password = pass.Pass;
            Assert.IsTrue(password.Any(ch => Char.IsUpper(ch)));
        }

        [TestMethod]
        public void GeneratePasswordWithLowerCase()
        {
            Password pass = new Password("CategoryX", "com", "Usua", 3, false, true, false, false, "notes");
            string password = pass.Pass;
            Assert.IsTrue(password.Any(ch => Char.IsLower(ch)));
        }

        [TestMethod]
        public void GeneratePasswordWithDigits()
        {
            Password pass = new Password("CategoryX", "com", "Usua", 3, false, false, true, false, "notes");
            string password = pass.Pass;
            Assert.IsTrue(password.Any(ch => Char.IsDigit(ch)));
        }

        [TestMethod]
        public void GeneratePasswordWithSpecial()
        {
            Password pass = new Password("CategoryX", "com", "Usua", 3, false, false, false, true, "notes");
            string password = pass.Pass;
            Assert.IsTrue(password.Any(ch => !Char.IsLetterOrDigit(ch)));
        }

        [TestMethod]
        public void GeneratePasswordWithAll()
        {
            Password pass = new Password("CategoryX", "com", "Usua", 15, true, true, true, true, "notes");
            string password = pass.Pass;
            Console.WriteLine(password);
            Assert.IsTrue(
                password.Any(ch => Char.IsDigit(ch)) && 
                password.Any(ch => !Char.IsLetterOrDigit(ch)) &&
                password.Any(ch => Char.IsLower(ch)) &&
                password.Any(ch => Char.IsUpper(ch))
            );
        }

        [TestMethod]
        public void ReturnStrengthGreen()
        {
            Password pass = new Password("CategoryX", "com", "Usua", 20, true, true, true, true, "notes");
            Assert.IsTrue(pass.Strength == Password.ColorStrength.Green);
        }

        [TestMethod]
        public void ReturnStrengthLightGreen()
        {
            Password pass = new Password("CategoryX", "com", "Usua", 20, true, true, true, false, "notes");
            Assert.IsTrue(pass.Strength == Password.ColorStrength.LightGreen);
        }

        [TestMethod]
        public void ReturnStrengthOrange()
        {
            Password pass = new Password("CategoryX", "com", "Usua", 10, true, true, true, true, "notes");
            Assert.IsTrue(pass.Strength == Password.ColorStrength.Orange);
        }

        [TestMethod]
        public void ReturnStrengthRed()
        {
            Password pass = new Password("CategoryX", "com", "Usua", 5, true, true, true, true, "notes");
            Assert.IsTrue(pass.Strength == Password.ColorStrength.Red);
        }

        [TestMethod]
        public void ReturnStrengthYellow()
        {
            Password pass = new Password("CategoryX", "com", "Usua", 15, true, false, false, false, "notes");
            Assert.IsTrue(pass.Strength == Password.ColorStrength.Yellow);
        }
        [TestMethod]
        public void createSharedPassword()
        {
            Password p = new Password("CategoryX", "com", "Usua", 15, true, false, false, false, "notes");
            p.Shared = true;
            Assert.IsTrue(p.Shared);
        }

        [TestMethod]
        public void ReturnStrengthLightGreenWithLowerCaseUpperLower()
        {
            Password pass = new Password("CategoryX", "com", "Usuaario", "aasdfertAAAAeaa", 15, true, true, true, false, "notes");
            Assert.IsTrue(pass.Strength == Password.ColorStrength.LightGreen);
        }
        [TestMethod]
        public void ReturnStrengthLightGreenWithLowerCaseUpperSpecial()
        {
            Password pass = new Password("CategoryX", "com", "Usuaario", "aasdfertAAAAe.f", 15, true, true, true, false, "notes");
            Assert.IsTrue(pass.Strength == Password.ColorStrength.LightGreen);
        }
        [TestMethod]
        public void ReturnStrengthLightGreenWithLowerCaseDigitSpecial()
        {
            Password pass = new Password("CategoryX", "com", "Usuaario", "aasdfert1234e.f", 15, true, true, true, false, "notes");
            Assert.IsTrue(pass.Strength == Password.ColorStrength.LightGreen);
        }
        [TestMethod]
        public void ReturnStrengthLightGreenWithUpperCaseAndDigit()
        {
            Password pass = new Password("CategoryX", "com", "Usuaario", "Aasdfert1234erf", 15, true, true, true, false, "notes");
            Assert.IsTrue(pass.Strength == Password.ColorStrength.LightGreen);
        }
        [TestMethod]
        public void ToStringIsOk()
        {
            Password pass = new Password("CategoryX", "com", "Usuaario", "Aasdfert1234erf", 15, true, true, true, false, "notes");
            Assert.IsTrue(pass.ToString() == "[CategoryX] [com] [Usuaario]");
        }

        [TestMethod]
        public void EncryptAndDecryptPassword()
        {
            Password pass = new Password("CategoryX", "com", "Usuario", "contraaaa", 3, false, false, false, false, "notes");
            string passwordEncrypt = pass.EncryptPassword(pass.Pass);
            string passwordDecrypt = pass.DecryptPassword(passwordEncrypt);
            Assert.IsTrue(pass.Pass == passwordDecrypt);
        }

        [TestMethod]
        public void IsSafePassword()
        {
            Password pass = new Password("CategoryX", "com", "Usuaario", "AAaa????\\--22--", 16, false, false, false, false, "notes");
            Assert.IsTrue(pass.isSafePassword());
        }
    }
}
