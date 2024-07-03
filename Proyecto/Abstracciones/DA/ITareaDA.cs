using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.DA
{
    public interface ITareaDA
    {
        public Task<IEnumerable<Tarea>> Obtener();

        public Task<IEnumerable<Tarea>> ObtenerPorCreador(Guid Creador);

        public Task<Guid> Agregar(Tarea tarea);

        public Task<Guid> Editar(Tarea tarea);

        public Task<Guid> Eliminar(Guid Id);
    }
}
