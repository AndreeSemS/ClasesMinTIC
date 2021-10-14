using System.Linq;
using HEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HEnCasa.App.Persistencia{

    public class RepositorioMedico:IRepositorioMedico{

        private readonly AppContext _appContext = new AppContext();

        IEnumerable<Medico> IRepositorioMedico.GetAllMedicos(){
            return _appContext.Medicos;
        }

        Medico IRepositorioMedico.GetMedico(int idMedico){
            return _appContext.Medicos.FirstOrDefault(p => p.Id==idMedico);
        }

        Medico IRepositorioMedico.AddMedico(Medico medico){
            var medicoAdicionado = _appContext.Medicos.Add(medico);
            _appContext.SaveChanges();
            return medicoAdicionado.Entity;
        }

        Medico IRepositorioMedico.UpdateMedico(Medico medico){
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id==medico.Id);
            if (medicoEncontrado!=null){
                medicoEncontrado.Nombre = medico.Nombre;
                medicoEncontrado.Apellidos = medico.Apellidos;
                medicoEncontrado.Telefono = medico.Telefono;
                medicoEncontrado.Genero = medico.Genero;
                medicoEncontrado.Especialidad = medico.Especialidad;
                medicoEncontrado.Codigo = medico.Codigo;

                _appContext.SaveChanges();
            }
            return medicoEncontrado;
        }

        void IRepositorioMedico.DeleteMedico(int idMedico){
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id==idMedico);
            if (medicoEncontrado == null){
                return;
            }
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();
        }
    }
}