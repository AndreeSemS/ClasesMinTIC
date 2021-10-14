namespace HEnCasa.App.Dominio{

    public class Paciente{
        
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellidos {get; set;}
        public string Telefono {get; set;}
        public string Genero {get; set;}
        public string Direccion {get; set;}
        public string Ciudad {get; set;}
        public string FechaNacimiento {get; set;}
        public int EnfermeraId {get; set;}
        public Enfermera Enfermera {get; set;}
        public int MedicoId {get; set;}
        public Medico Medico {get; set;}
        public int FamiliarId {get; set;}
        public FamiliarDesignado Familiar {get; set;}
        public int HistoriaId {get; set;}
        public Historia Historia {get; set;}
    }
}