using Modelos;

namespace ClinicaDental.Interfaces
{
	public interface IServicio
	{

		Task<bool> Nuevo(Servicio habitacion);
		Task<bool> Actualizar(Servicio habitacion);
		Task<bool> Eliminar(int codigo);
		Task<IEnumerable<Servicio>> GetLista();
		Task<Servicio> GetPorCodigo(int codigo);
	}
}
