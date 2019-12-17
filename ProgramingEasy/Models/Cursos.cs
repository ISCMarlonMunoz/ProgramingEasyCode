using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProgramingEasy.Models
{
    public class Cursos
{
        [Key]
        public int Id_curso { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Lenguaje_programacion { get; set; }
    }
}
