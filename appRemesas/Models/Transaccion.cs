using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appRemesas.Models
{
    [Table("transacciones")]
    public class Transaccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Remitente { get; set; }
        public string Destinatario { get; set; }
        public decimal Monto { get; set; }
        public string Moneda { get; set; }
        public DateTime Fecha { get; set; }
    }
}