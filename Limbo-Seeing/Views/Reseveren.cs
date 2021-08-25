using Limbo_Seeing.BUS;
using System;
using Limbo_Seeing.Models;
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
    public partial class Reseveren : Form
    {

        ActiviteitenController activiteitenController = new ActiviteitenController();
        ReseveringController ReseveringController = new ReseveringController();
        private Guid _Activiteit_id;

        public Reseveren(Guid Activiteit_id)
        {
            InitializeComponent();
            _Activiteit_id = Activiteit_id;
            

            Activiteit activiteit = activiteitenController.GetActiviteitbyGuid(Activiteit_id);

            activteit_actie_label.Text = activiteit.Naam;
            var item = activiteit.Start_Activiteit;
            while (item <= activiteit.Eind_Activiteit)
            {
                
                if (activiteit.Eind_Activiteit == item )
                {
                    if (activiteit.Tijdslot_grote >= 0)
                    {
                        if (activiteit.Reseverings.Count(e => e.Tijdslot_Start == item) != activiteit.Aantal)
                        {
                            CBox_tijdslots.Items.Add(item.TimeOfDay.ToString(@"hh\:mm"));
                        }
                        item = item.AddMinutes(30);
                    }
                }
                else
                {
                    if (activiteit.Reseverings.Count(e => e.Tijdslot_Start == item) != activiteit.Aantal)
                    {
                        CBox_tijdslots.Items.Add(item.TimeOfDay.ToString(@"hh\:mm"));
                    }
                    item = item.AddMinutes(activiteit.Tijdslot_grote);
                }
            }
        }

        private void btn_reseveren_Click(object sender, EventArgs e)
        {
            if(ReseveringController.Create(_Activiteit_id, CBox_tijdslots.SelectedItem.ToString()))
            {
                MessageBox.Show("er is een resevering gemaakt om "+ CBox_tijdslots.SelectedItem.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("er is iets fout gegaan met de resevering probeer het op nieuw of probeer een anderen tijd!");
            }
        }

        private void btn_terug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
