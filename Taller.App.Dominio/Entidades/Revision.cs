using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller.App.Dominio.Entidades
{
    public class Revision
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int RevisionId {get; set;}
        public DateTime Fecha {get; set;}
        public string Hora {get; set;}
        public string Estado {get; set;}
        public double ManoObra {get; set;}

        public string? Placa {get; set;}
        //public virtual Vehiculo Vehiculo { get; set; }
        public int? MecanicoId {get; set;}
        public virtual Mecanico Mecanico { get; set; }
        public int? SedeId {get; set;}
        public virtual Sede Sede { get; set; }

    }
}