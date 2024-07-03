using Abstracciones.DA;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace DA
{
    public class RepositorioDapper : IRepositorioDapper
    {

        private readonly IConfiguration _configuration;

        public RepositorioDapper(IConfiguration configuration)
        {
            _configuration = configuration;

            _conexionBaseDatos = new SqlConnection(_configuration.GetConnectionString("BDPP2"));

        }

        public SqlConnection _conexionBaseDatos { get; }

        public SqlConnection ObtenerRepositorioDapper()
        {
            return _conexionBaseDatos;
        }
    }
}
