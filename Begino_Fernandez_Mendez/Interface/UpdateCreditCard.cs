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
    public partial class UpdateCreditCard : UserControl
    {
        const string SHARED_CATEGORY_NAME = "Compartidas";
        const string SUCCESSFUL_UPDATE = "Actualización exitosa";

        private User ActualUser;
        private CreditCard ActualCreditCard;
        private DataAccessCreditCard DataAccessCreditCard;
        private DataAccessCategory DataAccessCategory;

        public UpdateCreditCard(User user, CreditCard card)
        {
            ActualCreditCard = card;
            ActualUser = user;
            DataAccessCreditCard = new DataAccessCreditCard();
            DataAccessCategory = new DataAccessCategory();

            InitializeComponent();
            InitializeTextBoxes();
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {
            comboBoxCategory.Controls.Clear();

            List<Category> categories = (List<Category>)DataAccessCategory.GetAllByUser(ActualUser);

            foreach (Category selectedCategory in categories)
            {
                string categoryName = selectedCategory.Name;

                if (categoryName != SHARED_CATEGORY_NAME) comboBoxCategory.Items.Add(categoryName);
                if (categoryName == DataAccessCategory.Get(ActualCreditCard.CategoryId).Name) comboBoxCategory.SelectedItem = categoryName;
            }
        }
        private void updateCCPanel_Paint(object sender, PaintEventArgs e)
        {
        }
        private void InitializeTextBoxes()
        {
            string creditCard = ActualCreditCard.CategoryId.Name;
            string name = ActualCreditCard.Name;
            string type = ActualCreditCard.Type;
            string number = ActualCreditCard.Number;
            string code = ActualCreditCard.Code;
            string expiration = ActualCreditCard.ExpirationDate;
            string notes = ActualCreditCard.Notes;

            txtName.Text = name;
            txtNumber.Text = number;
            txtType.Text = type;
            textBoxCodigo.Text = code;
            textBoxExpirationDate.Text = expiration;
            textBoxNotes.Text = notes;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string category = comboBoxCategory.Text;
            string name = txtName.Text;
            string type = txtType.Text;
            string number = txtNumber.Text;
            string code = textBoxCodigo.Text;
            string expiration = textBoxExpirationDate.Text;
            string notes = textBoxNotes.Text;

            Category dbCategory = DataAccessCategory.GetByName(category, ActualUser);

            try
            {

                CreditCard cardToModify = DataAccessCreditCard.Get(ActualCreditCard);
                cardToModify.CategoryId = dbCategory;
                cardToModify.Category = category;
                cardToModify.Name = name;
                cardToModify.Type = type;
                cardToModify.Number = number;
                cardToModify.Code = code;
                cardToModify.ExpirationDate = expiration;
                cardToModify.Notes = notes;

                DataAccessCreditCard.Modify(cardToModify);

                lblSuccesful.Text = SUCCESSFUL_UPDATE;
                txtName.Text = "";
                txtType.Text ="";
                txtNumber.Text ="";
                textBoxCodigo.Text="";
                textBoxExpirationDate.Text ="";
                textBoxNotes.Text="";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            updateCCPanel.Controls.Clear();
            UserControl system = new SystemOptions(ActualUser);
            updateCCPanel.Controls.Add(system);
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
