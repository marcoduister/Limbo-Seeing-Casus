using Limbo_Seeing.DAL;
using Limbo_Seeing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace Limbo_Seeing.BUS
{
    class GebruikerController
    {
         Limbo_SeeingContext DBContext = new Limbo_SeeingContext();

        public bool Login(string Email, string Wachtwoord)
        {
            bool login = Valideergebruiker(new Gebruiker { Email = Email, Wachtwoord = Wachtwoord });

            if (login)
            {
                Gebruiker curentUser = GetUserId(Email);
                Properties.Settings.Default["UserId"] = curentUser.Id.ToString();
                Properties.Settings.Default["UserRol"] = (int)curentUser.Rol;
                Properties.Settings.Default.Save();
            }

            return login;
        }

        internal void Uitloggen()
        {
            foreach (Form fm in Application.OpenForms)
            {
                if (fm.Name != "StartBase")
                {
                    fm.Close();
                    Properties.Settings.Default["UserId"] = "";
                    Properties.Settings.Default["UserRol"] = 0;
                    Properties.Settings.Default.Save();
                }
            }
        }

        internal string Registration(string Voornaam, string Achternaam, int Geslacht, DateTime GeboorteDatum, string Email, string Wachtwoord, string WachtwoordConfirm)
        {
            if (CheckGebruikerByEmail(Email))
            {
                return "dit email is al in gebruikt contacteer een Beheerder!! of Gebruik anderen Email";
            }
            else
            {
                if (Regex.IsMatch(Email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                {
                    if (Wachtwoord == WachtwoordConfirm)
                    {
                        if (Wachtwoord.Length >= 8)
                        {
                            int IsupperCounter = 0;

                            for (int i = 0; i < Wachtwoord.Length; i++)
                            {
                                if (char.IsUpper(Wachtwoord[i])) IsupperCounter++;
                            }
                            if (IsupperCounter >= 1)
                            {
                                if (Wachtwoord.Any(char.IsDigit))
                                {
                                    Gebruiker gebruiker = new Gebruiker();
                                    if (Geslacht == 0)
                                        gebruiker.Geslacht = Enums.Geslachten.Man;
                                    else
                                        gebruiker.Geslacht = Enums.Geslachten.Vrouw;
                                    gebruiker.Email = Email;
                                    gebruiker.Wachtwoord = Wachtwoord;      //Wachtwoord hash TODO 
                                    gebruiker.Voornaam = Voornaam;
                                    gebruiker.Achternaam = Achternaam;
                                    gebruiker.Geboortendatum = GeboorteDatum;
                                    gebruiker.Rol = 0;
                                    DBContext.Gebruikers.Add(gebruiker);
                                    DBContext.SaveChanges();
                                    return "de Gebruiker is aan gemaakt ga naar login pagina";
                                }
                                else
                                {
                                    return "Wachtwoord moet minimaal 1 Nummer bevaten";
                                }
                            }
                            else
                            {
                                return "Wachtwoord moet minimaal 1 Hooftletter bevaten";
                            }

                        }
                        else
                        {
                            return "Wachtwoord is niet lang genoeg";
                        }
                    }
                    else
                    {
                        return "Conferm wachtwoord klopt niet!!";
                    }
                }
                else
                {
                    return "Geen geldige email!!";
                }
            }
        }

        internal string Update(string NewEmail, string NewName, string NewLastName, DateTime NewBirthDate)
        {
            Guid UserId = Guid.Parse(Properties.Settings.Default.UserId);
            Gebruiker CurentUserData = GetUserdata(UserId);

            CurentUserData.Email = NewEmail;
            CurentUserData.Voornaam = NewName;
            CurentUserData.Achternaam = NewLastName;
            CurentUserData.Geboortendatum = NewBirthDate;
            CurentUserData.UpdatedOn = DateTime.Now;

            DBContext.Gebruikers.Add(CurentUserData);
            DBContext.Entry(CurentUserData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            DBContext.SaveChanges();

            return "gegevens opgeslagen";
        }
        public bool Valideergebruiker(Gebruiker gebruiker)
        {
            return DBContext.Gebruikers.Any(e => e.Email == gebruiker.Email && e.Wachtwoord == gebruiker.Wachtwoord);
        }

        internal bool CheckGebruikerByEmail(string Gebruiker)
        {
            return DBContext.Gebruikers.Any(e => e.Email == Gebruiker);
        }

        internal Gebruiker GetUserId(string Email)
        {
            return DBContext.Gebruikers.First(e => e.Email == Email);
        }

        internal Gebruiker GetUserdata(Guid UserId)
        {
            return DBContext.Gebruikers.First(e => e.Id == UserId);
        }

        internal ICollection<Gebruiker> GetAllUsers()
        {
            return DBContext.Gebruikers.ToList();
        }
        internal void DeleteUsers(Guid id)
        {
            DBContext.Remove(DBContext.Reseverings.First(e => e.Gebruiker_Id == id));
            var activiteiten = DBContext.Activiteiten.Where(e => e.Gebruiker_Id == id).ToList();
            foreach (var item in activiteiten)
            {
                if (item.Gebruiker_Id == id)
                {
                    DBContext.Remove(DBContext.Reseverings.First(e => e.Activiteit_Id == item.Id));
                }
            }
            DBContext.RemoveRange(DBContext.Activiteiten.Where(e => e.Gebruiker_Id == id).ToList());
            DBContext.Remove(DBContext.Gebruikers.First(F => F.Id == id));
            DBContext.SaveChanges();
        }
    }
}
