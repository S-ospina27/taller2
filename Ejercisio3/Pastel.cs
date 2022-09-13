using System;
using Ejercisio3;
using System.Collections.Generic;
namespace Ejercisio3
{
    public class Pastel{
    
        public string Nombre {get; set;} = "";
        public string Tamaño {get; set;} = "";
        private List<Ingredientes> Ingredientes {get; set;} = new List<Ingredientes>();

        public Pastel(string Nombre, string Tamaño)
        {
            this.Nombre = Nombre;
            this.Tamaño = Tamaño;
        }


        public void anadirIngrediente(Ingredientes ingrediente){

            this.Ingredientes.Add(ingrediente);
        }

        public double costoTotal(){

            double total=0;
            
            foreach (Ingredientes ingrediente in this.Ingredientes)
            {
                total += ingrediente.precio;

            
            }

            return total;
        }

        public  string listar(){
        
            string ingredientes="";

                foreach (Ingredientes ingrediente in this.Ingredientes)
                {
                    Console.WriteLine( ingrediente.nombres);
                    ingredientes+=ingrediente.nombres+="\n";
                }

            return ingredientes;
        }

        public int contar(){

            return this.Ingredientes.Count();
        }

    }
 }

   
