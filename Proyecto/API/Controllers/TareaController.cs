using Abstracciones.API;
using Abstracciones.BW;
using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase, ITareaAPI
    {
        private ITareaBW _tareaBW;

        public TareaController(ITareaBW tareaBW)
        {
            _tareaBW = tareaBW;
        }

        [HttpPost]
        public async Task<IActionResult> Agregar([FromBody] Tarea tarea)
        {
            var resultado = await _tareaBW.Agregar(tarea);
            return CreatedAtAction(nameof(Obtener), new { Id = resultado }, tarea);
        }

        [HttpPut]
        public async Task<IActionResult> Editar([FromBody]  Tarea tarea)
        {
            return Ok(await _tareaBW.Editar(tarea));
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Eliminar([FromRoute]  Guid Id)
        {
            await _tareaBW.Eliminar(Id);
            return NoContent();
        }

        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            return Ok(await _tareaBW.Obtener());
        }

        [HttpGet("{Creador}")]
        public async Task<IActionResult> ObtenerPorCreador([FromRoute] Guid Creador)
        {
            return Ok(await _tareaBW.ObtenerPorCreador(Creador));
        }
    }
}
