using Microsoft.EntityFrameworkCore;
using Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaInformatica
{
    public class InformaticaContext:DbContext
    {
        public DbSet<GerarNota> Notas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Servico> Servicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EmpresaInformatica;Trusted_connection=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<GerarNotasServicos>()
                .HasKey(pp=>new {pp.ServicoID,pp.NotaId });
        }
    }
}
