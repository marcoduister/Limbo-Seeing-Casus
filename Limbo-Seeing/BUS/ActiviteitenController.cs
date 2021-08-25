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
    class ActiviteitenController
    {
        Limbo_SeeingContext DBContext = new Limbo_SeeingContext();

        public ICollection<Activiteit> GetActiviteitens()
        {
            return DBContext.Activiteiten.Include(e=>e.Reseverings).AsNoTracking().ToList();
        }
        public ICollection<Activiteit> GetAllActiviteitenByUserID()
        {
            return DBContext.Activiteiten.AsNoTracking().Where(W => W.Gebruiker_Id == new Guid(Properties.Settings.Default.UserId)).ToList();
            //Alert het hier bovendstaande GebruikerId moet uit Settings gehaald worden
        }
        public Activiteit GetActiviteitbyGuid(Guid Id)
        {
            return DBContext.Activiteiten.AsNoTracking().Include(e =>e.Reseverings).ThenInclude(e=>e.Gebruiker).AsNoTracking().First(F => F.Id == Id);
        }
        public bool Create(Activiteit activiteit)
        {
            try
            {
                activiteit.Gebruiker_Id = new Guid(Properties.Settings.Default.UserId);
                //Alert het hier bovendstaande GebruikerId moet uit Settings gehaald worden
                DBContext.Activiteiten.Add(activiteit);
                DBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool Delete(Guid Activtieten_id)
        {
            Activiteit activiteit = DBContext.Activiteiten.AsNoTracking().Include(e => e.Reseverings).First(e => e.Id == Activtieten_id);
            DBContext.Activiteiten.Remove(activiteit);
            DBContext.SaveChanges();
            return true;
        }
        public bool update(Activiteit activiteit)
        {
            try
            {
                activiteit.Gebruiker_Id = GetActiviteitbyGuid(activiteit.Id).Gebruiker_Id;
                DBContext.Activiteiten.Update(activiteit);
                DBContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
