
//Nota: Para dar de baja/modificar titulares/clientes se debe hacer doble clic en la grilla correspondiente

using POO_PIM_1_Ana_Laura_Moyano.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using POO_PIM_1_Ana_Laura_Moyano.Modelos.Excepciones;
using POO_PIM_1_Ana_Laura_Moyano.Modelos.EventsArgs;

namespace POO_PIM_1_Ana_Laura_Moyano
{
    public partial class Form1 : Form
    {
        private List<Titular> titulares = new List<Titular>();
        private List<Cuenta> cuentas = new List<Cuenta>();
        public Form1()
        {
            InitializeComponent();
            Iniciar();


        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbo_tipo_doc.SelectedIndex = 0;
        }

        private void DepositoMayor(EventArgs eventArgs)
        {
            var cuentaEventArgs = eventArgs as CuentaEventArgs;
            MessageBox.Show(this, string.Format("Se ha realizado deposito mayor de 1000 AR$. Monto: {0} - Cuenta: {1}", cuentaEventArgs.Monto, cuentaEventArgs.Id));
        }

        private void TransferenciaMayor(EventArgs eventArgs)
        {
            var cuentaEventArgs = eventArgs as CuentaEventArgs;
            MessageBox.Show(this, string.Format("Se ha realizado transferencia mayor de 1000 AR$. Monto: {0} - Cuenta Origen: {1}", cuentaEventArgs.Monto, cuentaEventArgs.Id));
        }

        private void Iniciar()
        {
            var titular1 = new Titular
            {
                Tipo_documento = "DNI",
                Documento = 40500060,
                Apellido = "Moyano",
                Nombre = "Laura"
            };

            var titular2 = new Titular
            {
                Tipo_documento = "DNI",
                Documento = 30300200,
                Apellido = "Moyano",
                Nombre = "Ana "
            };

            titulares.Add(titular1);
            titulares.Add(titular2);

            this.dataGridView1.DataSource = titulares;

            var cuenta1 = new CuentaAhorro(titular1, 1);
            var cuenta2 = new CuentaAhorro(titular2, 2);
            var cuenta3 = new CuentaCorriente(titular1, 3);

            cuenta3.ActualizarDescubierto(1000);

            cuenta1.DepositoMasDeMilPesos += (s, o) => DepositoMayor(o);
            cuenta2.DepositoMasDeMilPesos += (s, o) => DepositoMayor(o);
            cuenta3.DepositoMasDeMilPesos += (s, o) => DepositoMayor(o);

            cuenta1.TransferenciaMasDeMilPesos += (s, o) => TransferenciaMayor(o);
            cuenta2.TransferenciaMasDeMilPesos += (s, o) => TransferenciaMayor(o);
            cuenta3.TransferenciaMasDeMilPesos += (s, o) => TransferenciaMayor(o);

            titular1.Cuentas.Add(cuenta1);
            titular2.Cuentas.Add(cuenta2);
            titular1.Cuentas.Add(cuenta3);

            cuentas.Add(cuenta1);
            cuentas.Add(cuenta3);
            cuentas.Add(cuenta2);

            this.dataGridView2.DataSource = cuentas;
        }

        private void btn_agregar_titular_Click(object sender, EventArgs e)
        {
            try
            {
                Titular titular;

                try
                {
                    titular = new Titular
                    {
                        Tipo_documento = cbo_tipo_doc.SelectedItem.ToString(),
                        Documento = Convert.ToInt32(Interaction.InputBox(string.Format("Número de {0}:", cbo_tipo_doc.SelectedItem.ToString()))),
                        Nombre = Interaction.InputBox("Nombre").Trim(),
                        Apellido = Interaction.InputBox("Apellido").Trim()
                    };
                    if (string.IsNullOrEmpty(titular.Nombre) || string.IsNullOrEmpty(titular.Apellido) || titular.Documento < 0)
                        throw new Exception();
                }
                catch
                {
                    throw new Exception("Datos no aceptables para un titular");
                }


                if (this.titulares.Contains(titular))
                    throw new Exception("No se puede agregar. Ya existe un titular con ese legajo.");


                this.titulares.Add(titular);
                RefrescarGrilla1();

                this.dataGridView1.EndEdit();
                this.dataGridView1.Update();
                this.dataGridView1.Refresh();
                this.Refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }

        }

        private void RefrescarGrilla1()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.titulares;
        }

