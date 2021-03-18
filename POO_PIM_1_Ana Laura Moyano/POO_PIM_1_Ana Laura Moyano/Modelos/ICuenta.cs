
//Interfaz de cuenta

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PIM_1_Ana_Laura_Moyano.Modelos
{
    public interface ICuenta
    {
        void Debito (decimal monto);
        void Credito(decimal monto);
        void Transferencia(ICuenta destino, decimal monto);
                        
    }
}
