namespace HEnCasa.App.Dominio{

    public class Historia{
        
        public int Id {get; set;}
        public string Diagnostico {get; set;}
        public SignoVital SignoVital {get; set;}
        public SugerenciaCuidado SugerenciaCuidado {get; set;}
    }
}