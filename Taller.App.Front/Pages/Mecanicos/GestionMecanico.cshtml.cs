using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Taller.App.Persistencia;
using Taller.App.Dominio.Entidades;

namespace Taller.App.Front.Pages
{
    public class GestionMecanicoModel : PageModel
    {

        private static RepositorioMecanico repoMecanico = new RepositorioMecanico(
            new Persistencia.ContextDb()
        );

        private static RepositorioSede repoSede = new RepositorioSede(
            new Persistencia.ContextDb()
        );

        public string titulo { get; set; } = "Gestión Mecanico";
        public List<Mecanico> listaMecanicos = new List<Mecanico>();
        public List<Sede> listaSedes = new List<Sede>();
        
        public List<dataMecanico> listaDataMecanicos = new List<dataMecanico>();

        public void OnGet()
        {
            this.ObtenerMecanicos();
            this.ObtenerSedes();
        }


        public void OnPostAddMecanico(Mecanico m){
            try
            {
                repoMecanico.AgregarMecanico(m);
                this.ObtenerMecanicos();
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }


   
        public void OnPostDelMecanico(int id){
            try
            {
                repoMecanico.EliminarMecanico(id);
                this.ObtenerMecanicos();
                this.ObtenerSedes();
            }
            catch (System.Exception)
            {
                
                throw;
            }

        }

        private void ObtenerMecanicos()
        {
            foreach (Mecanico mecanico in repoMecanico.ObtenerMecanicos())
            {
                listaMecanicos.Add(new Mecanico()
                {
                    Id= mecanico.Id,
                    Nombre = mecanico.Nombre,
                    Telefono = mecanico.Telefono,
                    Rol = mecanico.Rol,
                    NivelEstudio = mecanico.NivelEstudio,
                    SedeId = mecanico.SedeId,
                    Contrasena = mecanico.Contrasena
                });
            }
        }



        private void ObtenerSedes()
        {
            foreach (Sede sede in repoSede.ObtenerSedes())
            {
                listaSedes.Add(new Sede()
                {
                    SedeId= sede.SedeId,
                    Nombre = sede.Nombre,
                    DireccionSede = sede.DireccionSede,
                    Ciudad = sede.Ciudad,
                    Descripcion = sede.Descripcion,
                });
            }
        }        




    }
}
