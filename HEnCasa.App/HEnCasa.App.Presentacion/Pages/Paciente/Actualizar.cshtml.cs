using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HEnCasa.App.Persistencia;
using HEnCasa.App.Dominio;


namespace HEnCasa.App.Presentacion.Page{
    
    public class ActualizarModel : PageModel{

        private readonly IRepositorioPaciente _repoPaciente;

        public Paciente paciente {get; set;}

        public ActualizarModel(IRepositorioPaciente _repoPaciente){
        this._repoPaciente = _repoPaciente;
        }

        public IActionResult OnGet(int id){
            paciente = _repoPaciente.GetPaciente(id);
            return Page();
        }

        public IActionResult OnPost(Paciente paciente){
            _repoPaciente.UpdatePaciente(paciente);
            return RedirectToPage("/Paciente/Paciente");
        }
    }
}
