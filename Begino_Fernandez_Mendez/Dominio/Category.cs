using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Category
    {
        public List<Password> Passwords { get; set; }
        public string Name { get; set; }
        public List<CreditCard> CreditCards { get; set; }

        public void AddPassword(Password pass)
        {
            if (pass.Username.Length > 5 && pass.Username.Length < 20 
                && pass.PasswordLength > 3 && pass.PasswordLength < 25
                && pass.Site.Length > 3 && pass.Site.Length < 25
                && pass.Notes.Length < 250
                )
            {
                Passwords.Add(pass);
            }
        }

        public void AddCreditCard(CreditCard card)
        {
            CreditCards.Add(card);
        }

        public Category(string name)
        {
            Passwords = new List<Password>();
            CreditCards = new List<CreditCard>();
            Name = name;
        }


    }
}