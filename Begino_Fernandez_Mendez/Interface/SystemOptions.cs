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
    public partial class SystemOptions : UserControl
    {
        private User ActualUser;
        public SystemOptions(User user)
        {
            ActualUser = user;

            InitializeComponent();
        }

        private void BtnAddNewPass_Click(object sender, EventArgs e)
        {
            systemOptionsPanel.Controls.Clear();
            UserControl password = new PasswordList(ActualUser);
            systemOptionsPanel.Controls.Add(password);
        }

        private void BtnAddNewCreditC_Click(object sender, EventArgs e)
        {
            systemOptionsPanel.Controls.Clear();
            UserControl creditCard = new CreditCardList(ActualUser);
            systemOptionsPanel.Controls.Add(creditCard);
        }

        private void BtnDataBreaches_Click(object sender, EventArgs e)
        {
            systemOptionsPanel.Controls.Clear();
            UserControl dataBreaches = new DataBreaches(ActualUser);
            systemOptionsPanel.Controls.Add(dataBreaches);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            systemOptionsPanel.Controls.Clear();
            UserControl categories = new Categories(ActualUser);
            systemOptionsPanel.Controls.Add(categories);
        }

        private void SystemOptions_Load(object sender, EventArgs e)
        {















        }

        private void SystemOptionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPasswordsStrength_Click(object sender, EventArgs e)
        {
            systemOptionsPanel.Controls.Clear();
            UserControl passwordsStrength = new PasswordStrength( ActualUser);
            systemOptionsPanel.Controls.Add(passwordsStrength);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            systemOptionsPanel.Controls.Clear();
            UserControl login = new Login();
            systemOptionsPanel.Controls.Add(login);
        }
    }
}
