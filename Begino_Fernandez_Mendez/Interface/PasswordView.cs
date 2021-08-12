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

namespace Interface
{
    public partial class PasswordView : UserControl
    {
        private User ActualUser;
        private Password ActualPassword;
        public PasswordView(User user, Password password)
        {
            ActualPassword = password;
            ActualUser = user;

            InitializeComponent();
            InitializeElements();
        }

        private void PasswordView_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            passwordViewPanel.Controls.Clear();
            UserControl passwords = new PasswordList( ActualUser);
            passwordViewPanel.Controls.Add(passwords);
        }
        private void InitializeElements()
        {
            txtCategories.Text = ActualPassword.Category;
            txtPassword.Text = ActualPassword.DecryptPassword(ActualPassword.Pass);
            txtSite.Text = ActualPassword.Site;
            txtUser.Text = ActualPassword.Username;
        }

        private void passwordViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
