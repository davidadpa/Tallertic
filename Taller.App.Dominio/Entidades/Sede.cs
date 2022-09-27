using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Taller.App.Dominio.Entidades
{
    public class Sede
    {

        public int SedeId {get; set;}
        public string DireccionSede {get; set;}
        public string Nombre {get; set;}
        public string Descripcion {get; set;}
        public string Ciudad {get; set;}

        public List<Revision> Revisiones { get; set; }
        
    }
}