using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Limbo_Seeing.BUS;
using Limbo_Seeing.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.ToolTips;

namespace Limbo_Seeing.Views
{
    public partial class MainBase : Form
    {
        private GebruikerController _GebruikerController = new GebruikerController();
        private SensorController _SensorController = new SensorController();
        private ActiviteitenController _ActiviteitenController = new ActiviteitenController();

        public MainBase()
        {
            InitializeComponent();

            if (Properties.Settings.Default.UserRol == (int)Enums.Rolen.Gebruiker)
            {
                AllUsers.Enabled = false;
                AllUsers.Visible = false;
                AllUsers.Visible = false;
            }
        }

        private void btn_uitloggen_Click(object sender, EventArgs e)
        {
            _GebruikerController.Uitloggen();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            MijnAccount AccountForm = new MijnAccount();
            AccountForm.ShowDialog();
            AccountForm.Dispose();
        }

        private void btn_Activiteiten_Click(object sender, EventArgs e)
        {
            Activiteiten ActiviteitForm = new Activiteiten();
            ActiviteitForm.ShowDialog();
            ActiviteitForm.Dispose();
        }

        private void btn_Mijn_Reseveringen_Click(object sender, EventArgs e)
        {
            MijnReseveringen MijnReseveringenForm = new MijnReseveringen();
            MijnReseveringenForm.ShowDialog();
            MijnReseveringenForm.Dispose();
        }
        
        private void PushMelding_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PushMelding == false)
            {
                Properties.Settings.Default["PushMelding"] = true;
                MessageBox.Show("Push meldingen aan gezet");
            }
            else
            {
                Properties.Settings.Default["PushMelding"] = false;
                MessageBox.Show("Push meldingen uit gezet");
            }
         }
         
        private void MainBase_Load(object sender, EventArgs e)
        {
            gMapControl.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl.Position = new GMap.NET.PointLatLng(50.864278, 5.831776);
            gMapControl.ShowCenter = false;

            foreach (var item in _SensorController.GetAllSensorData())
            {
                GMapOverlay polyOverlay = new GMapOverlay("polygons");
                gMapControl.Overlays.Add(polyOverlay);
                polyOverlay.Polygons.Add(_SensorController.GenerateRadius(item.Locatie, item.Id));

            }
            foreach (var item in _ActiviteitenController.GetActiviteitens().Where(q=>q.Start_Activiteit.Day == DateTime.Today.Day ))
            {
                
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(Activteiten_datagrid);
                row.Cells[0].Value = item.Naam;
                row.Cells[1].Value = item.Adress;
                row.Cells[2].Value = item.Reseverings.Count();

                Activteiten_datagrid.Rows.Add(row);
            }
        }

        private void AllUsers_Click(object sender, EventArgs e)
        {
            AllUsers AllUsersForm = new AllUsers();
            AllUsersForm.ShowDialog();
            AllUsersForm.Dispose();
        }
    }
}
