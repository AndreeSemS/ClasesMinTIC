namespace HEnCasa.App.Dominio{

    public class Paciente:Persona{
        
        public int IdPaciente {get; set;}
        public string Direccion {get; set;}
        public double Latitud {get; set;}
        public double Longitud {get; set;}
        public string Ciudad {get; set;}
        public string FechaNacimiento {get; set;}
        public Enfermera Enfermera {get; set;}
        public Medico Medico {get; set;}
        public FamiliarDesignado FamiliarDesignado {get; set;}
        public Historia Historia {get; set;}
    }
}