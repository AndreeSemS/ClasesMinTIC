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
                Nombre = "Luciana",
                Apellidos = "Nuñez",
                Telefono = "83894101",
                Genero = Genero.femenino,
                Direccion = "Carrera 48 # 3-4 sur",
                Longitud = 24.3,
                Latitud = 87.1,
                Ciudad = "Cauca",
                FechaNacimiento = "27/02/1980"
            };
            _repoPaciente.AddPaciente(paciente);
        }
    }
}