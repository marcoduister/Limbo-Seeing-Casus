using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo_Seeing.Models
{
    class Activiteit
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Naam { get; set; }
        public string Adress { get; set; }
        public int Aantal { get; set; }
        public int Tijdslot_grote { get; set; }
        public DateTime Start_Activiteit { get; set; }
        public DateTime Eind_Activiteit { get; set; }
        public Guid Gebruiker_Id { get; set; }
        public virtual Gebruiker Gebruiker { get; set; }
        public virtual ICollection<Resevering> Reseverings { get; set; }
        
    }
}
