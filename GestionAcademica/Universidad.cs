using System;
using System.Collections.Generic;

namespace GestionAcademica
{
    public class Universidad
    {
        public List<Asignatura> ListaAsignatura { get; set; }  //Creo una lista basada en los parametros de Asignatura
        public Universidad()
        {
            ListaAsignatura = new List<Asignatura>();
        }
        public void InscribirEstudiante(Asignatura listaAsignatura)
        {
            if(listaAsignatura != null)
            {
               ListaAsignatura.Add(listaAsignatura);
            }
            else
            {
                Console.WriteLine("El campo no puede estar vacio");
            }
        }

    }
}
