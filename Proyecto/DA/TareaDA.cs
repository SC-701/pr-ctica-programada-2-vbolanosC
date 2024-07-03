using Abstracciones.DA;
using Abstracciones.Modelos;
using Helpers;
using Dapper;
using Microsoft.Data.SqlClient;

namespace DA
{
    public class TareaDA : ITareaDA
    {
        private IRepositorioDapper _repositorioDapper;
        private SqlConnection _sqlConnection;

        public TareaDA(IRepositorioDapper repositorioDapper)
        {
            _repositorioDapper = repositorioDapper;
            _sqlConnection = _repositorioDapper.ObtenerRepositorioDapper();
        }

        public async Task<Guid> Agregar(Tarea tarea)
        {
            string sql = @"CrearTarea";
            await _sqlConnection.QueryAsync<Abstracciones.Entidades.Tarea>(sql, new { Id = tarea.Id, Nombre = tarea.Nombre, Descripcion = tarea.Descripcion, FechaInicio = tarea.FechaInicio, FechaFinal = tarea.FechaFinal, Asignado = tarea.Asignado, Estado = tarea.Estado, Creador = tarea.Creador });
            return tarea.Id;
        }

        public async Task<Guid> Editar(Tarea tarea)
        {
            string sql = @"ActualizarTarea";
            await _sqlConnection.QueryAsync<Abstracciones.Entidades.Tarea>(sql, new { Id = tarea.Id, Nombre = tarea.Nombre, Descripcion = tarea.Descripcion, FechaInicio = tarea.FechaInicio, FechaFinal = tarea.FechaFinal, Asignado = tarea.Asignado, Estado = tarea.Estado, Creador = tarea.Creador });
            return tarea.Id;
        }

        public async Task<Guid> Eliminar(Guid Id)
        {
            string sql = @"EliminarTarea";
            await _sqlConnection.QueryAsync<Abstracciones.Entidades.Tarea>(sql, new { Id = Id });
            return Id;
        }

        public async Task<IEnumerable<Abstracciones.Modelos.Tarea>> Obtener()
        {
            string sql = @"ListarTareas";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Tarea>(sql);
            if (!resultadoConsulta.Any())
                return null;
            return ConvertirTareasAModelo(resultadoConsulta);
        }

        public async Task<IEnumerable<Tarea>> ObtenerPorCreador(Guid Creador)
        {
            string sql = @"ListarTareasPorCreador";
            var resultadoConsulta = await _sqlConnection.QueryAsync<Abstracciones.Entidades.Tarea>(sql, new {Creador = Creador});
            if (!resultadoConsulta.Any())
                return null;
            return ConvertirTareasAModelo(resultadoConsulta);
        }


        #region Convertidores
        private IEnumerable<Abstracciones.Modelos.Tarea> ConvertirTareasAModelo(IEnumerable<Abstracciones.Entidades.Tarea> tarea)
        {
            var resultadoConversion = Convertidor.ConvertirLista<Abstracciones.Entidades.Tarea, Abstracciones.Modelos.Tarea>(tarea);
            return resultadoConversion;
        }
        #endregion
    }
}
