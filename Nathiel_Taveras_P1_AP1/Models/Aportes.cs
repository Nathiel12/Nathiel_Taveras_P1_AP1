using System.ComponentModel.DataAnnotations;

namespace Nathiel_Taveras_P1_AP1.Models
{
    public class Aportes
    {
        [Key]
        public int AportesId { get; set; }
        [Required(ErrorMessage ="Este campo es requerido")]
        public string Persona { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string Observacion { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "El monto tiene que ser mayor de 1")]
        public double Monto { get; set; }
    }
}
