using GMap.NET;
using GMap.NET.WindowsForms;
using Limbo_Seeing.DAL;
using Limbo_Seeing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo_Seeing.BUS
{
    class SensorController
    {
        Limbo_SeeingContext DBContext = new Limbo_SeeingContext();

        public ICollection<Sensors> GetAllSensorData()
        {
            return DBContext.Sensoren.Include(e=>e.Sensors_Acties).ToList();
        }
        public ICollection<Sensors_Acties> GetAllSensorDatabyID(Guid id)
        {
            return DBContext.Sensors_Acties.Where(e => e.Sensor_Id == id && e.Tijd >= DateTime.Now.AddHours(-1)).ToList();
        }

        public GMapPolygon GenerateRadius(string pointLocation, Guid Id)
        {
            ICollection<Sensors_Acties> Acties = GetAllSensorDatabyID(Id);
            double Lat = double.Parse(pointLocation.Split(',')[0].Replace('.', ','));
            double Ing = double.Parse(pointLocation.Split(',')[1].Replace('.', ','));
            PointLatLng point = new PointLatLng(Lat, Ing);
            double radius = 0.0005;
            int segments = 75;

            List<PointLatLng> gpollist = new List<PointLatLng>();

            double seg = Math.PI * 2 / segments;

            for (int i = 0; i < segments; i++)
            {
                double theta = seg * i;
                double a = point.Lat + Math.Cos(theta) * radius;
                double b = point.Lng + Math.Sin(theta) * radius;

                PointLatLng gpoi = new PointLatLng(a, b);

                gpollist.Add(gpoi);
            }
            Random rnd = new Random();
            GMapPolygon gpol = new GMapPolygon(gpollist, "pol" + rnd.Next());

            if (Acties.Count() >= 50)
            {
                gpol.Fill = new SolidBrush(Color.FromArgb(80, Color.Red));
                gpol.Stroke = new Pen(Color.Red, 1);
            }
            else if (Acties.Count() >= 10)
            {
                gpol.Fill = new SolidBrush(Color.FromArgb(80, Color.Blue));
                gpol.Stroke = new Pen(Color.Blue, 1);
            }
            else if (Acties.Count() >= 5)
            {
                gpol.Fill = new SolidBrush(Color.FromArgb(80, Color.Yellow));
                gpol.Stroke = new Pen(Color.Yellow, 1);
            }
            else
            {
                gpol.Fill = new SolidBrush(Color.FromArgb(50, Color.Transparent));
                gpol.Stroke = new Pen(Color.Transparent, 1);
            }
            return gpol;
        }
    }
}
