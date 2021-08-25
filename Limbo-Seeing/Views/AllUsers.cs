using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limbo_Seeing.BUS;

namespace Limbo_Seeing.Views
{
    public partial class AllUsers : Form
    {
        public AllUsers()
        {
            InitializeComponent();
            AllUsers_Load();
        }

        private void AllUsers_Load()
        {
            GebruikerController gebruikerController = new GebruikerController();
            var users = gebruikerController.GetAllUsers();

            foreach(var user in users)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                row.Cells[0].Value = user.Id;
                row.Cells[1].Value = user.Email;
                row.Cells[2].Value = user.Voornaam;
                row.Cells[3].Value = user.Achternaam;
                row.Cells[4].Value = user.Rol;

                dataGridView1.Rows.Add(row);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Guid User_id = Guid.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            // display on the new form.
            EditAccount EditAccountForm = new EditAccount(User_id);
            EditAccountForm.ShowDialog();
            
        }
    }
}
