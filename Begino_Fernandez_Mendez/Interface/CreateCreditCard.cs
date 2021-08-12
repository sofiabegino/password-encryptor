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
    public partial class CreateCreditCard : UserControl
    {
        const string DEFAULT_CATEGORY = "Compartidas";
        const string BLANKS_ERROR_MESSAGE = "No puede dejar campos vacios";

        private User ActualUser;
        private DataAccessCreditCard DataAccessCreditCard;
        private DataAccessCategory DataAccessCategory;
        public CreateCreditCard( User user)
        {
            ActualUser = user;
            DataAccessCreditCard = new DataAccessCreditCard();
            DataAccessCategory = new DataAccessCategory();

            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBoxCategory.Controls.Clear();

            List<Category> categories = (List<Category>)DataAccessCategory.GetAllByUser(ActualUser);
            foreach(Category selectedCategory in categories)
            {
                if(selectedCategory.Name != DEFAULT_CATEGORY) comboBoxCategory.Items.Add(selectedCategory.Name);
            }
        }

        private void createCrediCardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!AnyFieldBlank())
            {
                string categoryName = comboBoxCategory.Text;
                string name = txtName.Text;
                string type = txtType.Text;
                string number = txtNumber.Text;
                string code = txtCodigo.Text;
                string expiration = txtExpirationDate.Text;
                string notes = txtNotes.Text;
                try
                {
                    Category category = DataAccessCategory.GetByName(categoryName, ActualUser);
                    CreditCard creditCard = new CreditCard(categoryName, name, type, number, code, expiration, notes);
                    creditCard.CategoryId = category;
                    DataAccessCreditCard.Add(creditCard);
                    ClearParameters();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(BLANKS_ERROR_MESSAGE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AnyFieldBlank()
        {
            bool nameBlank = string.IsNullOrEmpty(txtName.Text);
            bool numberBlank = string.IsNullOrEmpty(txtNumber.Text);
            bool tipoBlank = string.IsNullOrEmpty(txtType.Text);
            bool exirationBlank = string.IsNullOrEmpty(txtExpirationDate.Text);
            bool codeBlank = string.IsNullOrEmpty(txtCodigo.Text);
            return nameBlank || numberBlank || tipoBlank || exirationBlank || codeBlank ;
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            createCreditCardPanel.Controls.Clear();
            UserControl system = new SystemOptions( ActualUser);
            createCreditCardPanel.Controls.Add(system);
        }
        private void ClearParameters()
        {
            txtName.Text = "";
            txtType.Text = "";
            txtNumber.Text = "";
            txtCodigo.Text = "";
            txtExpirationDate.Text = "";
            txtNotes.Text = "";
        }
    }
}
