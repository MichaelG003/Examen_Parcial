using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using appRemesas.Models;


namespace appRemesas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Remesa> Remesas { get; set; }
        public DbSet<Transaccion> Transacciones { get; set; }
        public DbSet<Conversion> Conversiones { get; set; }
    }
}