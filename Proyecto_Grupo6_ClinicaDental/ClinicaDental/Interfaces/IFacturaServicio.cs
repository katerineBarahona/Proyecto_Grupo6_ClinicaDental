using Modelos;

namespace ClinicaDental.Interfaces
{
	public interface IFacturaServicio
	{
		Task<int> Nueva(Factura factura);
		Task<IEnumerable<Factura>> GetLista();
	}
}
