using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo_Seeing.Models
{
    class Resevering
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime Tijdslot_Start { get; set; }
        public DateTime Tijdslot_Eind { get; set; }

        public Guid Gebruiker_Id { get; set; }
        public virtual Gebruiker Gebruiker { get; set; }

        public Guid Activiteit_Id { get; set; }
        public virtual Activiteit Activiteit { get; set; }
    }
}
