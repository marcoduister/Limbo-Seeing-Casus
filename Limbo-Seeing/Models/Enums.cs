using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limbo_Seeing.Models
{
    class Enums
    {
        public enum Rolen
        {
            Gebruiker,
            ActiviteitenManager,
            Beheerder
        }
        public enum Geslachten
        {
            Man,
            Vrouw,
            Nonbinary
        }
        public enum Beweging
        {
            Wandelaar,
            Fietser
        }
        public enum SensorType
        {
            infra,
            Motion,
            Water,
            Parking
        }
    }
}
