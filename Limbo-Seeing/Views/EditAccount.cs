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
    public partial class EditAccount : Form
    {
        GebruikerController gebruikerController = new GebruikerController();
        Guid UserId;
        public EditAccount(Guid Id)
        {
            UserId = Id;

            InitializeComponent();
            NewSex.DataSource = Enum.GetValues(typeof(Enums.Geslachten));
            NewRol.DataSource = Enum.GetValues(typeof(Enums.Rolen));
            FillTextBox();
        }

        private void FillTextBox()
        {
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

            if (CurentUserData.Rol == Enums.Rolen.Gebruiker)
            {
                NewRol.SelectedIndex = 0;
            }
            else if (CurentUserData.Rol == Enums.Rolen.ActiviteitenManager)
            {
                NewRol.SelectedIndex = 1;
            }
            else
            {
                NewRol.SelectedIndex = 2;
            }
        }

        private void SaveNewData_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gebruikerController.Update(NewEmail.Text, NewName.Text, NewLastName.Text, NewBirthDate.Value));
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            gebruikerController.DeleteUsers(UserId);
        }
    }
}
