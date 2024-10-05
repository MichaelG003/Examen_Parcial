using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appRemesas.Models
{
    public class Conversion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public decimal MontoUSD { get; set; }

        public decimal MontoBTC { get; set; }

        public decimal TasaCambio { get; set; }

        public DateTime FechaConversion { get; set; } = DateTime.Now;
    }
}