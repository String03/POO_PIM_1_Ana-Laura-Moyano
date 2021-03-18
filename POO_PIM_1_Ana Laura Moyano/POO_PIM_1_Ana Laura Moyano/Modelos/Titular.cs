using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PIM_1_Ana_Laura_Moyano.Modelos
{
    public class Titular : IComparable
    {
        public string Tipo_documento { get; set; }
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public List<Cuenta> Cuentas { get; } = new List<Cuenta>();

        public override string ToString()
        {
            return Nombre.Trim() + " " + Apellido.Trim();
        }

        public int CompareTo(object obj)
        {
            return (obj is Titular) ? this.Documento - (obj as Titular).Documento : -1;
        }

        public override bool Equals(object obj)
        {
            if (obj is Titular)
            {
                var t1 = this.Documento == (obj as Titular).Documento;
                var t2 = this.Tipo_documento.Equals((obj as Titular).Tipo_documento);
                return t1 && t2;
            }
            else
                return false;
        }
    }
}
