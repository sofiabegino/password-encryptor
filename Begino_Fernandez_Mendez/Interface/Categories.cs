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
    public partial class Categories : UserControl
    {
        const string DEFAULT_CATEGORY = "Compartidas";
        const string ERROR_MESSAGE = "Debes seleccionar al menos una categoria para actualizar";

        private User ActualUser;
        private DataAccessCategory DataAccessCategory;
        public Categories( User user)
        {
            ActualUser = user;
            DataAccessCategory = new DataAccessCategory();
            InitializeComponent();
            ListInitialize();
        }

        private void categoriesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            categoriesPanel.Controls.Clear();
            UserControl system = new SystemOptions( ActualUser);
            categoriesPanel.Controls.Add(system);
        }

        private void btnAddCreditCard_Click(object sender, EventArgs e)
        {
            string name = txtCategory.Text;

            try
            {
                Category category = new Category(name);
                category.User = ActualUser;

                DataAccessCategory.Add(category);

                txtCategory.Text = "";
                listCategories.Items.Clear();
                ListInitialize();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnUpdateCreditC_Click(object sender, EventArgs e)
        {
            Category name = (Category)listCategories.SelectedItem;
            string newName = txtNewName.Text;
 
                if (name != null && name.Name != DEFAULT_CATEGORY)
                {
                    Category categoryToModify = DataAccessCategory.Get(name);
                    categoryToModify.Name = newName;
                    DataAccessCategory.Modify(categoryToModify);

                    txtNewName.Text = "";
                    listCategories.Items.Clear();
                    ListInitialize();
                }
                else
                {
                   MessageBox.Show(ERROR_MESSAGE);

                }
           
        }
        public void ListInitialize()
        {
            List<Category> categories = (List<Category>)DataAccessCategory.GetAllByUser(ActualUser);
            foreach(Category cat in categories)
            {
                listCategories.Items.Add(cat);
            }
        }

        private void listCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoriesPanel.Controls.Clear();
            ViewPasswordsShared system = new ViewPasswordsShared( ActualUser);
            categoriesPanel.Controls.Add(system);
        }
    }
}
