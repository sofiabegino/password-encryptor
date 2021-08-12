using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class DataBreachesResult
    {
        public int Id {get; set;}

        public User User { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public List<Password> PasswordsCompromised { get; set; }

        public List<CreditCard> CardsCompromised { get; set; }

        public DataBreachesResult()
        {

        }

        public DataBreachesResult(DateTime date, TimeSpan timeOfDay)
        {
            Date = date;
            Time = timeOfDay;
            PasswordsCompromised = new List<Password>();
            CardsCompromised = new List<CreditCard>();
        }

        public void AddPassword(Password password)
        {
            PasswordsCompromised.Add(password);
        }

        public Password GetPassword(Password password)
        {
            return PasswordsCompromised.Find(x => x.Site == password.Site && x.Username == password.Username);
        }

        public void AddCard(CreditCard card)
        {
            CardsCompromised.Add(card);
        }
        public bool IsDataBreachPassword(Password password)
        {
            return PasswordsCompromised.Exists(x => x.Pass == password.Pass);
        }
    }
}
