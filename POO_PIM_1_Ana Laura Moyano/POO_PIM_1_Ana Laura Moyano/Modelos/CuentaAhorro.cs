
//Caja de ahorro

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PIM_1_Ana_Laura_Moyano.Modelos
{
    class CuentaAhorro : Cuenta 
    {
        public CuentaAhorro(Titular titular, int id) : base (titular,id) 
        {

        }

        public CuentaAhorro(decimal saldo, decimal descubierto, List<Titular> titulares, int id, Titular titular) : base(saldo, 0, titulares, id, titular)
        {
        }
    }
}
