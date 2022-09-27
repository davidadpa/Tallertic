using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Taller.App.Persistencia;
using Taller.App.Dominio.Entidades;


namespace Taller.App.Front.Pages
{
    public class GestionSedeModel : PageModel
    {


        private static RepositorioSede repoSede = new RepositorioSede(
            new Persistencia.ContextDb()
        );

        public string titulo { get; set; } = "Gestión de Sedes";
        public List<Sede> listaSedes = new List<Sede>();


        public void OnGet()
        {
        }


        public void OnPostAddSede(Sede s){
            repoSede.AgregarSede(s);
            this.ObtenerSedes();
        }



        private void ObtenerSedes()
        {
            foreach (Sede sede in repoSede.ObtenerSedes())
            {
                listaSedes.Add(new Sede()
                {
                    Nombre = sede.Nombre,
                    DireccionSede = sede.DireccionSede,
                    Ciudad = sede.Ciudad,
                    Descripcion = sede.Descripcion,
                });
            }
        }        
    }
}
