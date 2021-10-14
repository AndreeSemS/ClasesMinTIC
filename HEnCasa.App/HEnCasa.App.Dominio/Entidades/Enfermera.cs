namespace HEnCasa.App.Dominio{

    public class Enfermera{

        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string Telefono {get; set;}
        public string Genero {get; set;}
        //public int PacienteId {get; set;}
        public Paciente Paciente {get; set;}
    }
}