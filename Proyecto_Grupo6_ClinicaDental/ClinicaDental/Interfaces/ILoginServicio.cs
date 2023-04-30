using Modelos;

namespace ClinicaDental.Interfaces
{
	public interface ILoginServicio
	{
		Task<bool> ValidarUsuario(Login login);
	}
}
