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
    public partial class DataBreachesHistory : UserControl
    {
        const string ERROR_MESSAGE = "Debe seleccionar al menos un elemento";

         private User ActualUser;
         private DataAccessDataBreaches DataAccessDataBreaches;
         private DataAccessPassword DataAccessPassword;
        public DataBreachesHistory( User user)
        {
            ActualUser = user;
            DataAccessDataBreaches = new DataAccessDataBreaches();
            DataAccessPassword = new DataAccessPassword();
            InitializeComponent();
            listInitialize();
        }

        private void listInitialize()
        {
            List<DataBreachesResult> dataBreaches = (List<DataBreachesResult>)DataAccessDataBreaches.GetAllByUser(ActualUser);

            dataBreaches.Sort((x, y) => x.Date.CompareTo(y.Date));
            listDBHistory.Items.Clear();
            foreach (DataBreachesResult selectedData in dataBreaches)
            {
                    var row1 = new string[] { selectedData.Date.ToString(), selectedData.Time.ToString() };
                    var lvi1 = new ListViewItem(row1);
                    lvi1.Tag = selectedData;
                    listDBHistory.Items.Add(lvi1);
            }
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (DataBreachesResult)listDBHistory.SelectedItems[0].Tag;
                if (selectedItem != null )
                {
                    DataBreachesResult data = (DataBreachesResult)selectedItem;

                    dataBreachesHistoryPanel.Controls.Clear();
                    UserControl view = new ViewDataBreach( ActualUser, data);
                    dataBreachesHistoryPanel.Controls.Add(view);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(ERROR_MESSAGE);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            dataBreachesHistoryPanel.Controls.Clear();
            UserControl SystemOptions = new SystemOptions(ActualUser);
            dataBreachesHistoryPanel.Controls.Add(SystemOptions);
        }

        private void listDBHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
