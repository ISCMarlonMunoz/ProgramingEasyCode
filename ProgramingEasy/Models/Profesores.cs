using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EASY_PROGRAMING_PLATAFORM.Models
{
    public class Profesores
    {
        [Key]
        public int Id_profesor { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Especialidad { get; set; }

    }  

}
