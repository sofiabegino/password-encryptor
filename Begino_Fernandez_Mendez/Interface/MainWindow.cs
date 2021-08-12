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
    public partial class MainWindow : Form
    {

        private DataAccessUser DataAccessUser;
        public MainWindow()
        {
            InitializeComponent();
            mainPanel.Controls.Clear();

            DataAccessUser = new DataAccessUser();
            List<User> users = (List<User>)DataAccessUser.GetAll();

            UserControl login = new Login();
            mainPanel.Controls.Add(login);
           
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        
    }
}
