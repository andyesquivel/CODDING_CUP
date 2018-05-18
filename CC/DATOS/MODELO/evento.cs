using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.Modelo
{
    public class evento
    {
        public int idRegistroEvento { get; set; }

        public string nombreEvento {get; set; }

        public string horaInicio { get; set; }

        public string horaFin { get; set; }

        public string nombreEquipo { get; set; }

        public string fecha { get; set; }

        public char asistencia { get; set; }

        public int lugaresDisponibles { get; set; }


    }
}
