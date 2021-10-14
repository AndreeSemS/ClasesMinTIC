using System.Linq;
using HEnCasa.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HEnCasa.App.Persistencia{

    public class RepositorioEnfermera:IRepositorioEnfermera{

        private readonly AppContext _appContext = new AppContext();

        IEnumerable<Enfermera> IRepositorioEnfermera.GetAllEnfermeras(){
            return _appContext.Enfermeras;
        }

        Enfermera IRepositorioEnfermera.GetEnfermera(int idEnfermera){
            return _appContext.Enfermeras.FirstOrDefault(p => p.Id==idEnfermera);
        }

        Enfermera IRepositorioEnfermera.AddEnfermera(Enfermera enfermera){
            var enfermeraAdicionada = _appContext.Enfermeras.Add(enfermera);
            _appContext.SaveChanges();
            return enfermeraAdicionada.Entity;
        }

        Enfermera IRepositorioEnfermera.UpdateEnfermera(Enfermera enfermera){
            var enfermeraEncontrada = _appContext.Enfermeras.FirstOrDefault(p => p.Id==enfermera.Id);
            if (enfermeraEncontrada!=null){
                enfermeraEncontrada.Nombre = enfermera.Nombre;
                enfermeraEncontrada.Apellidos = enfermera.Apellidos;
                enfermeraEncontrada.Telefono = enfermera.Telefono;
                enfermeraEncontrada.Genero = enfermera.Genero;
                enfermeraEncontrada.Paciente = enfermera.Paciente;

                _appContext.SaveChanges();
            }
            return enfermeraEncontrada;
        }

        void IRepositorioEnfermera.DeleteEnfermera(int idEnfermera){
            var enfermeraEncontrada = _appContext.Enfermeras.FirstOrDefault(p => p.Id==idEnfermera);
            if (enfermeraEncontrada == null){
                return;
            }
            _appContext.Enfermeras.Remove(enfermeraEncontrada);
            _appContext.SaveChanges();
        }
    }
}