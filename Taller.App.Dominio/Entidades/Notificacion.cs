using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Taller.App.Dominio.Entidades
{
    public class Notificacion
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotificacionId {get; set;}
        public string Mensaje {get; set;}
        public string Estado {get; set;}
        public string Fecha {get; set;}


        public int? PropietarioId { get; set; }
        public Propietario Propietario { get; set; }


    }
}