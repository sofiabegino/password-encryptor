using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass]
    public class RegisterTests
    {
        [TestMethod]
        public void UserListIsNotEmpty()
        {
            User user = new User("Juancito","123456");
            Register r = new Register();
            r.AddUser(user);
            Assert.IsTrue(r.Users.Contains(user));
        }
        [TestMethod]
        public void PasswordLengthValidation()
        {
            User user = new User("Juan", "123");
            Register r = new Register();
            r.AddUser(user);
            Assert.IsTrue(!r.Users.Contains(user));
        }
        [TestMethod]
        public void NameLengthValidation()
        {
            User user = new User("Juan", "123456");
            Register r = new Register();
            r.AddUser(user);
            Assert.IsTrue(!r.Users.Contains(user));
        }
        [TestMethod]
        public void sharePassword()
        {
            Register r = new Register();
            User u1 = new User("Juan", "123");
            User u2 = new User("Ana", "143");
            r.AddUser(u1);
            r.AddUser(u2);
            Password p = new Password("CategoryX", "com", "Usua", 15, true, false, false, false, "notes");
            r.sharePass(p,u1,u2);
            
            Assert.IsTrue(u1.getSharedPassword(p) == u2.getSharedPassword(p));
        }

        [TestMethod]
        public void stopSharing()
        {
            //comparto pass
            Register r = new Register();
            User u1 = new User("Juan", "123");
            User u2 = new User("Ana", "143");
            r.AddUser(u1);
            r.AddUser(u2);
            Password p = new Password("CategoryX", "com", "Usua", 15, true, false, false, false, "notes");
            r.sharePass(p, u1, u2);

            r.stopSharing(p, u1, u2);
            Assert.IsFalse(u2.Categories.Find(x => x.Name == "SharedPasswords").Passwords.Contains(p));
        }



    }
}
