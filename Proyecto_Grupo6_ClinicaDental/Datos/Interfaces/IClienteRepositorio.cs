using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<Cliente> GetPorCodigo(string Identidadcliente);
        Task<bool> Nuevo(Cliente cliente);
        Task<bool> Actualizar(Cliente cliente);
        Task<bool> Eliminar(string identidadcliente);
        Task<IEnumerable<Cliente>> GetLista();
    }
}
