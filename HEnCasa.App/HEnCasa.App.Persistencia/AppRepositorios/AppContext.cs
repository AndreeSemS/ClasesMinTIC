using Microsoft.EntityFrameworkCore;
using HEnCasa.App.Dominio;

namespace HEnCasa.App.Persistencia{
    
    public class AppContext:DbContext{

        public DbSet<Persona>  Personas {get; set;}
        public DbSet<Paciente>  Pacientes {get; set;}
        public DbSet<Medico>  Medicos {get; set;}
        public DbSet<Enfermera>  Enfermeras {get; set;}
        public DbSet<FamiliarDesignado>  FamiliaresDesignados {get; set;}
        public DbSet<SignoVital>  SignosVitales {get; set;}
        public DbSet<Historia>  HistoriasClinicas {get; set;}
        public DbSet<SugerenciaCuidado>  SugerenciasCuidado {get; set;}
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer(
                    "Server=localhost; Database=HEnCasa.Data; user=SA; password=raizdeTANGENTE18+; Trusted_Connection=False; MultipleActiveResultSets=True;");
            }
        }
    }
}