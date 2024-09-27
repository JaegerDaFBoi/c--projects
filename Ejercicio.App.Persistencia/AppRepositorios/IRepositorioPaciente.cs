using System.Collections.Generic;
using Ejercicio.App.Dominio;

namespace  Ejercicio.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPaciente();
        Paciente AddPaciente(Paciente paciente);
        Paciente GetPaciente(int idPaciente);
    }
}