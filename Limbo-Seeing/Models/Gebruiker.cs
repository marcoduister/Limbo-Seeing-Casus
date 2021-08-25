
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using static Limbo_Seeing.Models.Enums;

namespace Limbo_Seeing.Models
{
    class Gebruiker
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [EmailAddress]
        [MinLength(6)]
        public string Email { get; set; }
        [MinLength(6)]
        public string Wachtwoord { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public DateTime Geboortendatum { get; set; }
        public Geslachten Geslacht { get; set; }
        public Rolen Rol { get; set; }
        public bool UserActive { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ICollection<Resevering> Reseverings { get; set; }
        public virtual ICollection<Activiteit> Activiteitens { get; set; }
    }
}
