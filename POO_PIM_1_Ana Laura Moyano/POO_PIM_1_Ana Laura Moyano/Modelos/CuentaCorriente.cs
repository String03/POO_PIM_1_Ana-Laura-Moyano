
//Clase de Cueta Corriente

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PIM_1_Ana_Laura_Moyano.Modelos
{
    class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(Titular titular, int id) : base(titular, id)
        {

        }

        public CuentaCorriente(decimal saldo, decimal descubierto, List<Titular> titulares, int id, Titular titular) : base(saldo, descubierto, titulares, id, titular)
        {
        }

        public void ActualizarDescubierto(decimal descubierto)
        {
            this.descubierto = descubierto;
        }

        public override void Debito(decimal monto)
        {
            if (saldo < monto)
            {

                if (Descubierto + Saldo <= monto)
                {
                    throw new Excepciones.NoHayDineroException();
                }
            }

            this.saldo -= monto;

        }
    }
}
