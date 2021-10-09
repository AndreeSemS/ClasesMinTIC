using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HEnCasa.App.Persistencia;
using HEnCasa.App.Dominio;

namespace HEnCasa.App.Presentacion.Page{

    public class CrearModel : PageModel{

    private readonly IRepositorioPaciente _repoPaciente;

    public Paciente paciente {get; set;}

    public CrearModel(IRepositorioPaciente _repoPaciente){
        this._repoPaciente = _repoPaciente;
    }

        public void OnGet(){
            paciente = new Paciente();
        }

        public IActionResult OnPost(Paciente paciente){
            _repoPaciente.AddPaciente(paciente);
            return RedirectToPage("Index");
        }
    }
}
