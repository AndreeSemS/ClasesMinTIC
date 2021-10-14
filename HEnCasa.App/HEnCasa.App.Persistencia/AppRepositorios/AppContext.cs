using System.Linq;
using HEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace HEnCasa.App.Persistencia{
    
    public class AppContext:DbContext{

        public DbSet<Paciente> Pacientes {get; set;}
        public DbSet<Medico> Medicos {get; set;}
        public DbSet<Enfermera> Enfermeras {get; set;}
        public DbSet<FamiliarDesignado> FamiliaresDesignados {get; set;}
        public DbSet<SignoVital> SignosVitales {get; set;}
        public DbSet<Historia> HistoriasClinicas {get; set;}
        public DbSet<SugerenciaCuidado> SugerenciasCuidado {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
/*
            modelBuilder.Entity<Paciente>()
                .HasOne(p => p.Enfermera)
                .WithOne(e => e.Paciente)
                .HasForeignKey<Enfermera>(e => e.PacienteId);

            modelBuilder.Entity<Paciente>()
                .HasOne(p => p.Familiar)
                .WithOne(f => f.Paciente)
                .HasForeignKey<FamiliarDesignado>(f => f.PacienteId);

            modelBuilder.Entity<Paciente>()
                .HasOne(p => p.Historia)
                .WithOne(m => m.Paciente)
                .HasForeignKey<Historia>(m => m.PacienteId);
 */               
            modelBuilder.Entity<Paciente>()
                .HasOne<Medico>(p => p.Medico)
                .WithMany(m => m.Pacientes)
                .HasForeignKey(p => p.MedicoId);

            modelBuilder.Entity<Historia>()
                .HasOne(h => h.Paciente)
                .WithOne(p => p.Historia)
                .HasForeignKey<Paciente>(p => p.HistoriaId);

            modelBuilder.Entity<Enfermera>()
                .HasOne(e => e.Paciente)
                .WithOne(p => p.Enfermera)
                .HasForeignKey<Paciente>(p => p.EnfermeraId);

            modelBuilder.Entity<FamiliarDesignado>()
                .HasOne(f => f.Paciente)
                .WithOne(p => p.Familiar)
                .HasForeignKey<Paciente>(p => p.FamiliarId);
        }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer(
                    "Server=localhost; Database=HEnCasa.Data; user=SA; password=raizdeTANGENTE18+; Trusted_Connection=False; MultipleActiveResultSets=True;");
            }
        }
    }
}