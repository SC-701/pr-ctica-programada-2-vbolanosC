using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Abstracciones.Entidades
{
    public class Tarea
    {
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        public Date? FechaInicio { get; set; }

        public Date? FechaFinal { get; set; }

        public Guid Asignado { get; set; }

        public Guid Estado { get; set; }

        public Guid Creador { get; set; }
    }
}
