using System.ComponentModel.DataAnnotations;

namespace MvcSoporte.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre del empleado es un campo requerido.")]
        public string? Nombre { get; set; }
        [Display(Name = "Correo Electrónico")]
        [EmailAddress(ErrorMessage = "Dirección de correo electrónico iválida.")]
        public string? Email { get; set; }
        [Display(Name = "Teléfono")]
        public string? Telefono { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }

        public ICollection<Aviso>? Avisos { get; set; }

    }
}
