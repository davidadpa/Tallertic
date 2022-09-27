using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Taller.App.Persistencia;
using Taller.App.Dominio.Entidades;


using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;





namespace Taller.App.Front.Pages
{
    public class EditMecanicoModel : PageModel
    {
        public static RepositorioMecanico repoMecanico = new RepositorioMecanico(new Persistencia.ContextDb());
        public static RepositorioSede repoSede= new RepositorioSede(new Persistencia.ContextDb());
        public List<Sede> listaSedes = new List<Sede>();    
        public List<Mecanico> listaMecanicos = new List<Mecanico>();    

        [BindProperty]
        public Mecanico Mecanico {get; set;}

        /*public EditMecanicoModel(RepositorioMecanico repositorioMecanico)
        {
            this.repoMecanico = repositorioMecanico;
        }*/

        public IActionResult OnGet(int id){
            this.ObtenerSedes();

            Mecanico = repoMecanico.BuscarMecanico(id);
            if (Mecanico == null)
            {
               return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            Mecanico = repoMecanico.EditarMecanico(Mecanico);

            return Page();
                 
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
