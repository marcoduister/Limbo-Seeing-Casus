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
    public partial class ActiviteitenBeheer : Form
    {
        ActiviteitenController _Controller = new ActiviteitenController();
        ReseveringController _ReseveringController = new ReseveringController();

        public ActiviteitenBeheer()
        {
            InitializeComponent();

            StartTime.Format = EindTime.Format = DateTimePickerFormat.Time;
            StartTime.ShowUpDown = EindTime.ShowUpDown = true;
        }

        private void ActiviteitenBeheer_Load(object sender, EventArgs e)
        {

            loader();
        }

        private void loader()
        {
            Activtieten_guid.Text = "";
            Naam_TextBox.Text = "";
            Adress_TextBox.Text = "";
            Aantal_Num.Value = 0;
            Tijdslot_grote_Num.Value = 0;
            Activiteit_Datum_DateTimePicker.Value = DateTime.Now;
            StartTime.Value = DateTime.Now;
            EindTime.Value = DateTime.Now;
            ActiviteitenDataView.Rows.Clear();
            dataGridView_gebruikers.Rows.Clear();

            foreach (var Activiteit in _Controller.GetAllActiviteitenByUserID())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ActiviteitenDataView);
                row.Cells[0].Value = Activiteit.Id;
                row.Cells[1].Value = Activiteit.Naam;
                row.Cells[2].Value = Activiteit.Adress;
                row.Cells[3].Value = Activiteit.Aantal;
                row.Cells[4].Value = Activiteit.Tijdslot_grote + " Minuten";
                row.Cells[5].Value = Activiteit.Start_Activiteit;
                row.Cells[6].Value = Activiteit.Eind_Activiteit;
                ActiviteitenDataView.Rows.Add(row);
            }

        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActiviteitenDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid Activiteit_id = Guid.Parse(ActiviteitenDataView.Rows[e.RowIndex].Cells[0].Value.ToString());
            Activiteit activiteit = _Controller.GetActiviteitbyGuid(Activiteit_id);
            Activtieten_guid.Text = activiteit.Id.ToString();
            Naam_TextBox.Text = activiteit.Naam;
            Adress_TextBox.Text = activiteit.Adress;
            Aantal_Num.Value = activiteit.Aantal;
            Tijdslot_grote_Num.Value = activiteit.Tijdslot_grote;
            Activiteit_Datum_DateTimePicker.Value = activiteit.Start_Activiteit;
            StartTime.Value = activiteit.Start_Activiteit;
            EindTime.Value = activiteit.Eind_Activiteit;

            dataGridView_gebruikers.Rows.Clear();

            foreach (var Resevering in activiteit.Reseverings)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView_gebruikers);
                row.Cells[0].Value = Resevering.Id;
                row.Cells[1].Value = Resevering.Gebruiker.Voornaam;
                row.Cells[2].Value = Resevering.Gebruiker.Achternaam;
                row.Cells[3].Value = Resevering.Tijdslot_Start;
                DataGridViewButtonCell btn_verwijder = new DataGridViewButtonCell() { Value = "Verwijder" };
                row.Cells[4] = btn_verwijder;
                dataGridView_gebruikers.Rows.Add(row);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Activtieten_guid.Text != "")
            {
                _Controller.Delete(new Guid(Activtieten_guid.Text));
                loader();
            }
            else
            {
                MessageBox.Show("selecteer eerst een Activiteit voor je hem probeert te verwijderen");
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Activtieten_guid.Text != "")
            {
                if (_Controller.update(ModelConverter()))
                {
                    MessageBox.Show("Uw heeft zo juist een activteit geupdate!");
                    loader();
                }
                else
                {
                    MessageBox.Show("Er is iets fout gegaan probeer het nu of later opnieuw!!");
                }
            }
            else
            {
                MessageBox.Show("selecteer eerst een Activiteit voor je hem probeert te update!!");
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Controls.OfType<TextBox>().Any(tb => tb.Text.Length != 0))
            {
                if (_Controller.Create(ModelConverter()))
                {
                    MessageBox.Show("Uw heeft zo juist een nieuwe Activteit aan gemaakt!");
                    loader();
                }
                else
                {
                    MessageBox.Show("Er is iets fout gegaan probeer het nu of later opnieuw!!");
                }
            }
            else { MessageBox.Show("Uw moet eerst alle velden invullen voor uw iets kan Toevoegen!!"); }
        }

        private Activiteit ModelConverter()
        {

            DateTime dateTime = Activiteit_Datum_DateTimePicker.Value;
            Guid Activtieten_id = new Guid();
            var Startactivteit = dateTime.Date + TimeSpan.Parse(StartTime.Value.TimeOfDay.ToString());
            var Eindactivteit = dateTime.Date + TimeSpan.Parse(EindTime.Value.TimeOfDay.ToString());

            if (Activtieten_guid.Text != "")
            {
                Activtieten_id = new Guid(Activtieten_guid.Text);
            }

            Activiteit activteit = new Activiteit() 
            {
                Id = Activtieten_id,
                Naam = Naam_TextBox.Text,
                Adress = Adress_TextBox.Text,
                Aantal  = Convert.ToInt32(Aantal_Num.Value),
                Tijdslot_grote = Convert.ToInt32(Tijdslot_grote_Num.Value),
                Start_Activiteit = Startactivteit,
                Eind_Activiteit = Eindactivteit
            };
            return activteit;
        }

        private void dataGridView_gebruikers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid Resevering_id = Guid.Parse(dataGridView_gebruikers.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (dataGridView_gebruikers.Columns[e.ColumnIndex].Name == "Verwijder")
            {
                if (_ReseveringController.Delete(Resevering_id))
                {
                    MessageBox.Show("uw heeft zo juist een Resevering verwijderd");
                    dataGridView_gebruikers.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    MessageBox.Show("er is iets fout gegaan probeer het later nog eens opnieuw");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            loader();
        }
    }
}
