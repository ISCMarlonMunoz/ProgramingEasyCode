using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProgramingEasy.Models
{
    public class Calificaciones
    {
        [Key]
        public int Id_calificacion{ get; set; }

        //User - Correo
        //public ProgramingEasy.Data.ProgramingEasyContext CorreoUsuario { get; set; }
        // public int Id { get; set; }

        //LLAVE PRIMARIA
        //public Cursos Curso { get; set; }
        //public int Id_curso { get; set; }

        public int calificacion { get; set; }

    }
}
