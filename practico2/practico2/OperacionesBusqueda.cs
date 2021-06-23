using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico2
{
    class OperacionesBusqueda
    {
        private readonly IAMB2 _iabm2;

        public OperacionesBusqueda(IAMB2 opbusqueda)
        {
            _iabm2 = opbusqueda;
        }

        public string busqueda()
        {
            return _iabm2.buscar();

        }

        public string obtención()
        {
            return _iabm2.Obtener();
        }
    }
}
