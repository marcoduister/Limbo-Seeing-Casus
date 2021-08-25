using Limbo_Seeing.BUS;
using Limbo_Seeing.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limbo_Seeing.Views
{
    public partial class MijnAccount : Form
    {
        GebruikerController gebruikerController = new GebruikerController();

        public MijnAccount()
        {
            InitializeComponent();
            NewSex.DataSource = Enum.GetValues(typeof(Enums.Geslachten));
            FillTextBox();
        }

        private void FillTextBox()
        {
            Guid UserId = Guid.Parse(Properties.Settings.Default.UserId);
            Gebruiker CurentUserData = gebruikerController.GetUserdata(UserId);

            NewEmail.Text = CurentUserData.Email;
            NewName.Text = CurentUserData.Voornaam;
            NewLastName.Text = CurentUserData.Achternaam;
            NewBirthDate.Value = CurentUserData.Geboortendatum;
            
            if (CurentUserData.Geslacht == Enums.Geslachten.Man)
            {
                NewSex.SelectedIndex = 0;
            } 
            else if (CurentUserData.Geslacht == Enums.Geslachten.Vrouw)
            {
                NewSex.SelectedIndex = 1;
            }
            else
            {
                NewSex.SelectedIndex = 2;
            }
        }

        private void SaveNewData_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gebruikerController.Update(NewEmail.Text, NewName.Text, NewLastName.Text, NewBirthDate.Value));
        }

        private void NewSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
