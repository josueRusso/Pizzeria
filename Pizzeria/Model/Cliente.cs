using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Model
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor proporcionar un Nombre.")]
        public string Nombre { get; set; } = default!;

        [Required(ErrorMessage = "Por favor proporcionar una Calle con su número de casa.")]
        public string Calle { get; set; } = default!;

        [Required(ErrorMessage = "Por favor proporcionar una Ciudad.")]
        public string Ciudad { get; set; } = default!;
    }
}
