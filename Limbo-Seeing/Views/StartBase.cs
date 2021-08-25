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
    public partial class StartBase : Form
    {
        private GebruikerController _GebruikerController = new GebruikerController();
        public  StartBase()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //check username password
            if (_GebruikerController.Login(Email_Textbox.Text, Password_Texbox.Text))
            {
                this.Hide();
                MainBase mainBase = new MainBase();
                mainBase.ShowDialog();
                mainBase.Dispose(); 
                this.Show();
                this.Email_Textbox.Text = "";
                this.Password_Texbox.Text = "";

                
            }
            else
            {
                MessageBox.Show("Gegevens zijn fout!!! probeer op nieuw");
            }
        }

        private void btn_Registratie_Click(object sender, EventArgs e)
        {
            bool allfieldsempty = false;

            if (this.tabPage3.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                allfieldsempty = true;
            if (this.tabPage3.Controls.OfType<DateTimePicker>().Any(t => string.IsNullOrEmpty(t.Text)))
                allfieldsempty = true;
            if (this.tabPage3.Controls.OfType<ComboBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                allfieldsempty = true;
            if (allfieldsempty != true)
            {
                MessageBox.Show(_GebruikerController.Registration(Reg_Voornaam_textBox.Text, Reg_Achternaam_textBox.Text, Reg_Geslacht_ComboBox.SelectedIndex,Reg_GeboorteDatum_Picker.Value,Reg_Email_textBox.Text, Reg_Wachtwoord_textBox.Text, Reg_wachtwoordConfurm_textBox.Text));
            }
            else
            {
                MessageBox.Show("controleer je gegevens nog eens!!");
            }
        }

        private void StartBase_tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
