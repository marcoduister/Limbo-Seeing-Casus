using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Limbo_Seeing.Models;
using Microsoft.EntityFrameworkCore;

namespace Limbo_Seeing.DAL
{
    class Limbo_SeeingContext : DbContext
    {
        public DbSet<Gebruiker> Gebruikers { get; set; }
        public DbSet<Activiteit> Activiteiten { get; set; }
        public DbSet<Resevering> Reseverings { get; set; }
        public DbSet<Sensors> Sensoren { get; set; }
        public DbSet<Sensors_Acties> Sensors_Acties { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
                    => options.UseSqlServer("server=.;database=Limbo_Seeing_DEV;trusted_connection=true;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resevering>().HasOne(p => p.Gebruiker).WithMany(M => M.Reseverings).HasForeignKey(F => F.Gebruiker_Id).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Activiteit>().HasOne(p => p.Gebruiker).WithMany(M => M.Activiteitens).HasForeignKey(F => F.Gebruiker_Id);
            modelBuilder.Entity<Activiteit>().HasMany(M => M.Reseverings).WithOne(O => O.Activiteit).HasForeignKey(F => F.Activiteit_Id);
            modelBuilder.Entity<Sensors>().HasMany(M => M.Sensors_Acties).WithOne(O => O.Sensors).HasForeignKey(F => F.Sensor_Id);
          
        }

    }
}
