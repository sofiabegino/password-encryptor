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
    public partial class CreditCardList : UserControl
    {
        const string DELETE_ERROR_MESSAGE = "Debe seleccionar al menos una tarjeta para borrar";
        const string UPDATE_ERROR_MESSAGE = "Debe seleccionar al menos una tarjeta para actualizar";

        private User ActualUser;
        private DataAccessCreditCard DataAccessCreditCard;
        private DataAccessCategory DataAccessCategory;
        public CreditCardList( User user)
        {
            ActualUser = user;
            DataAccessCreditCard = new DataAccessCreditCard();
            DataAccessCategory = new DataAccessCategory();

            InitializeComponent();
            listCreditCards.Controls.Clear();
            ListInitialize();
        }

        private void listCreditCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        private void btnDeleteCreditCard_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (CreditCard)listCreditCards.SelectedItems[0].Tag;

                CreditCard creditCard = (CreditCard)selectedItem;

                string number = creditCard.Number;

                List<Category> categories = (List<Category>)DataAccessCategory.GetAll();

                foreach (Category selectedCategory in categories)
                {
                    List<CreditCard> creditCards = (List<CreditCard>)DataAccessCreditCard.GetByCategory(selectedCategory);

                    if (creditCards.Exists(x => x.Number == number))
                    {
                        DataAccessCreditCard.Delete(creditCard);
                        listCreditCards.Items.Clear();
                        ListInitialize();
                    }
                }
            } catch (Exception error)
            {
            }
                MessageBox.Show(DELETE_ERROR_MESSAGE);

        }

        private void btnUpdateCreditC_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (CreditCard)listCreditCards.SelectedItems[0].Tag;

                CreditCard creditCard = (CreditCard)selectedItem;

                creditCardPanel.Controls.Clear();

                UserControl update = new UpdateCreditCard( ActualUser, creditCard);

                creditCardPanel.Controls.Add(update);

            } catch (Exception error)
            {
                MessageBox.Show(UPDATE_ERROR_MESSAGE);
            }

        }
        private void ListInitialize()
        {
            List<Category> categories = (List<Category>)DataAccessCategory.GetAllByUser(ActualUser);

            categories.Sort((x, y) => x.Name.CompareTo(y.Name));
            listCreditCards.Items.Clear();
            foreach (Category selectedCategory in categories)
            {
                List<CreditCard> creditCards = (List<CreditCard>)DataAccessCreditCard.GetByCategory(selectedCategory);

                foreach (CreditCard selectedCard in creditCards)
                {
                    var row1 = new string[] { selectedCard.Category, selectedCard.Name, selectedCard.Type, "xxxx xxxx xxxx "+ selectedCard.Number.Substring(11, 4), selectedCard.ExpirationDate }; var lvi1 = new ListViewItem(row1);
                    lvi1.Tag = selectedCard;
                    listCreditCards.Items.Add(lvi1);
                }
            }
        }

        private void btnAddCreditCard_Click(object sender, EventArgs e)
        {
            creditCardPanel.Controls.Clear();
            UserControl create = new CreateCreditCard(ActualUser);
            creditCardPanel.Controls.Add(create);
        }

        private void creditCardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            creditCardPanel.Controls.Clear();
            UserControl systemOptions = new SystemOptions(ActualUser);
            creditCardPanel.Controls.Add(systemOptions);
        }
    }
}
