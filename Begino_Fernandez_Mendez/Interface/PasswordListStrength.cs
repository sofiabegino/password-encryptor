using Dominio;
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
    public partial class PasswordListStrength : UserControl
    {
        private User ActualUser;
        private List<Password> Passwords;
        public PasswordListStrength( User user, List<Password> passwords)
        {
            ActualUser = user;
            Passwords = passwords;
            InitializeComponent();
            listPasswords.Controls.Clear();
            ListInitialize();
        }

        private void ListInitialize()
        {

            foreach (Password selectedPassword in Passwords)
            {
                listPasswords.Items.Add(selectedPassword);
            }
        }
        private void BtnUpdatePass_Click(object sender, EventArgs e)
        {
            Password password = (Password)listPasswords.SelectedItem;
            panelStrength.Controls.Clear();
            UserControl update = new UpdatePassword( ActualUser, password);
            panelStrength.Controls.Add(update);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelStrength.Controls.Clear();
            UserControl system = new SystemOptions( ActualUser);
            panelStrength.Controls.Add(system);
        }
    }
}
