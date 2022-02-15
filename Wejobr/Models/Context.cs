using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wejobr.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<Candidato> candidatos { get; set; }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<Recrutador> recrutadores { get; set; }
        public DbSet<Vaga> vagas { get; set; }
        public DbSet<Idioma> idiomas { get; set; }
    }
}
