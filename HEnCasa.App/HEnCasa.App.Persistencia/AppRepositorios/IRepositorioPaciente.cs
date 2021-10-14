using System.Collections.Generic;
using HEnCasa.App.Dominio;

namespace HEnCasa.App.Persistencia{

    public interface IRepositorioPaciente{

        IEnumerable<Paciente> GetAllPacientes();

        Medico GetMedicoPaciente(int idPaciente);

        Paciente AddPaciente(Paciente paciente);

        Paciente UpdatePaciente(Paciente paciente);

        void DeletePaciente(int idPaciente);

        Paciente GetPaciente(int idPaciente);

        void ChangeMedico(int Paciente, Medico medico);
    }
}