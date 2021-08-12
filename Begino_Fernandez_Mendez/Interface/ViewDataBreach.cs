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
    public partial class ViewDataBreach : UserControl
    {
        const string UPDATE_ERROR_MESSAGE = "Debe seleccionar al menos una contraseña no modificada para actualizar";

        private User ActualUser;
        private DataBreachesResult Data;
        private DataAccessPassword DataAccessPassword;
        public ViewDataBreach( User user,DataBreachesResult data)
        {
            ActualUser = user;
            Data = data;
            DataAccessPassword = new DataAccessPassword();
            InitializeComponent();
            PasswordlistInitialize();
            CardsListInitialize();
        }

        private void PasswordlistInitialize()
        {
            listViewPasswords.Items.Clear();
            foreach (Password selectedPassword in Data.PasswordsCompromised)
            {

                
                    var row1 = new string[] { selectedPassword.isUpdated.ToString(), selectedPassword.Site, selectedPassword.Username };
                    var lvi1 = new ListViewItem(row1);
                    lvi1.Tag = selectedPassword;
                    listViewPasswords.Items.Add(lvi1);  
            }

        }

        private void CardsListInitialize()
        {
            listViewCards.Items.Clear();
            foreach (CreditCard selectedCard in Data.CardsCompromised)
            {
                    var row1 = new string[] {  selectedCard.Name, selectedCard.Type, "xxxx xxxx xxxx " + selectedCard.Number.Substring(11, 4), selectedCard.ExpirationDate }; var lvi1 = new ListViewItem(row1);
                    lvi1.Tag = selectedCard;
                    listViewCards.Items.Add(lvi1);
            }
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Password)listViewPasswords.SelectedItems[0].Tag;
                if (selectedItem != null && !selectedItem.isUpdated)
                {
                    Password passwordToUpdate = (Password)selectedItem;
                    Password dbPassword = DataAccessPassword.Get(passwordToUpdate);
                    dbPassword.isUpdated = true;

                    panelViewData.Controls.Clear();
                    UserControl view = new UpdatePassword( ActualUser, dbPassword);
                    panelViewData.Controls.Add(view);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(UPDATE_ERROR_MESSAGE);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelViewData.Controls.Clear();
            UserControl SystemOptions = new SystemOptions( ActualUser);
            panelViewData.Controls.Add(SystemOptions);
        }

        private void ViewDataBreach_Load(object sender, EventArgs e)
        {

        }

        private void panelViewData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewPasswords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
