using System.Collections.Generic;

namespace HEnCasa.App.Dominio{

    public class Medico{
        
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string Telefono {get; set;}
        public string Genero {get; set;}
        public List<Paciente> Pacientes {get; set;}
        public string Especialidad {get; set;}
        public string Codigo {get; set;}
    }
}