        private void btn_agregar_cuenta_Click(object sender, EventArgs e)
        {
            try
            {
                Titular titular;
                try
                {
                    titular = (Titular)this.dataGridView1.SelectedRows[0].DataBoundItem;
                }
                catch
                {
                    throw new Exception("Debe de seleccionar un titular para agregarle una cuenta");
                }

                string cuentaStr = Interaction.InputBox("Numero de cuenta").Trim();
                string saldoStr = Interaction.InputBox("Saldo inicial").Trim();
                int cuentaId;
                decimal saldo = 0.00M;

                try
                {
                    cuentaId = Convert.ToInt32(cuentaStr);
                    saldo = Convert.ToDecimal(saldoStr);
                    if (saldo < 0)
                        throw new Exception();
                }
                catch
                {
                    throw new Exception("Formato de cuenta no aceptable.");
                }

                Cuenta cuenta;
                if (rdo_cta_cte.Checked)
                {
                    cuenta = new CuentaCorriente(titular, cuentaId);
                    var descubiertoStr = Interaction.InputBox("Introduzca descubiero").Trim();
                    try
                    {
                        var descubierto = Convert.ToDecimal(descubiertoStr);
                        if (descubierto < 0)
                            throw new Exception();
                        (cuenta as CuentaCorriente).ActualizarDescubierto(descubierto);
                    }
                    catch
                    {
                        throw new Exception("El descubierto no es valido");
                    }
                }
                else
                {
                    cuenta = new CuentaAhorro(titular, cuentaId);
                }

                if (cuentas.Contains(cuenta))
                    throw new Exception("Esta numero de cuenta ya existe.");

                cuenta.Credito(saldo);
                cuenta.DepositoMasDeMilPesos += (s, o) => DepositoMayor(o);
                cuenta.TransferenciaMasDeMilPesos += (s, o) => TransferenciaMayor(o);
                cuentas.Add(cuenta);
                titular.Cuentas.Add(cuenta);
                RefrescarGrilla2();
                RefrescarGrilla3(titular);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void RefrescarGrilla3(Titular titular)
        {
            this.dataGridView3.DataSource = null;
            this.dataGridView3.DataSource = titular.Cuentas.ToList();
        }

        private void RefrescarGrilla2()
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = cuentas;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Titular titular = (Titular)this.dataGridView1.SelectedRows[0].DataBoundItem;
                RefrescarGrilla3(titular);
            }
            catch (Exception ex)
            {
                this.dataGridView3.DataSource = null;
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Cuenta cuenta = (Cuenta)this.dataGridView2.SelectedRows[0].DataBoundItem;
                RefrescarGrilla4(cuenta);
            }
            catch (Exception ex)
            {
                this.dataGridView4.DataSource = null;
            }
        }

        private void RefrescarGrilla4(Cuenta cuenta)
        {
            this.dataGridView4.DataSource = null;
            this.dataGridView4.DataSource = cuenta.Titulares.ToList();
        }

