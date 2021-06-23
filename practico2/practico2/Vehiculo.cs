using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico2
{
    class Vehiculo : IABM1, IAMB2
    {
        public string buscar()
        {
            return "Buscando vehiculo";
        }

        public string Eliminar()
        {
           return "Eliminando vehiculo";
        }

        public string Insertar()
        {
           return "Insertando vehiculo";
        }

        public string Modificar()
        {
            return "Modificando Vehiculo";

        }

        public string Obtener()
        {
            return "Obteniendo Vehiculo";
        }

        public string Ontenerultimo()
        {
            return "Obteniendo ultimo vehiculo";
        }
    }
}
