using System.Collections.Generic;
using HEnCasa.App.Dominio;

namespace HEnCasa.App.Persistencia{

    public interface IRepositorioEnfermera{

        IEnumerable<Enfermera> GetAllEnfermeras();

        Enfermera AddEnfermera(Enfermera enfermera);

        Enfermera UpdateEnfermera(Enfermera enfermera);

        void DeleteEnfermera(int idEnfermera);

        Enfermera GetEnfermera(int idEnfermera);
    }
}