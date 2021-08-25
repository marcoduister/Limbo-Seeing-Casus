using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Limbo_Seeing.Models.Enums;

namespace Limbo_Seeing.Models
{
    class Sensors_Acties
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid Sensor_Id { get; set; }
        public int Aantal_bewegingen { get; set; }
        public DateTime Tijd { get; set; }
        public Beweging Soort_beweging { get; set; }
        public int Snelheid { get; set; }
        public virtual Sensors Sensors { get; set; }
    }
}
