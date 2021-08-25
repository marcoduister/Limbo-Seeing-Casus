using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Limbo_Seeing.Models.Enums;

namespace Limbo_Seeing.Models
{
    class Sensors
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Locatie { get; set; }
        public int Battery { get; set; }
        public SensorType SensorType { get; set; }
        public virtual ICollection<Sensors_Acties> Sensors_Acties { get; set; }
    }
}
