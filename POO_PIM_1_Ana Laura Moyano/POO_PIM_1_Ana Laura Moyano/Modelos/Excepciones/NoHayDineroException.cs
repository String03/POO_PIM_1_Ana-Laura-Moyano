using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PIM_1_Ana_Laura_Moyano.Modelos.Excepciones
{
    public class NoHayDineroException : Exception
    {
        public NoHayDineroException() : base ("Saldo no suficiente")
        {

        }
    }
}
