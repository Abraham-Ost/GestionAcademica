using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAcademica
{
    public class Asignatura
    {
        //propiedades
        public string Nombre { get; set; }
        public string Profesor { get; set; }
        public string Creditos { get; set; }
        public int Estudiantes { get; set; }
        public Asignatura(string nombre, string profesor, string creditos, int estudiantes)
        {
            Nombre = nombre;
            Profesor = profesor;
            Creditos = creditos;
            Estudiantes = estudiantes;
        }
        public Asignatura() //Constructor por defecto
        {
        }
        public void IngresarAsignatura()
        {
            try
            {
                Console.Write("Ingrese el nombre de la asignatura ");
                Nombre = Console.ReadLine();

                Console.Write("Ingrese el nombre del profesor: ");
                Profesor = Console.ReadLine();

                Console.Write("Ingrese el numero de creditos ");
                Creditos = Console.ReadLine();

                Console.Write("Ingresa el nombre del estudiante: ");
                Estudiantes = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error en el formato de entrada: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
