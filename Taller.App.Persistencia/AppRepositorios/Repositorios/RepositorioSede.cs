using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;

namespace Taller.App.Persistencia
{
    public class RepositorioSede
    {

        private readonly ContextDb dbContext;

        public RepositorioSede(ContextDb dbContext){
            this.dbContext = dbContext;
        }

        public Sede AgregarSede(Sede s){
            var sedeNueva = this.dbContext.Sede.Add(s);
            this.dbContext.SaveChanges();
            return sedeNueva.Entity;
        }

        public IEnumerable<Sede> ObtenerSedes(){
            return this.dbContext.Sede;
        }

        public Sede BuscarSede(int idSede){
            return this.dbContext.Sede.FirstOrDefault(s => s.SedeId == idSede);
            
        }

        public void EditarSede(Sede sedeNueva){
            var sedeActual = this.dbContext.Sede.FirstOrDefault(s => s.SedeId == sedeNueva.SedeId);
            if(sedeActual != null){
                sedeActual.Nombre = sedeNueva.Nombre;
                sedeActual.DireccionSede = sedeNueva.DireccionSede;
                sedeActual.Ciudad = sedeNueva.Ciudad;
                sedeActual.Descripcion = sedeNueva.Descripcion;
                this.dbContext.SaveChanges();
            }
        }


        public void EliminarSede(int idSede){
            var sedeEncontrada = this.dbContext.Sede.FirstOrDefault(s => s.SedeId == idSede);
            if(sedeEncontrada != null){
                this.dbContext.Sede.Remove(sedeEncontrada);
                this.dbContext.SaveChanges();

            }
            
        }        
        
    }
}