using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PIM_1_Ana_Laura_Moyano.Modelos.EventsArgs
{
    public class CuentaEventArgs: EventArgs
    {
        public decimal Monto { get; set; }
        public int Id { get; set; }
    }
}