        private void btn_agregar_titular_2_Click(object sender, EventArgs e)
        {
            try
            {
                Titular titular;
                Cuenta cuenta;
                try
                {
                    titular = (Titular)this.dataGridView1.SelectedRows[0].DataBoundItem;
                    cuenta = (Cuenta)this.dataGridView2.SelectedRows[0].DataBoundItem;
                }
                catch
                {
                    throw new Exception("Debe seleccionar un titular y una cuenta");
                }

                if (titular.Cuentas.Contains(cuenta))
                    throw new Exception("Es titular ya posee esta cuenta");

                cuenta.Titulares.Add(titular);

                RefrescarGrilla4(cuenta);
                RefrescarGrilla3(titular);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_credito_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta cuenta = (Cuenta)this.dataGridView2.SelectedRows[0].DataBoundItem;
                cuenta.Credito(Convert.ToDecimal(Interaction.InputBox("Monto a ingresar")));
                this.dataGridView2.DataSource = null;
                this.dataGridView2.DataSource = this.cuentas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_debito_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta cuenta = (Cuenta)this.dataGridView2.SelectedRows[0].DataBoundItem;
                cuenta.Debito(Convert.ToDecimal(Interaction.InputBox("Monto a ingresar")));
                this.dataGridView2.DataSource = null;
                this.dataGridView2.DataSource = this.cuentas;
            }
            catch (NoHayDineroException ex)
            {
                MessageBox.Show(this, "no hay fondos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_descubierto_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta cuenta = (Cuenta)this.dataGridView2.SelectedRows[0].DataBoundItem;
                if (cuenta is CuentaCorriente)
                {
                    var CC = ((CuentaCorriente)cuenta);
                    CC.ActualizarDescubierto(Convert.ToDecimal(Interaction.InputBox(String.Format("Monto (Monto Actual: {0}): ", CC.Descubierto))));
                }
                else
                {
                    throw new InvalidOperationException("No es cuenta corriente ");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(this, ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_transferencia_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta cuenta1 = (Cuenta)this.dataGridView2.SelectedRows[0].DataBoundItem;
                string cuentaDestinoStr, montoStr;
                int cuentaDestino;
                decimal monto;
                try
                {
                    cuentaDestinoStr = Interaction.InputBox("Introduzca no. cuenta destino");
                    cuentaDestino = Convert.ToInt32(cuentaDestinoStr);
                }
                catch
                {
                    throw new Exception("Mal formato de cuenta");
                }
                Cuenta cuenta2 = cuentas.Find(c => c.Id == cuentaDestino);
                if (cuentaDestino == cuenta1.Id)
                    throw new Exception("Cuenta origen es la misma que destino");
                if (cuenta2 == null)
                    throw new Exception("La cuenta no existe");

                try
                {
                    montoStr = Interaction.InputBox("Indroduzca el monto");
                    monto = Convert.ToDecimal(montoStr);
                    if (monto < 0)
                        throw new Exception();
                }
                catch
                {
                    throw new Exception("Monto no valido");
                }

                cuenta1.Transferencia(cuenta2, monto);
                RefrescarGrilla2();
            }
            catch (NoHayDineroException ex)
            {
                MessageBox.Show(this, "no hay fondos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Titular titular = (Titular)this.dataGridView1.SelectedRows[0].DataBoundItem;
                var resultado = MessageBox.Show(this, "¿desea eliminar este registro?", " ", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    titulares.Remove(titular);
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.DataSource = titulares;
                    return;
                }

                titular.Tipo_documento = Interaction.InputBox("Tipo de Documento");
                titular.Documento = Convert.ToInt32(Interaction.InputBox("Número de DNI"));
                titular.Nombre = Interaction.InputBox("Nombre");
                titular.Apellido = Interaction.InputBox("Apellido");

                RefrescarGrilla1();
            }
            catch (Exception ex)
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = titulares;
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Cuenta cuenta = (Cuenta)this.dataGridView2.SelectedRows[0].DataBoundItem;

                var resultado = MessageBox.Show(this, "¿desea eliminar este registro?", " ", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    cuentas.Remove(cuenta);
                    this.dataGridView2.DataSource = null;
                    this.dataGridView2.DataSource = cuentas;
                    return;
                }

                cuenta.Id = Convert.ToInt32(Interaction.InputBox("ID"));

                RefrescarGrilla2();
            }
            catch (Exception ex)
            {
                this.dataGridView2.DataSource = null;
                this.dataGridView2.DataSource = cuentas;
            }
        }

        private void btn_eliminar_titular_Click(object sender, EventArgs e)
        {
            try
            {
                Titular titular = (Titular)this.dataGridView1.SelectedRows[0].DataBoundItem;
                titulares.Remove(titular);
                foreach (var cuenta in cuentas) {
                    cuenta.Titulares.Remove(titular);
                    if (cuenta.Titular == titular)
                        cuenta.Titular = null;
                }

                RefrescarGrilla1();
                RefrescarGrilla2();
                RefrescarGrilla3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void RefrescarGrilla3()
        {
            try
            {
                this.dataGridView3.DataSource = null;
                this.dataGridView3.DataSource = (dataGridView1.SelectedRows[0].DataBoundItem as Titular).Cuentas.ToList();
            }
            catch { }
        }

        private void btn_eliminar_cuenta_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta cuenta = (Cuenta)this.dataGridView2.SelectedRows[0].DataBoundItem;
                cuentas.Remove(cuenta);
                foreach (var titular in titulares)
                    titular.Cuentas.Remove(cuenta);

                RefrescarGrilla2();
                RefrescarGrilla3();
                RefrescarGrilla4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void RefrescarGrilla4()
        {
            try
            {
                dataGridView4.DataSource = null;
                dataGridView4.DataSource = (dataGridView2.SelectedRows[0].DataBoundItem as Cuenta).Titulares.ToList();
            }
            catch { }
        }

        private void btn_modificar_titular_Click(object sender, EventArgs e)
        {
            try
            {
                Titular titular;
                try
                {
                    titular = (Titular)this.dataGridView1.SelectedRows[0].DataBoundItem;
                }
                catch
                {
                    throw new Exception("Debe elegir a un titular");
                }

                string tipoDocumento;
                string documentoStr;
                int documento = 0;
                try
                {
                    tipoDocumento = cbo_tipo_doc.SelectedItem.ToString();
                    documentoStr = Interaction.InputBox("Número de " + cbo_tipo_doc.SelectedItem.ToString()).Trim();
                    if (!string.IsNullOrEmpty(documentoStr))
                        documento = Convert.ToInt32(documentoStr);
                    if (documento < 0)
                        throw new Exception();
                }
                catch
                {
                    throw new Exception("Mal formato de documento.");
                }

                if (titulares.Any(t => t.Documento == documento && t.Tipo_documento == tipoDocumento) && !string.IsNullOrWhiteSpace(documentoStr))
                    throw new Exception("Este documento ya existe para un titutar.");

                if (!string.IsNullOrEmpty(documentoStr))
                    titular.Documento = documento;

                var nombre = Interaction.InputBox("Nombre");
                var apellido = Interaction.InputBox("Apellido");

                titular.Tipo_documento = tipoDocumento;

                if (!string.IsNullOrEmpty(nombre.Trim()))
                    titular.Nombre = nombre;

                if (!string.IsNullOrEmpty(apellido.Trim()))
                    titular.Apellido = apellido;
                MessageBox.Show("Titular modificado exitosamente");

                RefrescarGrilla1();
                RefrescarGrilla2();
                RefrescarGrilla4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_modificar_cuenta_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta cuenta;
                Titular titular;
                string cuentaStr, descubiertoStr;
                decimal saldo, descubierto = 0.00M;
                int cuentaId = 0;
                try
                {
                    cuenta = (Cuenta)this.dataGridView2.SelectedRows[0].DataBoundItem;
                }
                catch
                {
                    throw new Exception("Debe elegir una cuenta");
                }

                saldo = cuenta.Saldo;

                try
                {
                    titular = (Titular)this.dataGridView1.SelectedRows[0].DataBoundItem;
                }
                catch
                {
                    throw new Exception("Debe elegir a un titular para asignarselo al cambio de la cuenta");
                }

                cuentaStr = Interaction.InputBox("No. cuenta: (En blanco para preservar)").Trim();

                try
                {
                    if (!string.IsNullOrEmpty(cuentaStr))
                    {
                        cuentaId = Convert.ToInt32(cuentaStr);
                        if (cuentaId < 0)
                            throw new Exception();
                    }
                    else
                        cuentaId = cuenta.Id;

                }
                catch
                {
                    throw new Exception("No. cuenta no valido.");
                }

                if (cuentas.Any(c => c.Id == cuentaId) && !string.IsNullOrEmpty(cuentaStr))
                    throw new Exception("Este no. de cuenta ya existe.");

                if (!rdo_cta_ahorro.Checked)
                {
                    descubiertoStr = Interaction.InputBox("Descubierto: (Dejar en blanco para preservar)");

                    try
                    {
                        if (!string.IsNullOrEmpty(descubiertoStr))
                            descubierto = Convert.ToDecimal(descubiertoStr);
                        else
                            descubierto = cuenta.Descubierto;
                        if (descubierto < 0)
                            throw new Exception();
                    }
                    catch
                    {
                        throw new Exception("Mal formato para descubierto");
                    }
                }

                var titularesRelacionados = titulares.Where(t => t.Cuentas.Contains(cuenta)).ToList();

                titularesRelacionados.ForEach(t => t.Cuentas.Remove(cuenta));

                if (rdo_cta_ahorro.Checked)
                {
                    if (cuenta is CuentaCorriente)
                    {
                        cuentas.Remove(cuenta);
                        titularesRelacionados.ForEach(t => t.Cuentas.Remove(cuenta));
                        cuenta = new CuentaAhorro(saldo, 0, cuenta.Titulares, cuentaId, titular);
                        cuenta.DepositoMasDeMilPesos += (s, o) => DepositoMayor(o);
                        cuenta.TransferenciaMasDeMilPesos += (s, o) => TransferenciaMayor(o);
                        cuentas.Add(cuenta);
                    }
                    else
                    {
                        cuenta.Titular = titular;
                    }
                }
                else
                {
                    if (cuenta is CuentaAhorro)
                    {
                        cuentas.Remove(cuenta);
                        titularesRelacionados.ForEach(t => t.Cuentas.Remove(cuenta));
                        cuenta = new CuentaCorriente(saldo, descubierto, cuenta.Titulares, cuentaId, titular);
                        cuenta.DepositoMasDeMilPesos += (s, o) => DepositoMayor(o);
                        cuenta.TransferenciaMasDeMilPesos += (s, o) => TransferenciaMayor(o);
                        cuentas.Add(cuenta);
                    }
                    else
                    {
                        (cuenta as CuentaCorriente).ActualizarDescubierto(descubierto);
                        cuenta.Titular = titular;
                    }
                }

                cuenta.Id = cuentaId;
                titular.Cuentas.Add(cuenta);

                MessageBox.Show("Cuenta modificada exitosamente");

                RefrescarGrilla2();
                RefrescarGrilla3(titular);
                RefrescarGrilla4();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }
    }
}
