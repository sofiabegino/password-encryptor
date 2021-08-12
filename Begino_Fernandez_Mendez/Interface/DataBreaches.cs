using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Repositorio;

namespace Interface
{
    public partial class DataBreaches : UserControl
    {
        const string EMPTY_FILE_ERROR_MESSAGE = "Debes seleccionar un archivo para evaluar";

        private User ActualUser;
        private DataAccessCreditCard DataAccessCreditCard;
        private DataAccessPassword DataAccessPassword;
        public DataBreaches( User user)
        {
            ActualUser = user;
            DataAccessCreditCard = new DataAccessCreditCard();
            DataAccessPassword = new DataAccessPassword();

            InitializeComponent();
        }

        private void DataBreachesPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click_1(object sender, EventArgs e)
        {
            
             string[] data = richTextBoxDataBreaches.Lines;

            List<CreditCard> CreditCards = (List<CreditCard>)DataAccessCreditCard.GetAll();
            List<Password> Passwords = (List<Password>)DataAccessPassword.GetAll();

            List<CreditCard> matchingCards = new List<CreditCard>();
            List<Password> matchingPasswords = new List<Password>();

             foreach (string line in data)
             {
                 if (line.Any(x => char.IsWhiteSpace(x)))
                 {
                    string cardNumber = String.Concat(line.ToString().Where(c => !Char.IsWhiteSpace(c)));
                    if(CreditCards.Exists(x => x.Number == cardNumber))
                    {
                        CreditCard card = DataAccessCreditCard.GetByNumber(cardNumber, ActualUser);
                        matchingCards.Add(card);
                    }
                }
                else
                {
                    if(Passwords.Exists(x => x.Pass == line.ToString()))
                    {
                        Password password = DataAccessPassword.GetByPassword(line.ToString(), ActualUser);
                        matchingPasswords.Add(password);
                    }
                }
                    
            }
            DataBreachesPanel.Controls.Clear();
            UserControl result = new ResultDataBreaches(ActualUser, matchingPasswords, matchingCards);
            DataBreachesPanel.Controls.Add(result);
        }

        private void btnVolverDB_Click_1(object sender, EventArgs e)
        {
            DataBreachesPanel.Controls.Clear();
            UserControl system = new SystemOptions( ActualUser);
            DataBreachesPanel.Controls.Add(system);
        }

        private void btnHistorialDB_Click(object sender, EventArgs e)
        {
            DataBreachesPanel.Controls.Clear();
            UserControl DataBreahcesHistory = new DataBreachesHistory( ActualUser);
            DataBreachesPanel.Controls.Add(DataBreahcesHistory);
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            String fileContent = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                textBoxFile.Text = openFileDialog1.FileName;
            }

            var file = openFileDialog1.OpenFile();

             using (StreamReader reader = new StreamReader(file))
            {
                fileContent = reader.ReadToEnd();
            }

            if (fileContent != "")
            {
                char toDivide = (char)9;

                String[] data = fileContent.Split(toDivide);

                List<CreditCard> CreditCards = (List<CreditCard>)DataAccessCreditCard.GetAllByUser(ActualUser);
                List<Password> Passwords = (List<Password>)DataAccessPassword.GetAllByUser(ActualUser);

                List<CreditCard> matchingCards = new List<CreditCard>();
                List<Password> matchingPasswords = new List<Password>();

                foreach (var line in data)
                {
                    if (line.Any(x => char.IsWhiteSpace(x)))
                    {
                        string cardNumber = String.Concat(line.ToString().Where(c => !Char.IsWhiteSpace(c)));
                        if (CreditCards.Exists(x => x.Number == cardNumber))
                        {
                            CreditCard card = DataAccessCreditCard.GetByNumber(cardNumber, ActualUser);
                            matchingCards.Add(card);
                        }
                    }
                    else
                    {
                        if (Passwords.Exists(x => x.Pass == line.ToString()))
                        {
                            Password password = DataAccessPassword.GetByPassword(line.ToString(), ActualUser);
                            matchingPasswords.Add(password);
                        }
                    }
                }
                DataBreachesPanel.Controls.Clear();
                UserControl result = new ResultDataBreaches( ActualUser, matchingPasswords, matchingCards);
                DataBreachesPanel.Controls.Add(result);
            }
            else
            {
                MessageBox.Show(EMPTY_FILE_ERROR_MESSAGE);
            }
        }
    }
}
