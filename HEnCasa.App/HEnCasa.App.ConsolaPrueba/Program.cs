using System;
using HEnCasa.App.Dominio;
using HEnCasa.App.Persistencia;

namespace HEnCasa.App.ConsolaPrueba{

    class Program{

        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();

        static void Main(string[] args){
            Console.WriteLine("Hello World!");
            AddPaciente();
        }

        private static void AddPaciente(){
            var medico = new Medico{
                Nombre = "Juan Carlos",
                Apellidos = "Acosta",
                Telefono = "3205647",
                Genero = Genero.masculino,
                Especialidad = "Optometria",
                Codigo = "2376"
            };

            var paciente = new Paciente{
                Nombre = "Martha",
                Apellidos = "Fonseca",
                Medico = medico,
                Telefono = "7456523",
                Genero = Genero.femenino,
                Direccion = "Calle 24 # 33-44",
                Longitud = -45.3,
                Latitud = 1.1,
                Ciudad = "Villavicencio",
                FechaNacimiento = "04/05/1972",
            };
            _repoPaciente.AddPaciente(paciente);
        }
    }
}