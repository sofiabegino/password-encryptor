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
    public partial class SharePassword : UserControl
    {
        const string PASSWORD_SHARED = "Ya comparte esta contraseña con este usuario";

        private User ActualUser;
        private Password SelectedPassword;

        private DataAccessUser DataAccessUser;
        private DataAccessPassword DataAccessPassword;
        public SharePassword( User user, Password password)
        {
            ActualUser = user;
            SelectedPassword = password;

            DataAccessUser = new DataAccessUser();
            DataAccessPassword = new DataAccessPassword();

            InitializeComponent();
            comboBoxUsers.Controls.Clear();
            InitializeComboBox();
            InitializeTextBoxes();
        }

        private void InitializeComboBox()
        {
            comboBoxUsers.Controls.Clear();
            List<User> users = (List<User>)DataAccessUser.GetAll();

            foreach (User user in users)
            {
                if(user.Name != ActualUser.Name) comboBoxUsers.Items.Add(user);
            }
        }
        private void InitializeTextBoxes()
        {
            txtSite.Text = SelectedPassword.Site;
            txtUser.Text = SelectedPassword.Username;
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAcept_Click_1(object sender, EventArgs e)
        {
            User shareWith = (User)comboBoxUsers.SelectedItem;

            string site = txtSite.Text;
            string user = txtUser.Text;

            User toShare = DataAccessUser.GetByName(shareWith.Name);

            Password toModify = DataAccessPassword.Get(SelectedPassword);

            if (toModify.SharedWith != null && toModify.SharedWith.Exists(x=>x.Id == toShare.Id))
            {
                MessageBox.Show(PASSWORD_SHARED);
            }
            else
            {
                List<User> users = toModify.SharedWith;

                if (users == null)
                {
                    users = new List<User>();
                    users.Add(shareWith);
                }
                else
                {
                    users.Add(shareWith);
                }
                toModify.Shared = true;
                toModify.SharedWith = users;

                DataAccessPassword.ModifyShareWith(toModify);
            }

            txtSite.Text = "";
            txtUser.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            SharePassPanel.Controls.Clear();
            UserControl system = new SystemOptions( ActualUser);
            SharePassPanel.Controls.Add(system);
        }
    }
}
