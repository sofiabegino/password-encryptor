using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Repositorio;

namespace Interface
{
    public partial class ResultDataBreaches : UserControl
    {
        private User ActualUser;
        private List<Password> Passwords;
        private List<CreditCard> CreditCards;
        private DataAccessCategory DataAccessCategory;
        private DataAccessPassword DataAccessPassword;
        private DataAccessCreditCard DataAccessCreditCard;
        private DataAccessDataBreaches DataAccessDataBreaches;

        public ResultDataBreaches( User user, List<Password> password,List<CreditCard> creditCard)
        {
            Passwords = password;
            CreditCards = creditCard;
            ActualUser = user;
            DataAccessCategory = new DataAccessCategory();
            DataAccessPassword = new DataAccessPassword();
            DataAccessCreditCard = new DataAccessCreditCard();
            DataAccessDataBreaches = new DataAccessDataBreaches();

            DataBreachesResult dataBreachesResult = new DataBreachesResult(DateTime.Now, DateTime.Now.TimeOfDay);
            dataBreachesResult.PasswordsCompromised = Passwords;
            dataBreachesResult.CardsCompromised = CreditCards;
            dataBreachesResult.User = ActualUser;
         
            DataAccessDataBreaches.Add(dataBreachesResult);

            InitializeComponent();
            listBoxDBCreditC.Controls.Clear();
            listBoxDBPass.Controls.Clear();
            creditCardListInitialize();
            passwordListInitialize();
        }

        private void resultDataBreachesPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnModificarPass_Click(object sender, EventArgs e)
        {
            try
            {
                string itemPass = listBoxDBPass.SelectedItem.ToString();
                string[] subs = itemPass.Split('[', ']');
                string Name = subs[5];
                string Site = subs[3];

                Password password = null;
                List<Category> categories = (List<Category>)DataAccessCategory.GetAllByUser(ActualUser);


                foreach (Category selectedCategory in categories)
                {
                    List<Password> passwords = (List<Password>)DataAccessPassword.GetByCategory(selectedCategory);

                    if (passwords.Exists(x => x.Username == Name && x.Site == Site))
                    {
                        password = DataAccessPassword.GetBySiteUserName(Site, Name);
                    }
                }

                resultDataBreachesPanel.Controls.Clear();
                UserControl update = new UpdatePassword( ActualUser, password);
                resultDataBreachesPanel.Controls.Add(update);
            } catch(Exception error)
            {

            }


        }
        private void passwordListInitialize()
        {
            foreach(Password password in Passwords)
            {
                listBoxDBPass.Items.Add(password);
            }    
        }
        private void creditCardListInitialize()
        {
            foreach (CreditCard card in CreditCards)
            {
                listBoxDBCreditC.Items.Add(card);
            }
        }
        private void listBoxDBCreditC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            resultDataBreachesPanel.Controls.Clear();
            UserControl system = new SystemOptions( ActualUser);
            resultDataBreachesPanel.Controls.Add(system);
        }

        private void btnModificarCC_Click_1(object sender, EventArgs e)
        {
            try
            {
                string itemCC = listBoxDBCreditC.SelectedItem.ToString();
                string[] subCC = itemCC.Split('[', ']');
                string number = subCC[5];

                List<Category> categories = (List<Category>)DataAccessCategory.GetAllByUser(ActualUser);
                CreditCard creditCard = null;

                foreach (Category selectedCategory in categories)
                {
                    List<CreditCard> CreditCards = (List<CreditCard>)DataAccessCreditCard.GetByCategory(selectedCategory);

                    if (CreditCards.Exists(x => x.Number == number))
                    {
                        creditCard = DataAccessCreditCard.GetByNumber(number, ActualUser);
                    }
                }

                resultDataBreachesPanel.Controls.Clear();
                UserControl update = new UpdateCreditCard( ActualUser, creditCard);
                resultDataBreachesPanel.Controls.Add(update);

            }
            catch (Exception error)
            {

            }
        }
        
    }
}
