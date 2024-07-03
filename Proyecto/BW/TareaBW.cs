using Abstracciones.BW;
using Abstracciones.DA;
using Abstracciones.BC;
using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BW
{
    public class TareaBW : ITareaBW
    {
        private ITareaDA _tareaDA;
        private ITareaBC _tareaBC;

        public TareaBW(ITareaDA tareaDA, ITareaBC tareaBC)
        {
            _tareaDA = tareaDA;
            _tareaBC = tareaBC;
        }
        public async Task<Guid> Agregar(Abstracciones.Modelos.Tarea tarea)
        {
            var entrenadorConFormato = _tareaBC.DarFormatoDescripcion(tarea);
            return await _tareaDA.Agregar(entrenadorConFormato);
        }

        public async Task<Guid> Editar(Abstracciones.Modelos.Tarea tarea)
        {
            return await _tareaDA.Editar(tarea);
        }

        public Task<Guid> Eliminar(Guid Id)
        {
            return _tareaDA.Eliminar(Id);
        }

        public Task<IEnumerable<Tarea>> Obtener()
        {
            return _tareaDA.Obtener();
        }

        public Task<IEnumerable<Tarea>> ObtenerPorCreador(Guid Creador)
        {
            return _tareaDA.ObtenerPorCreador(Creador);
        }
    }
}
