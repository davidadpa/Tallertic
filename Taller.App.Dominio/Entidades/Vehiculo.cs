using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Taller.App.Dominio.Entidades
{
    public class Vehiculo
    {
        [Key]
        public string Placa {get; set;}
        public string Marca {get; set;}
        public string Linea {get; set;}
        public int Modelo {get; set;}
        public string Cilindraje {get; set;}
        public int Capacidad {get; set;}
        public string Descripcion {get; set;}

        public List<Revision> Revisiones { get; set; }

        public int PropietarioId { get; set; }
        public Propietario Propietario { get; set; }
    }
}