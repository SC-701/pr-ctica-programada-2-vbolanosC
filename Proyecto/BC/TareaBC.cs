using Abstracciones.BC;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC
{
    public class TareaBC : ITareaBC
    {
        public Tarea DarFormatoDescripcion(Tarea tarea)
        {
            if (string.IsNullOrEmpty(tarea.Descripcion))
            {
                throw new ArgumentException("La descripción no puede estar vacía.");
            }

            // Convertir la descripción a minúsculas
            string lowerCaseDescripcion = tarea.Descripcion.ToLower();

            // Colocar la primera letra en mayúscula
            string formattedDescripcion = char.ToUpper(lowerCaseDescripcion[0]) + lowerCaseDescripcion.Substring(1);

            // Asignar la descripción formateada a la tarea
            tarea.Descripcion = formattedDescripcion;

            return tarea;
        }
    }
}
