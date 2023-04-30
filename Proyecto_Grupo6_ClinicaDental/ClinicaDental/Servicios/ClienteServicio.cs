using ClinicaDental.Interfaces;
using Datos.Interfaces;
using Modelos;


namespace ClinicaDental.Servicios
{
	public class ClienteServicio: IClienteServicio
	{
		private readonly Config _configuracion;
		private IClienteRepositorio clienteRepositorio;

		public ClienteServicio(Config config)
		{
			_configuracion = config;
			clienteRepositorio = new ClienteRepositorio(config.CadenaConexion);
		}

		public async Task<bool> Actualizar(Cliente cliente)
		{
			return await clienteRepositorio.Actualizar(cliente);
		}

		public async Task<bool> Eliminar(string identidadcliente)
		{
			return await clienteRepositorio.Eliminar(identidadcliente);
		}

		public async Task<IEnumerable<Cliente>> GetLista()
		{
			return await clienteRepositorio.GetLista();
		}

		public async Task<Cliente> GetPorCodigo(string identidadcliente)
		{
			return await clienteRepositorio.GetPorCodigo(identidadcliente);
		}

		public async Task<bool> Nuevo(Cliente cliente)
		{
			return await clienteRepositorio.Nuevo(cliente);
		}
	}
}
