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
    public partial class UpdatePassword : UserControl
    {
        const string SHARED_CATEGORY_NAME = "Compartidas";
        const string NO_EMPTY_FIELDS = "No puede dejar campos vacios";
        const string ERROR = "Error";
        const string GENERATE_BUTTON_ERROR_MESSAGE= "Debe seleccionar al menos uno de los check boxes y el largo debe ser mayor a cero";
        const string ALREADY_EXISTS = " ya existe en su registro, ";
        const string DOESNT_EXISTS = " no existe en su registro, ";
        const string IS_IN_DATABREACH = " esta en un data breach conocido y ";
        const string IS_NOT_IN_DATABREACH = " no esta en un data breach conocido y ";
        const string IS_SAFE = " es segura ";
        const string IS_NOT_SAFE = " no es segura ";
        const string THIS_PASSWORD = "Esta contraseña";
        const int INVALID_LENGTH = 0;

        private User ActualUser;
        private Password ActualPassword;
        private string Generated;
        private DataAccessPassword DataAccessPassword;
        private DataAccessCategory DataAccessCategory;
        private DataAccessDataBreaches DataAccessDataBreaches;
        public UpdatePassword( User user, Password password)
        {
            ActualUser = user;
            ActualPassword = password;
            Generated = "";
            DataAccessPassword = new DataAccessPassword();
            DataAccessCategory = new DataAccessCategory();
            DataAccessDataBreaches = new DataAccessDataBreaches();

            InitializeComponent();
            InitializeTextBoxes();
            InitializeComboBox();

        }
        private void InitializeComboBox()
        {
            comboBoxCategories.Controls.Clear();

            List<Category> categories = (List<Category>)DataAccessCategory.GetAll();

            foreach (Category selectedCategory in categories)
            {
                string categoryName = selectedCategory.Name;

                if (categoryName != SHARED_CATEGORY_NAME) comboBoxCategories.Items.Add(categoryName);
                if (categoryName == DataAccessCategory.Get(ActualPassword.CategoryId).Name) comboBoxCategories.SelectedItem = categoryName;
            }
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (AnyFieldBlank())
            {
                MessageBox.Show(NO_EMPTY_FIELDS, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string category = (string)comboBoxCategories.SelectedItem;
                string userName = txtUser.Text;
                string site = txtSite.Text;
                string password = txtPassword.Text;
                bool upper = checkBoxMay.Checked;
                bool lower = checkBoxMin.Checked;
                bool specials = checkBoxSpecials.Checked;
                bool numerics = checkBoxDigits.Checked;
                int length = (int)numericLength.Value;
                string notes = textBoxNotes.Text;

                Category dbCategory = DataAccessCategory.GetByName(category, ActualUser);

                try
                {
                    Password passwordToModify = DataAccessPassword.Get(ActualPassword); 
                    if (Generated == "")
                    {
                        passwordToModify.CategoryId = dbCategory;
                        passwordToModify.Category = category;
                        passwordToModify.Site = site;
                        passwordToModify.Username = userName;
                        passwordToModify.Pass = password;
                        passwordToModify.PasswordLength = 0;
                        passwordToModify.UpperCase = false;
                        passwordToModify.LowerCase = false;
                        passwordToModify.Digits = false;
                        passwordToModify.Special = false;
                        passwordToModify.Notes = notes;
                        passwordToModify.DateModified = DateTime.Now;
                        passwordToModify.isUpdated = true;

                        DataAccessPassword.Modify(passwordToModify);

                        ClearParameters();
                    }
                    else
                    {
                        passwordToModify = DataAccessPassword.Get(ActualPassword);
                        passwordToModify.CategoryId = dbCategory;
                        passwordToModify.Category = category;
                        passwordToModify.Site = site;
                        passwordToModify.Username = userName;
                        passwordToModify.Pass = Generated;
                        passwordToModify.PasswordLength = length;
                        passwordToModify.UpperCase = upper;
                        passwordToModify.LowerCase = lower;
                        passwordToModify.Digits = numerics;
                        passwordToModify.Special = specials;
                        passwordToModify.Notes = notes;
                        passwordToModify.DateModified = DateTime.Now;
                        passwordToModify.isUpdated = true;

                        DataAccessPassword.Modify(passwordToModify);
                       
                        ClearParameters();
                    }

                    List<DataBreachesResult> data = (List<DataBreachesResult>)DataAccessDataBreaches.GetAllByUser(ActualUser);
                    bool isInData = data.Exists(x => x.PasswordsCompromised.Exists(p => p.Pass == passwordToModify.Pass)); 
                    bool isDuplicated = DataAccessPassword.GetCountOfEqualPasswordsByUser(ActualUser, passwordToModify) >= 2;
                    bool isSafePassword = passwordToModify.isSafePassword();

                    PasswordInformation(isInData, isDuplicated, isSafePassword);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            updatePassPanel.Controls.Clear();
            UserControl system = new SystemOptions(ActualUser);
            updatePassPanel.Controls.Add(system);
        }
        private void InitializeTextBoxes()
        {
            string card = ActualPassword.Category;
            string userName = ActualPassword.Username;
            string site = ActualPassword.Site;
            string password = ActualPassword.DecryptPassword(ActualPassword.Pass);
            string notes = ActualPassword.Notes;
            bool upper = ActualPassword.UpperCase;
            bool lower = ActualPassword.LowerCase;
            bool specials = ActualPassword.Special;
            bool numerics = ActualPassword.Digits;
            int length = ActualPassword.Pass.Length;

            txtUser.Text = userName;
            txtSite.Text = site;
            txtPassword.Text = password;
            checkBoxDigits.Checked = numerics;
            checkBoxMay.Checked = upper;
            checkBoxMin.Checked = lower;
            checkBoxSpecials.Checked = specials;
            numericLength.Value = length;
            textBoxNotes.Text = notes;
        }

        private void UpdatePassPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int length = (int)numericLength.Value;
            bool upperCase = checkBoxMay.Checked;
            bool lowerCase = checkBoxMin.Checked;
            bool specials = checkBoxSpecials.Checked;
            bool digits = checkBoxDigits.Checked;
            bool allFalse = (upperCase || lowerCase || specials || digits) == false;

            if (length <= INVALID_LENGTH || allFalse)
            {
                MessageBox.Show(GENERATE_BUTTON_ERROR_MESSAGE, ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Generated = Password.Generate(length, upperCase, lowerCase, digits, specials);
                txtGeneratedPass.Text = Generated;
                txtPassword.Text = Generated;
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

        private void PasswordInformation(bool isInData, bool isDuplicated, bool isSafe)
        {
            string duplicated = isDuplicated ? ALREADY_EXISTS : DOESNT_EXISTS;

            string inData = isInData ? IS_IN_DATABREACH : IS_NOT_IN_DATABREACH;

            string safe = isSafe ? IS_SAFE : IS_NOT_SAFE;

            MessageBox.Show(THIS_PASSWORD + duplicated + inData + safe);
        }
        private void ClearParameters()
        {
            txtUser.Text = "";
            txtSite.Text = "";
            txtPassword.Text = "";
            textBoxNotes.Text = "";
            txtGeneratedPass.Text = "";
        }
    }
}
