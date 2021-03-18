using POO_PIM_1_Ana_Laura_Moyano.Modelos.EventsArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PIM_1_Ana_Laura_Moyano.Modelos
{
    public abstract class Cuenta : ICuenta, IComparable
    {
        protected decimal saldo = 0;
        protected decimal descubierto = 0;

        public List<Titular> Titulares { get; } = new List<Titular>();
        public decimal Saldo { get { return this.saldo; } }
        public int Id { get; set; }
        public Titular Titular { get; set; }
        public decimal Descubierto{ get { return this.descubierto; } }

        public event EventHandler DepositoMasDeMilPesos;
        public event EventHandler TransferenciaMasDeMilPesos;

        public Cuenta(Titular titular, int id)
        {
            this.Titular = titular;
            this.Id = id;
            this.Titulares.Add(titular);
        }

        protected Cuenta(decimal saldo, decimal descubierto, List<Titular> titulares, int id, Titular titular)
        {
            this.saldo = saldo;
            this.descubierto = descubierto;
            Titulares = titulares;
            Id = id;
            Titular = titular;
        }

        public virtual void Debito(decimal monto)
        {
            if (saldo < monto)
            {
                throw new Excepciones.NoHayDineroException();

            }
            this.saldo -= monto;
        }

        public virtual void Credito(decimal monto)
        {
            this.saldo += monto;
            if (monto > 1000)
            {
                var e = new CuentaEventArgs();
                e.Id = this.Id;
                e.Monto = monto;
                DispararEventoDeposito(e);
            }
        }

        protected void DispararEventoDeposito(CuentaEventArgs e)
        {
            var handler = DepositoMasDeMilPesos;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected void DispararEventoTransferencia(CuentaEventArgs e)
        {
            var handler = TransferenciaMasDeMilPesos;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public virtual void Transferencia(ICuenta destino, decimal monto)
        {
            this.Debito(monto);
            if (monto > 1000)
            {
                var e = new CuentaEventArgs();
                e.Id = this.Id;
                e.Monto = monto;
                DispararEventoTransferencia(e);
            }
            destino.Credito(monto);
        }

        public int CompareTo(object obj)
        {
            return (obj is Cuenta) ? this.Id - (obj as Cuenta).Id : -1;
        }

        public override bool Equals(object obj)
        {
            return (obj is Cuenta) ? this.Id == (obj as Cuenta).Id : false;
        }
    }
}
