using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo
{
    public class Circuito
    {
        List<Vehiculo> Vehiculo { get; set; } = new List<Vehiculo>();

        public int VueltasPermitidas { get; set; }
        public String NombreDelCircuito { get; set; }

        public Circuito(int VueltasPermitidas, String NombreDelCircuito)
        {
            this.VueltasPermitidas = VueltasPermitidas;
            this.NombreDelCircuito = NombreDelCircuito;
        }
        public void AñadirVehiculo(Vehiculo vehiculo)
        {
            this.Vehiculo.Add(vehiculo);
        }

        public void SacarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                this.Vehiculo.Remove(vehiculo);
            }
            catch
            {
                Console.WriteLine("El vehiculo no esta en este circuito");
            }
        }

        public Dictionary<Vehiculo, int> RealizarPrueba()
        {
            Dictionary<Vehiculo, int> fastesLap = new Dictionary<Vehiculo, int>();
            if (this.Vehiculo.Count > 0)
            {
                return null;
            }

            Console.WriteLine(this.Vehiculo.Count);
            foreach(Vehiculo vec in this.Vehiculo)
            {
                int fastest = 1000000;
                vec.Encender();
                vec.Movimiento();
                for(int i = 0; i < this.VueltasPermitidas; i++)
                { 
                    Random r = new Random();
                    int lap = r.Next(0, 999999);
                    if (lap < fastest)
                    {
                        fastest = lap;
                    }
                }


                fastesLap.Add(vec, fastest);
                vec.Apagar();
                Console.WriteLine($"Vehiculo {vec.Estado} con el lap {fastest}");
            }
            
            return fastesLap;
     
        }

    }
}
