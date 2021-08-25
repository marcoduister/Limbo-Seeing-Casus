using Limbo_Seeing.DAL;
using Limbo_Seeing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo_Seeing.BUS
{
    class ReseveringController
    {
        Limbo_SeeingContext DBContext = new Limbo_SeeingContext();

        public ICollection<Resevering> Overzicht()
        {
            ICollection<Resevering> reseveringen = DBContext.Reseverings.Include(e => e.Activiteit).Where(e =>e.Gebruiker_Id == new Guid(Properties.Settings.Default.UserId)).ToList();
            //Alert het hier bovendstaande GebruikerId moet uit Settings gehaald worden
            return reseveringen;
        }

        public bool Create(Guid Activteit_id, string Tijd)
        {
            Activiteit activiteit = DBContext.Activiteiten.AsNoTracking().First(F => F.Id == Activteit_id);
            var NewdateTime = activiteit.Start_Activiteit.Date + TimeSpan.Parse(Tijd);
            try
            {
                Resevering resevering = new Resevering
                {
                    Activiteit_Id = Activteit_id,
                    Gebruiker_Id = new Guid(Properties.Settings.Default.UserId),
                    //Alert het hier bovendstaande GebruikerId moet uit Settings gehaald worden
                    Tijdslot_Start = NewdateTime,
                    Tijdslot_Eind = NewdateTime.AddMinutes(activiteit.Tijdslot_grote)
                };
                DBContext.Reseverings.Add(resevering);
                DBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(Guid resevering_id)
        {
            try
            {
                DBContext.Reseverings.Remove(DBContext.Reseverings.First(e => e.Id == resevering_id));
                DBContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            } 
        }
    }
}
