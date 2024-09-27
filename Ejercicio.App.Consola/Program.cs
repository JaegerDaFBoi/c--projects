using System;
using System.Collections.Generic;
using Ejercicio.App.Persistencia;
using Ejercicio.App.Dominio;

namespace Ejercicio.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente=new RepositorioPaciente();
        static void Main(string[] args)
        {
            Console.WriteLine("Esta ya no es una linea de texto");
            //AddPaciente();
            BuscarPaciente(1);
            MostrarPacientes();
        }
        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre="Pepito",
                Apellidos="Perez",
                NumeroTelefono="6068888888",
                Genero=Genero.Masculino,
                Direccion="Cl 10 # 1 - 2",
                Ciudad="Manizales",
                FechaNacimiento=new DateTime(1990,04,12),

            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void MostrarPacientes()
        {
            IEnumerable<Paciente> pacientes =_repoPaciente.GetAllPaciente();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos+" "+paciente.Genero);
            }
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Id+" "+paciente.Nombre+" "+paciente.Apellidos+" "+paciente.Genero);
        }
    }
}
