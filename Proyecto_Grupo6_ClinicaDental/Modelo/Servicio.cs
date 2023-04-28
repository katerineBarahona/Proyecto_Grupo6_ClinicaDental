using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Servicio
    {
        [Required(ErrorMessage = "El codigo es obligatorio")]
        public int CodigoServicio { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "La Descripcion es obligatoria")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "El Tipo de Habitacion es obligatorio")]
        public string? Doctor { get; set; }
        [Required(ErrorMessage = "La Existencia es obligatoria")]
        public decimal Precio  { get; set; }
        [Required(ErrorMessage = "La Fecha de Creacion es obligatoria")]
        public DateTime FechaAtencion { get; set; }
        public byte[]? Imagen { get; set; }

    }
}
