using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HEnCasa.App.Persistencia;
using HEnCasa.App.Dominio;

namespace HEnCasa.App.Presentacion.Page{

    public class EliminarPacienteModel : PageModel{

        private readonly IRepositorioPaciente _repoPaciente;

        public Paciente paciente {get; set;}

        public EliminarPacienteModel(IRepositorioPaciente _repoPaciente){
        this._repoPaciente = _repoPaciente;
        }

        public IActionResult OnGet(int id){
            paciente = _repoPaciente.GetPaciente(id);
            return Page();
        }

        public IActionResult OnPost(int id){
            _repoPaciente.DeletePaciente(id);
            return RedirectToPage("/Paciente/Paciente");
        }
    }
}
