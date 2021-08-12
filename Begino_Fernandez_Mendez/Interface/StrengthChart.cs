using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Dominio;
using Repositorio;

namespace Interface
{
    public partial class StrengthChart : UserControl
    {
        const string RED = "rojo";
        const string ORANGE = "naranja";
        const string YELLOW = "amarillo";
        const string LIGHT_GREEN = "verde claro";
        const string GREEN = "verde";

        private User ActualUser;
        private DataAccessCategory DataAccessCategory;
        private DataAccessPassword DataAccessPassword;
        public StrengthChart( User user)
        {
            ActualUser = user;
            DataAccessCategory = new DataAccessCategory();
            DataAccessPassword = new DataAccessPassword();

            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

            Series green = chart1.Series.Add(GREEN);
            Series lightGreen = chart1.Series.Add(LIGHT_GREEN);
            Series orange = chart1.Series.Add(ORANGE);
            Series yellow = chart1.Series.Add(YELLOW);
            Series red = chart1.Series.Add(RED);

            green.Color = Color.Green;
            lightGreen.Color = Color.LightGreen;
            orange.Color = Color.Orange;
            yellow.Color = Color.Yellow;
            red.Color = Color.Red;

            List<Category> categories = (List<Category>)DataAccessCategory.GetAllByUser(ActualUser);

            foreach (Category selectedCategory in categories)
            {
                green.Points.AddXY(selectedCategory.Name, DataAccessPassword.CountByStrength(selectedCategory, Dominio.Password.ColorStrength.Green));
                lightGreen.Points.AddXY(selectedCategory.Name, DataAccessPassword.CountByStrength(selectedCategory, Dominio.Password.ColorStrength.LightGreen));
                orange.Points.AddXY(selectedCategory.Name, DataAccessPassword.CountByStrength(selectedCategory, Dominio.Password.ColorStrength.Orange) );
                yellow.Points.AddXY(selectedCategory.Name, DataAccessPassword.CountByStrength(selectedCategory, Dominio.Password.ColorStrength.Yellow));
                red.Points.AddXY(selectedCategory.Name, DataAccessPassword.CountByStrength(selectedCategory, Dominio.Password.ColorStrength.Red) );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelChart.Controls.Clear();
            UserControl system = new SystemOptions( ActualUser);
            panelChart.Controls.Add(system);
        }
    }
}
