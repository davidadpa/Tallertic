// See https://aka.ms/new-console-template for more information

using System;
using Taller.App.Persistencia;
using Taller.App.Dominio.Entidades;

namespace Taller.AppConsola{
    class Program
    {

        private static RepositorioMecanico repoMecanico = new RepositorioMecanico(
            new ContextDb()
        );       

        static void Main(string[] args){
            //AgregarMecanico();
            //ObtenerMecanicos();
            //RecuperarMecanico(3);
            //EditarMecanico(3);
            BorrarMecanico(3);
        }

        static void AgregarMecanico(){
            //Sede Sub = new Sede() { SedeId = 1};

            var mecanico = new Mecanico{
                //Id = 23,
                Nombre = "Alberto",
                NivelEstudio = "tecnico",
                Telefono = "3103096312",
                Contrasena = "bachiller",
                Rol = "jefe",
                SedeId = 1
            };
            repoMecanico.AgregarMecanico(mecanico);
            
        }

        static void ObtenerMecanicos(){
            //Console.WriteLine(repoMecanico.ObtenerMecanicos().ToString());

            foreach (Mecanico mecanico in repoMecanico.ObtenerMecanicos()){
                Console.WriteLine(mecanico.Nombre.ToString());

            }

        }

        static void RecuperarMecanico(int id){
            Mecanico mecanico = repoMecanico.BuscarMecanico(id);
            //Console.WriteLine("Nombre" + mecanico.Nombre.ToString());
            Console.WriteLine("Nombre: " + mecanico.Nombre + "\n Nivel estudios: " + mecanico.NivelEstudio);

        }

        static void EditarMecanico(int id){
            var mecanico = new Mecanico{
                Id = id,
                Nombre = "Leonardo",
                NivelEstudio = "Universitario",
                Telefono = "4475545",
                Contrasena = "rtyrtyrtytr",
                Rol = "lider",
                SedeId = 1
            };
            Mecanico mecanico = repoMecanico.EditarMecanico(mecanico);
        }

        static void BorrarMecanico(int id){
            repoMecanico.EliminarMecanico(id);
            //Console.WriteLine(mecanico.Nombre.ToString());
        }



    }
}
