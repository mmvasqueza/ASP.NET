
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using System.Collections.Generic;

namespace MVC.Models
{
    //En esta clase creamos un contexto de la base de datos haciendo uso de EntityFrameworkCore
    public class EscuelaContext : DbContext
    {
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Evaluación> Evaluaciones { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public EscuelaContext(DbContextOptions<EscuelaContext> options ) : base(options)
        {

        }
    }
}
