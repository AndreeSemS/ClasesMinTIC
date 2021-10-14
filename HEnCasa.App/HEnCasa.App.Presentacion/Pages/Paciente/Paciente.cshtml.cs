using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HEnCasa.App.Dominio;
using HEnCasa.App.Persistencia;

namespace HEnCasa.App.Presentacion.Page{

    public class PacienteModel:PageModel{

        private readonly IRepositorioPaciente _repoPaciente;

        public IEnumerable<Paciente> ListaPacientes {get; set;}

        public PacienteModel(IRepositorioPaciente _repoPaciente){
            this._repoPaciente = _repoPaciente;
        }

        public void OnGet(){

            ListaPacientes = _repoPaciente.GetAllPacientes(); 
            
        }
    }
}
