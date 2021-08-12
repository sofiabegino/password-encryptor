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
    public partial class PasswordList : UserControl
    {
        const string UPDATE_ERROR_MESSAGE = "Debe seleccionar al menos una contraseña para actualizar";
        const string DELETE_ERROR_MESSAGE = "Debe seleccionar al menos una contraseña para eliminar";
        const string SHARED_ERROR= "Debe seleccionar una contraseña compartida";
        const string VIEW_ERROR_MESSAGE = "Debes seleccionar al menos una contraseña para ver";
        const string STOP_SHARE_ERROR_MESSAGE = "Debes seleccionar al menos una contraseña para dejar de compartir";


        private User ActualUser;
        private DataAccessPassword DataAccessPassword;
        private DataAccessCategory DataAccessCategory;
        public PasswordList( User user)
        {
            ActualUser = user;
            DataAccessPassword = new DataAccessPassword();
            DataAccessCategory = new DataAccessCategory();

            InitializeComponent();
            listInitialize();
        }

        private void listPasswords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Password_Load(object sender, EventArgs e)
        {

        }
        private void listInitialize()
        {
            List<Category> categories = (List<Category>)DataAccessCategory.GetAllByUser(ActualUser);

            categories.Sort((x, y) => x.Name.CompareTo(y.Name));
            listPasswords.Items.Clear();
            foreach (Category selectedCategory in categories)
            {
                List<Password> passwords = (List<Password>)DataAccessPassword.GetByCategory(selectedCategory);
                
                foreach (Password selectedPassword in passwords)
                {
                    var row1 = new string[] { selectedPassword.Category, selectedPassword.Site, selectedPassword.Username, selectedPassword.DateModified.ToString(), selectedPassword.Shared ? "Si" : "No" };
                    var lvi1 = new ListViewItem(row1);
                    lvi1.Tag = selectedPassword;
                    listPasswords.Items.Add(lvi1);
                }
            }
            
        }       

        private void btnAddPassword_Click(object sender, EventArgs e)
        {
            passwordPanel.Controls.Clear();
            UserControl create = new CreatePassword(ActualUser);
            passwordPanel.Controls.Add(create);
        }

        private void btnSeeChart_Click(object sender, EventArgs e)
        {
            passwordPanel.Controls.Clear();
            UserControl chart = new StrengthChart( ActualUser);
            passwordPanel.Controls.Add(chart);
        }

        private void btnDeletePass_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Password)listPasswords.SelectedItems[0].Tag;
                Password pass = (Password)selectedItem;
                string name = pass.Username;
                string site = pass.Site;

                List<Category> categories = (List<Category>)DataAccessCategory.GetAll();

                foreach (Category selectedCategory in categories)
                {
                    List<Password> passwords = (List<Password>)DataAccessPassword.GetByCategory(selectedCategory);

                    if (passwords.Exists(x => x.Username == name && x.Site == site))
                    {
                        DataAccessPassword.Delete(pass);
                        listPasswords.Items.Clear();
                        listInitialize();
                    }
                }
            } catch (Exception error)
            {
                MessageBox.Show(DELETE_ERROR_MESSAGE);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Password)listPasswords.SelectedItems[0].Tag;
                if (selectedItem != null)
                {
                    Password pass = (Password)selectedItem;
                    passwordPanel.Controls.Clear();
                    UserControl sharePass = new SharePassword( ActualUser, pass);
                    passwordPanel.Controls.Add(sharePass);
                }
            } catch (Exception error)
            {
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Password pass = (Password)listPasswords.SelectedItems[0].Tag;
                passwordPanel.Controls.Clear();
                UserControl password = new PasswordView(ActualUser, pass);
                passwordPanel.Controls.Add(password);
            }
            catch(Exception ex)
            {
                MessageBox.Show(VIEW_ERROR_MESSAGE);
            }
            
        }

        private Password SelectedItems(ListView listPasswords)
        {
            throw new NotImplementedException();
        }

        private void passwordPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            passwordPanel.Controls.Clear();
            UserControl system = new SystemOptions( ActualUser);
            passwordPanel.Controls.Add(system);
        }

        private void btnUpdatePass_Click_1(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Password)listPasswords.SelectedItems[0].Tag;
                if (selectedItem != null)
                {
                    Password pass = (Password)selectedItem;

                    passwordPanel.Controls.Clear();
                    UserControl update = new UpdatePassword( ActualUser, pass);
                    passwordPanel.Controls.Add(update);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(UPDATE_ERROR_MESSAGE);

            }
        }

        private void btnStopShare_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Password)listPasswords.SelectedItems[0].Tag;
                Password pass = (Password)selectedItem;
                Password toModify = DataAccessPassword.Get(pass);

                if (toModify.Shared)
                {
                    toModify.Shared = false;
                    List<User> emptyList = new List<User>();
                    toModify.SharedWith = emptyList;
                    DataAccessPassword.ModifyShareWith(toModify);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(STOP_SHARE_ERROR_MESSAGE);
            }
        }

        private void listPasswords_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (Password)listPasswords.SelectedItems[0].Tag;
                if (selectedItem != null && selectedItem.Shared)
                {
                    Password pass = (Password)selectedItem;

                    passwordPanel.Controls.Clear();
                    UserControl update = new ViewUsersShared( ActualUser, pass);
                    passwordPanel.Controls.Add(update);
                }
                else
                {
                    MessageBox.Show(SHARED_ERROR);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(SHARED_ERROR);
            }
        }
    }
}
