using Dapper;
using Datos.Interfaces;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class ServicioRepositorio : IServicioRepositorio
    {
        private string CadenaConexon;

        public ServicioRepositorio(string _cadenaConexion)
        {
            CadenaConexon = _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexon);
        }

        public async Task<bool> Actualizar(Servicio servicio)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = @"UPDATE Servicio SET Nombre=@Nombre, Descripcion=@Descripcion, Doctor=@Doctor, Precio=@Precio, FechaAtencion=@FechaAtencion, Imagen=@Imagen
                             WHERE CodigoServicio=@CodigoServicio;";
                resultado = Convert.ToBoolean(await conexion.ExecuteAsync(sql, servicio));
            }
            catch (Exception ex)
            {
            }
            return resultado;
        }

        public async Task<bool> Eliminar(int codigoservicio)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = @"DELETE FROM Servicio WHERE CodigoServicio=@CodigoServicio;";
                resultado = Convert.ToBoolean(await conexion.ExecuteAsync(sql, new { codigoservicio }));
            }
            catch (Exception ex)
            {
            }
            return resultado;
        }

        public async Task<IEnumerable<Servicio>> GetLista()
        {
            IEnumerable<Servicio> lista = new List<Servicio>();
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "SELECT * FROM Servicio";
                lista = await conexion.QueryAsync<Servicio>(sql);
            }
            catch (Exception ex)
            {
            }
            return lista;
        }

        public async Task<Servicio> GetPorCodigo(int codigoservicio)
        {
            Servicio servicio = new Servicio();
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "SELECT * FROM Servicio WHERE CodigoServicio = @CodigoServicio;";
                servicio = await conexion.QueryFirstAsync<Servicio>(sql, new { codigoservicio });
            }
            catch (Exception ex)
            {
            }
            return servicio;
        }

        public async Task<bool> Nuevo(Servicio servicio)
        {
            bool resultado = false;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = @"INSERT INTO Servicio (CodigoServicio, Nombre, Descripcion, Doctor, Precio, FechaCreacion, Imagen) 
                             VALUES (@CodigoServicio, @Nombre, @Descripcion, @Doctor, @Precio, @FechaCreacion, @Imagen);";
                resultado = Convert.ToBoolean(await conexion.ExecuteAsync(sql, servicio));
            }
            catch (Exception ex)
            {
            }
            return resultado;
        }

    }
}
