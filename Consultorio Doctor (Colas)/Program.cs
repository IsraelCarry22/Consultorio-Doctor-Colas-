using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_Doctor__Colas_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int espera = 1;
            Queue<string> Espera_pacientes = new Queue<string>();
            Espera_pacientes.Enqueue("Paciente");
            Espera_pacientes.Enqueue("Paciente");
            Espera_pacientes.Enqueue("Paciente");
            Espera_pacientes.Enqueue("Paciente");
            Espera_pacientes.Enqueue("Paciente");
            Console.WriteLine("== Turnos disponibles ==");
            foreach (var pacientes in Espera_pacientes)
            {
                Console.WriteLine("-- " + pacientes + " " + espera);
                espera++;
            }
            espera = 1;
            string paciente_atendido = Espera_pacientes.Dequeue();
            Console.WriteLine("\nPaciente atendido: " + paciente_atendido  + " " + espera + "\n");
            Console.WriteLine("== Turnos disponibles ==");
            foreach (var pacientes in Espera_pacientes)
            {
                Console.WriteLine("-- " + pacientes + " " + espera);
                espera++;
            }
            Console.ReadKey();
        }
    }
}