using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taller.App.Dominio.Entidades;


namespace Taller.App.Persistencia
{
    public class RepositorioMecanico
    {
        private readonly ContextDb dbContext;

        public RepositorioMecanico(ContextDb dbContext){
            this.dbContext = dbContext;
        }

        public Mecanico AgregarMecanico(Mecanico m){

            var mecanicoNuevo = this.dbContext.Mecanico.Add(m);
            this.dbContext.SaveChanges();
            return mecanicoNuevo.Entity;
        }

        public IEnumerable<Mecanico> ObtenerMecanicos(){
            return this.dbContext.Mecanico;
        }


        public Mecanico BuscarMecanico(int idMecanico){
            return this.dbContext.Mecanico.FirstOrDefault(m => m.Id == idMecanico);
            
        }


        public Mecanico EditarMecanico(Mecanico mecanicoNuevo){
            var mecanicoActual = this.dbContext.Mecanico.FirstOrDefault(m => m.Id == mecanicoNuevo.Id);
            if(mecanicoActual != null){
                mecanicoActual.Nombre = mecanicoNuevo.Nombre;
                mecanicoActual.Telefono = mecanicoNuevo.Telefono;
                mecanicoActual.Contrasena = mecanicoNuevo.Contrasena;
                mecanicoActual.Rol = mecanicoNuevo.Rol;
                mecanicoActual.NivelEstudio = mecanicoNuevo.NivelEstudio;
                mecanicoActual.SedeId = mecanicoNuevo.SedeId;
                this.dbContext.SaveChanges();
            }
            return mecanicoActual;
        }


        public void EliminarMecanico(int idMecanico){
            var mecanicoEncontrado = this.dbContext.Mecanico.FirstOrDefault(m => m.Id == idMecanico);
            if(mecanicoEncontrado != null){
                this.dbContext.Mecanico.Remove(mecanicoEncontrado);
                this.dbContext.SaveChanges();

            }
            
        }

    }



}

