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
    public partial class ViewPasswordsShared : UserControl
    {
        private User ActualUser;

        private DataAccessUser DataAccessUser;
        public ViewPasswordsShared(  User user)
        {
            ActualUser = user;

            DataAccessUser = new DataAccessUser();
            InitializeComponent();
            listInitialize();
        }

        private void listInitialize()
        {
            List<Password> passwords = DataAccessUser.Get(ActualUser).SharedPasswords;

            foreach (Password selectedPassword in passwords)
            {
                var row1 = new string[] { selectedPassword.Site, selectedPassword.Username};
                var lvi1 = new ListViewItem(row1);
                lvi1.Tag = selectedPassword;
                listPassword.Items.Add(lvi1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPasswords.Controls.Clear();
            UserControl system = new SystemOptions( ActualUser);
            panelPasswords.Controls.Add(system);
        }
    }
}
