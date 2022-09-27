using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller.App.Dominio.Entidades
{
    public class JefeOperacion : Persona
    {

        public string NivelEstudio {get; set;}

        public int? SedeId { get; set; }
        public virtual Sede Sede { get; set; }

    }
}