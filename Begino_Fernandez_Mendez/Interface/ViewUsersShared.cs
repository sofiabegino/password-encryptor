using Dominio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class ViewUsersShared : UserControl
    {
        private User ActualUser;
        private Password SelectedPassword;

        private DataAccessPassword DataAccessPassword;
        public ViewUsersShared(  User user, Password password)
        {
            ActualUser = user;
            SelectedPassword = password;

            DataAccessPassword = new DataAccessPassword();
            InitializeComponent();
            listInitialize();
        }

        private void listInitialize()
        {

            listUsers.Items.Clear();
            
                List<User> users = DataAccessPassword.Get(SelectedPassword).SharedWith.ToList();

                foreach (User selectedUser in users)
                {
                    var row1 = new string[] { selectedUser.Name  };
                    var lvi1 = new ListViewItem(row1);
                    lvi1.Tag = selectedUser;
                    listUsers.Items.Add(lvi1);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelUsersShared.Controls.Clear();
            UserControl system = new SystemOptions( ActualUser);
            panelUsersShared.Controls.Add(system);
        }
    }
}
