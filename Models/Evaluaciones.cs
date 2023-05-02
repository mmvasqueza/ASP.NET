using MVC.Models;
using System;

namespace MVV.Models
{
    public class Evaluaciones
    {
        public string UniqueId { get;  set; }
        public string Nombre { get; set; }

        public Alumno Alumno { get; set; }
        public Asignatura Asignatura  { get; set; }

        public float Nota { get; set; }

        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();
    }
}