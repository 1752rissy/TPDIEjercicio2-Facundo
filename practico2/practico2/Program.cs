using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Vehiculo();
            OperacionesAbm op1 = new OperacionesAbm(vehiculo1);
            OperacionesBusqueda ob1 = new OperacionesBusqueda(vehiculo1);
            Console.WriteLine(op1.modificaciones());
            Console.WriteLine(op1.eliminacion());
            Console.WriteLine(ob1.busqueda());
            Console.WriteLine(ob1.obtención());
            Console.ReadLine();
        }
    }
}
