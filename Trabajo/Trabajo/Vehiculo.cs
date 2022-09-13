using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Trabajo.IVehiculo;


namespace Trabajo
{
    public class Vehiculo : IVehiculo
    {
        String Tipo { get; set; }
        String Escuderia { get; set; }
        public List<Estado> Estado { get; private set; } = new List<Estado>();

        public Vehiculo(string tipo, string escuderia)
        {
            this.Tipo = tipo;
            this.Escuderia = escuderia;
            this.Estado.Add(Trabajo.Estado.APAGADO);
        }

        public void Encender()
        {
            if (this.Estado.Contains(Trabajo.Estado.APAGADO)) {
                this.Estado.Clear();
                this.Estado.Add(Trabajo.Estado.ENCENDIDO);
                this.Estado.Add(Trabajo.Estado.PARADO);

                Console.WriteLine($"Encendiendo {this.Tipo}");
                return;
            }

            Console.WriteLine("Debes apagar el vehiculo");
        }

        public void Apagar()
        {
            if (this.Estado.Contains(Trabajo.Estado.ENCENDIDO) && this.Estado.Contains(Trabajo.Estado.PARADO))
            {
                this.Estado.Clear();
                this.Estado.Add(Trabajo.Estado.APAGADO);
                Console.WriteLine($"Apagando {this.Tipo}");

                return;
            }

            Console.WriteLine("El vehiculo debe estar encendido y parado");

        }

        public void Movimiento()
        {
            if (this.Estado.Contains(Trabajo.Estado.ENCENDIDO) && this.Estado.Contains(Trabajo.Estado.PARADO))
            {
                this.Estado.Clear();
                this.Estado.Add(Trabajo.Estado.MOVIMIENTO);
                this.Estado.Add(Trabajo.Estado.ENCENDIDO);
                Console.WriteLine($"{this.Tipo} en movimiento");

                return;
            }

            Console.WriteLine("El vehiculo debe estar encendido y parado");

        }

        public void Detener()
        {
            if (this.Estado.Contains(Trabajo.Estado.ENCENDIDO) && this.Estado.Contains(Trabajo.Estado.MOVIMIENTO))
            {
                this.Estado.Clear();
                this.Estado.Add(Trabajo.Estado.PARADO);
                this.Estado.Add(Trabajo.Estado.ENCENDIDO);
                Console.WriteLine($"Parando McLaren {this.Tipo}");

                return;
            }

            Console.WriteLine("El vehiculo debe estar encendido y en movimiento");

        }
    }

    public enum Estado
    {
        APAGADO,
        ENCENDIDO, 
        MOVIMIENTO, 
        PARADO
    }
}
