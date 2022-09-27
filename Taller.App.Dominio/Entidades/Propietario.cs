using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Taller.App.Dominio.Entidades
{
    public class Propietario : Persona
    {

        public string Ciudadresidencia {get; set;}
        public string Correo {get; set;}

        public List<Vehiculo> Vehiculos { get; set; }
        public List<Notificacion> Notificacions { get; set; }

    }

    
}