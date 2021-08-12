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
    public partial class PasswordStrength : UserControl
    {
        const string RED = "Rojo";
        const string ORANGE = "Naranja";
        const string YELLOW = "Amarillo";
        const string LIGHT_GREEN = "VerdeClaro";
        const string DARK_GREEN = "VerdeOscuro";

        private User User;
        private DataAccessPassword DataAccessPassword;

        public PasswordStrength( User user)
        {
            InitializeComponent();

            User = user;
            DataAccessPassword = new DataAccessPassword();

            listView.Items.Clear();
            List<Password> Rojo = (List<Password>)DataAccessPassword.GetByStrength(Password.ColorStrength.Red, User);
            List<Password> Naranja = (List<Password>)DataAccessPassword.GetByStrength(Password.ColorStrength.Orange, User);
            List<Password> Amarillo = (List<Password>)DataAccessPassword.GetByStrength(Password.ColorStrength.Yellow, User);
            List<Password> VerdeClaro = (List<Password>)DataAccessPassword.GetByStrength(Password.ColorStrength.LightGreen, User);
            List<Password> VerdeOscuro = (List<Password>)DataAccessPassword.GetByStrength(Password.ColorStrength.Green, User);

            var row1 = new string[] { RED, Rojo.Count.ToString() };
            var lvi1 = new ListViewItem(row1);
            lvi1.Tag = Rojo;
            listView.Items.Add(lvi1);
            var row2 = new string[] { ORANGE, Naranja.Count.ToString() };
            var lvi2 = new ListViewItem(row2);
            lvi2.Tag = Naranja;
            listView.Items.Add(lvi2);
            var row3 = new string[] {YELLOW, Amarillo.Count.ToString() };
            var lvi3 = new ListViewItem(row3);
            lvi3.Tag = Amarillo;
            listView.Items.Add(lvi3);
            var row4 = new string[] { LIGHT_GREEN, VerdeClaro.Count.ToString() };
            var lvi4 = new ListViewItem(row4);
            lvi4.Tag = VerdeClaro;
            listView.Items.Add(lvi4);
            var row5 = new string[] { DARK_GREEN, VerdeOscuro.Count.ToString() };
            var lvi5 = new ListViewItem(row5);
            lvi5.Tag = VerdeOscuro;
            listView.Items.Add(lvi5);
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (List<Password>)listView.SelectedItems[0].Tag;

                if (selectedItem != null)
                {
                    strengthPanel.Controls.Clear();
                    UserControl passwords = new PasswordListStrength( User, selectedItem);
                    strengthPanel.Controls.Add(passwords);
                }

            } catch (Exception error)
            {

            }

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            strengthPanel.Controls.Clear();
            UserControl system = new SystemOptions( User);
            strengthPanel.Controls.Add(system);
        }
    }
}
