using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SangalTec.Models.Entities
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }

        [Required(ErrorMessage = "El campo nombres y apellidos es obligatorio")]
        [Display(Name = "Nombres y apellidos")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo teléfono es obligatorio")]
        [Display(Name = "Teléfono")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "El campo correo electronico es obligatorio")]
        public string Correo { get; set; }

        public bool Estado { get; set; }

        [Required(ErrorMessage =  "El campo insumo es obligatorio")]
        [Display(Name = "Insumo")]
        public int InsumoId { get; set; }

        public Insumo Insumos {get; set;}
    }
}
