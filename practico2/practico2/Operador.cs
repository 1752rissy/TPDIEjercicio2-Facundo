using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico2
{
    class Operador: IABM1, IAMB2
    {
        string Nombre;
        string Apellido;
        string Dni;

        public string buscar()
        {
            return "Buscando operador";
        }

        public string Eliminar()
        {
            return "Eliminando Operador";
        }

        public string Insertar()
        {
            return "Insertando operador";
        }

        public string Modificar()
        {
            return "Modificando Operador";
        }

        public string Obtener()
        {
            return "Obteniendo operador";
        }

        public string Ontenerultimo()
        {
            return "Obteniendo ultimo operador";
        }
    }
}
