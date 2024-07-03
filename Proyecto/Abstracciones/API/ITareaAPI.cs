using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.API
{
    public interface ITareaAPI
    {
        [HttpGet]
        public Task<IActionResult> Obtener();

        [HttpGet]
        public Task<IActionResult> ObtenerPorCreador(Guid Creador);

        [HttpPost]
        public Task<IActionResult> Agregar(Tarea tarea);

        [HttpPut]
        public Task<IActionResult> Editar(Tarea tarea);

        [HttpDelete]
        public Task<IActionResult> Eliminar(Guid Id);
    }
}
