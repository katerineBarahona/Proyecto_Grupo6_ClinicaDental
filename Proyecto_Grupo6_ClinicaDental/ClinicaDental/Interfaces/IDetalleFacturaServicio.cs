using Modelos;

namespace ClinicaDental.Interfaces
{
	public interface IDetalleFacturaServicio
	{
		Task<bool> Nuevo(DetalleFactura detalleFactura);
	}
}
