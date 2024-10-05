using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appRemesas.Models
{
    [Table("remesas")]
    public class Remesa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Remitente { get; set; }

        [Required]
        public string Destinatario { get; set; }

        [Required]
        public string PaisOrigen { get; set; }

        [Required]
        public string PaisDestino { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El monto debe ser mayor a cero.")]
        public decimal Monto { get; set; }

        [Required]
        public string Moneda { get; set; }

        [Required]
        public decimal TasaCambio { get; set; }

        [Required]
        public decimal MontoFinal { get; set; }

        public string Estado { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}