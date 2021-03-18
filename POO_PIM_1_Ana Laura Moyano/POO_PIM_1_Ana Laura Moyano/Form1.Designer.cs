namespace POO_PIM_1_Ana_Laura_Moyano
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.rdo_cta_cte = new System.Windows.Forms.RadioButton();
            this.rdo_cta_ahorro = new System.Windows.Forms.RadioButton();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_agregar_titular = new System.Windows.Forms.Button();
            this.btn_agregar_cuenta = new System.Windows.Forms.Button();
            this.btn_agregar_titular_2 = new System.Windows.Forms.Button();
            this.btn_credito = new System.Windows.Forms.Button();
            this.btn_debito = new System.Windows.Forms.Button();
            this.btn_descubierto = new System.Windows.Forms.Button();
            this.btn_transferencia = new System.Windows.Forms.Button();
            this.cbo_tipo_doc = new System.Windows.Forms.ComboBox();
            this.btn_eliminar_cuenta = new System.Windows.Forms.Button();
            this.btn_eliminar_titular = new System.Windows.Forms.Button();
            this.btn_modificar_titular = new System.Windows.Forms.Button();
            this.btn_modificar_cuenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(264, 157);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Titulares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Cuentas";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(513, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(264, 157);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "3. Cuentas del titular seleccionado en la grilla 1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(58, 419);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(264, 157);
            this.dataGridView3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(535, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "4. Titulares de la cuenta seleccionada en la grilla 2 (seleccionar titular de la " +
    "grilla 1 para agregar un nuevo titular)";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(508, 424);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(264, 157);
            this.dataGridView4.TabIndex = 7;
            // 
            // rdo_cta_cte
            // 
            this.rdo_cta_cte.AutoSize = true;
            this.rdo_cta_cte.Location = new System.Drawing.Point(886, 179);
            this.rdo_cta_cte.Name = "rdo_cta_cte";
            this.rdo_cta_cte.Size = new System.Drawing.Size(104, 17);
            this.rdo_cta_cte.TabIndex = 8;
            this.rdo_cta_cte.Text = "Cuenta Corriente";
            this.rdo_cta_cte.UseVisualStyleBackColor = true;
            // 
            // rdo_cta_ahorro
            // 
            this.rdo_cta_ahorro.AutoSize = true;
            this.rdo_cta_ahorro.Checked = true;
            this.rdo_cta_ahorro.Location = new System.Drawing.Point(886, 214);
            this.rdo_cta_ahorro.Name = "rdo_cta_ahorro";
            this.rdo_cta_ahorro.Size = new System.Drawing.Size(95, 17);
            this.rdo_cta_ahorro.TabIndex = 9;
            this.rdo_cta_ahorro.TabStop = true;
            this.rdo_cta_ahorro.Text = "Caja de Ahorro";
            this.rdo_cta_ahorro.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(775, 587);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 10;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_agregar_titular
            // 
            this.btn_agregar_titular.Location = new System.Drawing.Point(58, 282);
            this.btn_agregar_titular.Name = "btn_agregar_titular";
            this.btn_agregar_titular.Size = new System.Drawing.Size(93, 23);
            this.btn_agregar_titular.TabIndex = 11;
            this.btn_agregar_titular.Text = "Agregar Titular";
            this.btn_agregar_titular.UseVisualStyleBackColor = true;
            this.btn_agregar_titular.Click += new System.EventHandler(this.btn_agregar_titular_Click);
            // 
            // btn_agregar_cuenta
            // 
            this.btn_agregar_cuenta.Location = new System.Drawing.Point(513, 282);
            this.btn_agregar_cuenta.Name = "btn_agregar_cuenta";
            this.btn_agregar_cuenta.Size = new System.Drawing.Size(104, 23);
            this.btn_agregar_cuenta.TabIndex = 12;
            this.btn_agregar_cuenta.Text = "Agregar Cuenta";
            this.btn_agregar_cuenta.UseVisualStyleBackColor = true;
            this.btn_agregar_cuenta.Click += new System.EventHandler(this.btn_agregar_cuenta_Click);
            // 
            // btn_agregar_titular_2
            // 
            this.btn_agregar_titular_2.Location = new System.Drawing.Point(508, 587);
            this.btn_agregar_titular_2.Name = "btn_agregar_titular_2";
            this.btn_agregar_titular_2.Size = new System.Drawing.Size(88, 23);
            this.btn_agregar_titular_2.TabIndex = 13;
            this.btn_agregar_titular_2.Text = "Agregar Titular";
            this.btn_agregar_titular_2.UseVisualStyleBackColor = true;
            this.btn_agregar_titular_2.Click += new System.EventHandler(this.btn_agregar_titular_2_Click);
            // 
            // btn_credito
            // 
            this.btn_credito.Location = new System.Drawing.Point(642, 282);
            this.btn_credito.Name = "btn_credito";
            this.btn_credito.Size = new System.Drawing.Size(75, 23);
            this.btn_credito.TabIndex = 14;
            this.btn_credito.Text = "Depósito";
            this.btn_credito.UseVisualStyleBackColor = true;
            this.btn_credito.Click += new System.EventHandler(this.btn_credito_Click);
            // 
            // btn_debito
            // 
            this.btn_debito.Location = new System.Drawing.Point(741, 282);
            this.btn_debito.Name = "btn_debito";
            this.btn_debito.Size = new System.Drawing.Size(75, 23);
            this.btn_debito.TabIndex = 15;
            this.btn_debito.Text = "Extracción";
            this.btn_debito.UseVisualStyleBackColor = true;
            this.btn_debito.Click += new System.EventHandler(this.btn_debito_Click);
            // 
            // btn_descubierto
            // 
            this.btn_descubierto.Location = new System.Drawing.Point(840, 282);
            this.btn_descubierto.Name = "btn_descubierto";
            this.btn_descubierto.Size = new System.Drawing.Size(75, 43);
            this.btn_descubierto.TabIndex = 16;
            this.btn_descubierto.Text = "Giro en Descubierto";
            this.btn_descubierto.UseVisualStyleBackColor = true;
            this.btn_descubierto.Click += new System.EventHandler(this.btn_descubierto_Click);
            // 
            // btn_transferencia
            // 
            this.btn_transferencia.Location = new System.Drawing.Point(932, 282);
            this.btn_transferencia.Name = "btn_transferencia";
            this.btn_transferencia.Size = new System.Drawing.Size(90, 23);
            this.btn_transferencia.TabIndex = 17;
            this.btn_transferencia.Text = "Transferencia";
            this.btn_transferencia.UseVisualStyleBackColor = true;
            this.btn_transferencia.Click += new System.EventHandler(this.btn_transferencia_Click);
            // 
            // cbo_tipo_doc
            // 
            this.cbo_tipo_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tipo_doc.FormattingEnabled = true;
            this.cbo_tipo_doc.Items.AddRange(new object[] {
            "DNI",
            "LE",
            "CI"});
            this.cbo_tipo_doc.Location = new System.Drawing.Point(184, 284);
            this.cbo_tipo_doc.Name = "cbo_tipo_doc";
            this.cbo_tipo_doc.Size = new System.Drawing.Size(121, 21);
            this.cbo_tipo_doc.TabIndex = 18;
            // 
            // btn_eliminar_cuenta
            // 
            this.btn_eliminar_cuenta.Location = new System.Drawing.Point(513, 340);
            this.btn_eliminar_cuenta.Name = "btn_eliminar_cuenta";
            this.btn_eliminar_cuenta.Size = new System.Drawing.Size(104, 23);
            this.btn_eliminar_cuenta.TabIndex = 19;
            this.btn_eliminar_cuenta.Text = "Eliminar Cuenta";
            this.btn_eliminar_cuenta.UseVisualStyleBackColor = true;
            this.btn_eliminar_cuenta.Click += new System.EventHandler(this.btn_eliminar_cuenta_Click);
            // 
            // btn_eliminar_titular
            // 
            this.btn_eliminar_titular.Location = new System.Drawing.Point(58, 340);
            this.btn_eliminar_titular.Name = "btn_eliminar_titular";
            this.btn_eliminar_titular.Size = new System.Drawing.Size(93, 23);
            this.btn_eliminar_titular.TabIndex = 20;
            this.btn_eliminar_titular.Text = "Eliminar Titular";
            this.btn_eliminar_titular.UseVisualStyleBackColor = true;
            this.btn_eliminar_titular.Click += new System.EventHandler(this.btn_eliminar_titular_Click);
            // 
            // btn_modificar_titular
            // 
            this.btn_modificar_titular.Location = new System.Drawing.Point(58, 311);
            this.btn_modificar_titular.Name = "btn_modificar_titular";
            this.btn_modificar_titular.Size = new System.Drawing.Size(93, 23);
            this.btn_modificar_titular.TabIndex = 21;
            this.btn_modificar_titular.Text = "Modificar Titular";
            this.btn_modificar_titular.UseVisualStyleBackColor = true;
            this.btn_modificar_titular.Click += new System.EventHandler(this.btn_modificar_titular_Click);
            // 
            // btn_modificar_cuenta
            // 
            this.btn_modificar_cuenta.Location = new System.Drawing.Point(513, 311);
            this.btn_modificar_cuenta.Name = "btn_modificar_cuenta";
            this.btn_modificar_cuenta.Size = new System.Drawing.Size(104, 23);
            this.btn_modificar_cuenta.TabIndex = 22;
            this.btn_modificar_cuenta.Text = "Modificar Cuenta";
            this.btn_modificar_cuenta.UseVisualStyleBackColor = true;
            this.btn_modificar_cuenta.Click += new System.EventHandler(this.btn_modificar_cuenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 640);
            this.Controls.Add(this.btn_modificar_cuenta);
            this.Controls.Add(this.btn_modificar_titular);
            this.Controls.Add(this.btn_eliminar_titular);
            this.Controls.Add(this.btn_eliminar_cuenta);
            this.Controls.Add(this.cbo_tipo_doc);
            this.Controls.Add(this.btn_transferencia);
            this.Controls.Add(this.btn_descubierto);
            this.Controls.Add(this.btn_debito);
            this.Controls.Add(this.btn_credito);
            this.Controls.Add(this.btn_agregar_titular_2);
            this.Controls.Add(this.btn_agregar_cuenta);
            this.Controls.Add(this.btn_agregar_titular);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.rdo_cta_ahorro);
            this.Controls.Add(this.rdo_cta_cte);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.RadioButton rdo_cta_cte;
        private System.Windows.Forms.RadioButton rdo_cta_ahorro;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_agregar_titular;
        private System.Windows.Forms.Button btn_agregar_cuenta;
        private System.Windows.Forms.Button btn_agregar_titular_2;
        private System.Windows.Forms.Button btn_credito;
        private System.Windows.Forms.Button btn_debito;
        private System.Windows.Forms.Button btn_descubierto;
        private System.Windows.Forms.Button btn_transferencia;
        private System.Windows.Forms.ComboBox cbo_tipo_doc;
        private System.Windows.Forms.Button btn_eliminar_cuenta;
        private System.Windows.Forms.Button btn_eliminar_titular;
        private System.Windows.Forms.Button btn_modificar_titular;
        private System.Windows.Forms.Button btn_modificar_cuenta;
    }
}

