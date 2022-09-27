using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Taller.App.Dominio.Entidades
{
    public class Persona
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Telefono {get; set;}
        public string Contrasena {get; set;}
        public string Rol {get; set;}
        
    }

}