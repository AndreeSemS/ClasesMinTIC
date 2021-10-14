using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HEnCasa.App.Dominio;
using HEnCasa.App.Persistencia;

namespace HEnCasa.App.Presentacion.Page{

    public class MedicoModel : PageModel{

        private readonly IRepositorioMedico _repoMedico;

        public IEnumerable<Medico> ListaMedicos {get; set;}

        public MedicoModel(IRepositorioMedico _repoMedico){
            this._repoMedico = _repoMedico;
        }

        public void OnGet(){
            ListaMedicos = _repoMedico.GetAllMedicos(); 
        }
    }
}
