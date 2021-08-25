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
    public partial class Activiteiten : Form
    {
        ActiviteitenController _Controller = new ActiviteitenController();
        public Activiteiten()
        {
            InitializeComponent();
            
        }

        private void ActiviteitenDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid Activiteit_id = Guid.Parse(ActiviteitenDataView.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (ActiviteitenDataView.Columns[e.ColumnIndex].Name == "Reseveren")
            {
                // display on the new form.
                Reseveren Reseverenform = new Reseveren(Activiteit_id);
                Reseverenform.ShowDialog();
            }
        }

        private void Activiteiten_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserRol == (int)Enums.Rolen.Gebruiker)
            {
                btn_beheer.Enabled = false;
                btn_beheer.Visible = false;
                beheerlabel.Visible = false;
            }
            foreach (var Activiteit in _Controller.GetActiviteitens())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ActiviteitenDataView);
                row.Cells[0].Value = Activiteit.Id;
                row.Cells[1].Value = Activiteit.Naam;
                row.Cells[2].Value = Activiteit.Adress;
                row.Cells[3].Value = Activiteit.Tijdslot_grote + " Minuten";
                row.Cells[4].Value = Activiteit.Start_Activiteit;
                row.Cells[5].Value = Activiteit.Eind_Activiteit;
                DataGridViewButtonCell btn_reseveren = new DataGridViewButtonCell() { Value = "Reseveren" };
                row.Cells[6] = btn_reseveren;
                ActiviteitenDataView.Rows.Add(row);
            }
        }

        private void btn_beheer_Click(object sender, EventArgs e)
        {
            ActiviteitenBeheer ActiviteitenBeheerForm = new ActiviteitenBeheer();
            ActiviteitenBeheerForm.ShowDialog();
            ActiviteitenBeheerForm.Dispose();
        }
    }
}
