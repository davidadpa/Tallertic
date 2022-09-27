using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Taller.App.Persistencia
{
    public class ContextDb : DbContext
    {

        public virtual DbSet<Mecanico> Mecanico {get; set;}
        public virtual DbSet<Propietario> Propietario {get; set;}
        public virtual DbSet<JefeOperacion> JefeOperacion {get; set;}
        //public virtual DbSet<Persona> Persona {get; set;}
        public virtual DbSet<Notificacion> Notificacion {get; set;}
        public virtual DbSet<Revision> Revision {get; set;}
        public virtual DbSet<Sede> Sede {get; set;}
        public virtual DbSet<Vehiculo> Vehiculo {get; set;}
        
        public List<Mecanico> listaMecanicos = new List<Mecanico>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Server=tcp:servertallercalt.database.windows.net,1433;Initial Catalog=bd_tallertic;Persist Security Info=False;User ID=admintic;Password=tic6905Karloza;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",options => options.EnableRetryOnFailure());
                }

            }
            catch (System.Exception)
            {
                Console.WriteLine("Ocurrio un error en la conexión - OnConfiguring");
                throw;
            }

        }



    }
}