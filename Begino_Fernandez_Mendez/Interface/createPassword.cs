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
    public partial class CreatePassword : UserControl
    {
        const string DEFAULT_CATEGORY = "Compartidas";
        const string FORM_ERROR_MESSAGE = "Debe seleccionar al menos uno de los check boxes y el largo debe ser mayor a cero";
        const string BLANKS_ERROR_MESSAGE = "No puede dejar campos vacios";
        const string ALREADY_EXISTS = " ya existe en su registro, ";
        const string DOESNT_EXISTS = " no existe en su registro, ";
        const string IS_IN_DATABREACH = " esta en un data breach conocido y ";
        const string IS_NOT_IN_DATABREACH = " no esta en un data breach conocido y ";
        const string IS_SAFE = " es segura ";
        const string IS_NOT_SAFE = " no es segura ";
        const string THIS_PASSWORD = "Esta contraseña";

        private User ActualUser;
        private Password passwordGenerated;
        private DataAccessPassword DataAccessPassword;
        private DataAccessCategory DataAccessCategory;
        private DataAccessDataBreaches DataAccessDataBreaches;

        public CreatePassword( User user)
        {
            passwordGenerated = null;
            ActualUser = user;
            DataAccessPassword = new DataAccessPassword();
            DataAccessCategory = new DataAccessCategory();
            DataAccessDataBreaches = new DataAccessDataBreaches();

            InitializeComponent();
            InitializeComboBox();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComboBox()
        {
            comboBoxCategories.Controls.Clear();
            List<Category> categories = (List<Category>)DataAccessCategory.GetAllByUser(ActualUser);

            foreach (Category selectedCategory in categories)
            {
               if(selectedCategory.Name != DEFAULT_CATEGORY) comboBoxCategories.Items.Add(selectedCategory.Name);
            }
        }
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private Password CreatePass()
        {
            String category = comboBoxCategories.SelectedItem.ToString();
            String site = txtSite.Text;
            String user =  txtUser.Text;
            String password = txtPassword.Text;
            String notes = textBoxNotes.Text;
                try
                {
                    Password pass = new Password(category, site, user, password, 0, false, false, false, false, notes);
                    return pass;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
            }
        }

        private bool AnyFieldBlank()
        {
            bool siteBlank = string.IsNullOrEmpty(txtSite.Text);
            bool userBlank = string.IsNullOrEmpty(txtUser.Text);
            bool passwordBlank = string.IsNullOrEmpty(txtPassword.Text);
            bool categotyBlank = string.IsNullOrEmpty((string)comboBoxCategories.SelectedItem);
            return passwordBlank || siteBlank || userBlank || categotyBlank;
        }
        private Password CreatePasswordWithCheckBox()
        {
                String category = comboBoxCategories.SelectedItem.ToString();
                String site = txtSite.Text;
                String user = txtUser.Text;
                String password = txtPassword.Text;
                int length = (int)numericLength.Value;
                bool upperCase = checkBoxMay.Checked;
                bool lowerCase = checkBoxMin.Checked;
                bool specials = checkBoxSpecials.Checked;
                bool digits = checkBoxDigits.Checked;
                String notes = textBoxNotes.Text;
            try{ 
                Password pass = new Password(category, site, user, length, upperCase, lowerCase, digits, specials, notes);
                return pass;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length = (int)numericLength.Value;
            bool upperCase = checkBoxMay.Checked;
            bool lowerCase = checkBoxMin.Checked;
            bool specials = checkBoxSpecials.Checked;
            bool digits = checkBoxDigits.Checked;
            bool allFalse = (upperCase || lowerCase || specials || digits) == false;
            if (length <= 0 || allFalse)
            {
                MessageBox.Show(FORM_ERROR_MESSAGE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                passwordGenerated = CreatePasswordWithCheckBox();
                txtGeneratedPass.Text = passwordGenerated.DecryptPassword(passwordGenerated.Pass);
                txtPassword.Text = passwordGenerated.DecryptPassword(passwordGenerated.Pass);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (AnyFieldBlank()){
                MessageBox.Show(BLANKS_ERROR_MESSAGE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else{
                if (passwordGenerated == null){
                    passwordGenerated = CreatePass();
                }
                if (passwordGenerated != null)
                {
                    string categoryName = comboBoxCategories.SelectedItem.ToString();
                    Category category = DataAccessCategory.GetByName(categoryName, ActualUser);
                    passwordGenerated.CategoryId = category;
                    DataAccessPassword.Add(passwordGenerated);                    
                    ClearParameters();
                }
                if (passwordGenerated != null)
                {
                    List<DataBreachesResult> data = (List<DataBreachesResult>)DataAccessDataBreaches.GetAllByUser(ActualUser);
                    bool isInData = data.Exists(x => x.PasswordsCompromised.Exists(p => p.Pass == passwordGenerated.Pass));
                    bool isDuplicated = DataAccessPassword.GetCountOfEqualPasswordsByUser(ActualUser, passwordGenerated) >= 2;
                    bool isSafePassword = passwordGenerated.isSafePassword();

                    PasswordInformation(isInData, isDuplicated, isSafePassword);
                }
            }

        }

        private void createPassPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNotes_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxSpecials_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDigits_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            createPassPanel.Controls.Clear();
            UserControl system = new SystemOptions( ActualUser);
            createPassPanel.Controls.Add(system);
        }
        private void ClearParameters()
        {
            txtSite.Text = "";
            txtUser.Text = "";
            txtPassword.Text = "";
            textBoxNotes.Text = "";
            txtGeneratedPass.Text = "";
        }
        private void PasswordInformation(bool isInData, bool isDuplicated, bool isSafe)
        {
            string duplicated = isDuplicated ? ALREADY_EXISTS : DOESNT_EXISTS;

            string inData = isInData ? IS_IN_DATABREACH : IS_NOT_IN_DATABREACH;

            string safe = isSafe ? IS_SAFE: IS_NOT_SAFE;

            MessageBox.Show(THIS_PASSWORD + duplicated+ inData +safe);
        }
    }

}
