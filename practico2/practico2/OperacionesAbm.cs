using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practico2
{
    class OperacionesAbm
    {
        private readonly IABM1 _iabm1;

        public OperacionesAbm(IABM1 opabm)
        {
            _iabm1 = opabm;
        }
        public  string modificaciones()
        {
            return _iabm1.Modificar();
        }

        public string eliminacion()
        {
            return _iabm1.Eliminar();

        }
    }
}
