using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2.Models
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        [Required (ErrorMessage = "En este campo es obligatorio introducir la descripcion del articulo")]
        public string Descripcion { get; set; }
        [Range (minimum:1, maximum:10000, ErrorMessage ="Su rango es de 1 a 10000")]
        public double Existencia { get; set; }
        [Range(minimum:1, maximum:1000000, ErrorMessage ="Su rango es de 1 a 1000000")]
        public double Costo { get; set; }
        public double ValorInventario { get; set; }
    }
}
