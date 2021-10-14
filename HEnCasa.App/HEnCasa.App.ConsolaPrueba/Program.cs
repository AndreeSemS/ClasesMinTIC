using System;
using HEnCasa.App.Dominio;
using HEnCasa.App.Persistencia;

namespace HEnCasa.App.ConsolaPrueba{

    class Program{

        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        private static IRepositorioMedico _repoMedico = new RepositorioMedico();

        static void Main(string[] args){
            Console.WriteLine("Hello World!");
            AddPaciente();
        }

        private static void AddPaciente(){
          
            var signos = new SignoVital{
                FechaHora = "22/12/96 19:35",
                Dolor = "Normal",
                Temperatura = "37.0",
                Saturacion = "98%",
                RitmoCardiaco = "Óptimo",
                PresionArterial = "Buena" 
            };

            var cuidado = new SugerenciaCuidado{
                FechaHora = "22/12/96 19:35",
                Descripcion = "Cuidenlo mejor"
            };

            var medico = new Medico{
                Nombre = "Jairo",
                Apellidos = "Jimenez",
                Telefono = "96344147",
                Genero = "Masculino",
                Especialidad = "General",
                Codigo = "7896"
            };

            var paciente = new Paciente{
                Nombre = "Fabián",
                Apellidos = "Puerta",
                Telefono = "2354789",
                Genero = "Masculino",
                Direccion = "Calle 04 # 52-30",
                Ciudad = "Manizales",
                FechaNacimiento = "13/04/1974",
                Medico = medico
            };

            var historia = new Historia{
                Diagnostico = "Estado normal",
                SignoVital = signos,
                SugerenciaCuidado = cuidado
            };

            var familiar = new FamiliarDesignado{
                Nombre = "Teresa",
                Apellidos = "Campos",
                Telefono = "6548320",
                Genero = "Femenino",
                Correo = "teresita@gmail.com",
                Parentesco = "Mamá"
            };

            var enfermera = new Enfermera{
                Nombre = "Anais",
                Apellidos = "Guerrero",
                Telefono = "2387490",
                Genero = "Femenino"
            };

            paciente.Enfermera = enfermera;
            paciente.Familiar = familiar;
            paciente.Historia = historia;
            historia.Paciente = paciente;
            familiar.Paciente = paciente;
            enfermera.Paciente = paciente;

            //_repoMedico.AddMedico(medico);
            _repoPaciente.AddPaciente(paciente);
        }

    }
}