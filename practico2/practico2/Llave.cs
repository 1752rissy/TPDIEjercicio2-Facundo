using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico2
{
    class Llave : IABM1, IAMB2
    {
        public string buscar()
        {
           return "Buscando llave.";
        }

        public string Eliminar()
        {
            return "Eliminando llave";
        }

        public string Insertar()
        {
            return "Insertar LLave";
        }

        public string Modificar()
        {
            return "Modificando llave";
        }

        public string Obtener()
        {
            return "Obteniendo llave";
        }

        public string Ontenerultimo()
        {
            return "Obteniendo ultima llave";
        }
    }
}
