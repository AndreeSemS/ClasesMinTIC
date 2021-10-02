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
            var paciente = new Paciente{
                Nombre = "Diana",
                Apellidos = "Perea",
                Telefono = "8791245",
                Genero = Genero.femenino,
                Direccion = "Calle 24 N 1-9",
                Longitud = -84.8,
                Latitud = 100.7,
                Ciudad = "Casanare",
                FechaNacimiento = "08/02/1984"
            };
            _repoPaciente.AddPaciente(paciente);
        }
    }
}