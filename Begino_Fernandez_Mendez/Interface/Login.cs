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
    public partial class Login : UserControl
    {
        const string BLANKS_ERROR_MESSAGE = "No puede dejar campos vacios";
        const string ERROR_MESSAGE = "No existe este usuario o contraseña";
        private User ActualUser;
        private DataAccessUser DataAccessUser;
        public Login()
        {
            InitializeComponent();
            DataAccessUser = new DataAccessUser();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (AnyFieldBlank())
            {
                MessageBox.Show(BLANKS_ERROR_MESSAGE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String userName = txtUserName.Text;
                String password = txtPassword.Text;

                List<User> users = (List<User>)DataAccessUser.GetAll();
                
                if(users.Exists(x => x.Name == userName && x.DecryptPassword(x.Password)==password))
                {
                    ActualUser = DataAccessUser.GetByName(userName);
                    LoginPanel.Controls.Clear();
                    UserControl system = new SystemOptions( ActualUser);
                    LoginPanel.Controls.Add(system);
                }
                else
                {
                    MessageBox.Show(ERROR_MESSAGE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {

            LoginPanel.Controls.Clear();
            UserControl createUser = new CreateUser();
            LoginPanel.Controls.Add(createUser);

        }
        private bool AnyFieldBlank()
        {
            bool nameBlank = string.IsNullOrEmpty(txtUserName.Text);
            bool passBlank = string.IsNullOrEmpty(txtPassword.Text);
            return nameBlank || passBlank;
        }
    }
}
