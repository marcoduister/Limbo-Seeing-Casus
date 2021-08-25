using Limbo_Seeing.BUS;
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
    public partial class MijnReseveringen : Form
    {
        ReseveringController _Controller = new ReseveringController();
        public MijnReseveringen()
        {
            InitializeComponent();
        }

        private void MijnReseveringen_Load(object sender, EventArgs e)
        {
            foreach (var resevering in _Controller.Overzicht())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Reseveringen_dataGridView);
                row.Cells[0].Value = resevering.Id;
                row.Cells[1].Value = resevering.Activiteit.Naam;
                row.Cells[2].Value = resevering.Activiteit.Adress;
                row.Cells[3].Value = resevering.Tijdslot_Start;
                row.Cells[4].Value = resevering.Tijdslot_Eind;
                DataGridViewButtonCell btn_QRcode = new DataGridViewButtonCell() { Value = "QRcode" };
                row.Cells[5] = btn_QRcode;
                DataGridViewButtonCell btn_Verwijderen = new DataGridViewButtonCell() { Value = "Verwijderen" };
                row.Cells[6] = btn_Verwijderen;
                Reseveringen_dataGridView.Rows.Add(row);
            }
        }

        private void Reseveringen_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid Resevering_id = Guid.Parse(Reseveringen_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (Reseveringen_dataGridView.Columns[e.ColumnIndex].Name == "Verwijder")
            {
                if (_Controller.Delete(Resevering_id))
                {
                    MessageBox.Show("uw heeft zo juist een Resevering verwijderd");
                    Reseveringen_dataGridView.Rows.RemoveAt(e.RowIndex);
                }
                else
                {
                    MessageBox.Show("er is iets fout gegaan probeer het later nog eens opnieuw");
                }
            }
            if(Reseveringen_dataGridView.Columns[e.ColumnIndex].Name == "QRcode")
            {
                QRCode QRcodeFrom = new QRCode( Resevering_id);
                QRcodeFrom.ShowDialog();
                QRcodeFrom.Dispose();

            }
        }
    }
}
