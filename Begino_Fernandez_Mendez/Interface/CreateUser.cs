using System;
using Dominio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio;

namespace Interface
{
    public partial class CreateUser : UserControl
    {
        const string DEFAULT_CATEGORY = "Compartidas";
        const string CREATE_USER_SUCCESS = "Usuario creado con exito!";
        const string USER_EXISTS = "Nombre de usuario existente, prueba con otro!";
        const string USERNAME_LENGTH_INVALID_MESSAGE = "El usuario debe tener entre 5 y 25 caracteres";
        const string PASSWORD_LENGTH_INVALID_MESSAGE = "La contrasena debe tener entre 5 y 25 caracteres";
        const string BLANKS_ERROR_MESSAGE = "No puede dejar campos vacios";

        private DataAccessUser DataAccessUser;
        private DataAccessCategory DataAccessCategory;
        public CreateUser()
        {
            InitializeComponent();
            DataAccessUser = new DataAccessUser();
            DataAccessCategory = new DataAccessCategory();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (AnyFieldBlank())
            {
                MessageBox.Show(BLANKS_ERROR_MESSAGE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{ 
                String name = txtCreateUserN.Text;
                String password = txtCreatePassword.Text;
                User user = new User(name, password);
                if (checkedParameters(name) && checkedParameters(password) && !UserIsInTheRegister(name))
                {
                    lblUserCreated.Text = CREATE_USER_SUCCESS;
                    CleanParameters();
                    DataAccessUser.Add(user);
                    Category sharedCategory = new Category(DEFAULT_CATEGORY);
                    sharedCategory.User = user;
                    DataAccessCategory.Add(sharedCategory);
                }
                else
                {
                    if (UserIsInTheRegister(name))
                    {
                        lblUserCreated.Text = USER_EXISTS;

                    }
                    else if (checkedParameters(name))
                    {
                        lblUserCreated.Text = PASSWORD_LENGTH_INVALID_MESSAGE; 
                    }
                    else
                    {
                        lblUserCreated.Text = USERNAME_LENGTH_INVALID_MESSAGE; 
                    }
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            createUserPanel.Controls.Clear();
            UserControl login = new Login();
            createUserPanel.Controls.Add(login);

        }

        private void lblUserCreated_Click(object sender, EventArgs e)
        {

        }
        private bool AnyFieldBlank()
        {
            bool nameBlank = string.IsNullOrEmpty(txtCreateUserN.Text);
            bool passBlank = string.IsNullOrEmpty(txtCreatePassword.Text);
            return nameBlank || passBlank;
        }
        private bool checkedParameters(String str)
        {
            const int USER_MIN_LENGTH = 5;
            const int USER_MAX_LENGTH = 20;

            return str.Length >= USER_MIN_LENGTH && str.Length <= USER_MAX_LENGTH;
        }
        private bool UserIsInTheRegister(String name)
        {
            List<User> users = (List<User>)DataAccessUser.GetAll();
            return users.Exists(x => x.Name == name);
        }
        private void CleanParameters()
        {
            txtCreateUserN.Text = "";
            txtCreatePassword.Text = "";
        }

        private void createUserPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
