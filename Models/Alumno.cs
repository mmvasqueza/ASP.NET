using System;
using System.Collections.Generic;

namespace MVC.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
        public DateTime FechaInicio { get; set; } 
    }
}