using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EASY_PROGRAMING_PLATAFORM.Models;
using ProgramingEasy.Models;

namespace ProgramingEasy.Models
{
    public class ProgramingEasyDBContext : DbContext
    {
        public ProgramingEasyDBContext (DbContextOptions<ProgramingEasyDBContext> options)
            : base(options)
        {
        }

        public DbSet<EASY_PROGRAMING_PLATAFORM.Models.Alumnos> Alumnos { get; set; }

        public DbSet<ProgramingEasy.Models.Calificaciones> Calificaciones { get; set; }

        public DbSet<EASY_PROGRAMING_PLATAFORM.Models.Etapas> Etapas { get; set; }

        public DbSet<ProgramingEasy.Models.Cursos> Cursos { get; set; }

       
    }
}
