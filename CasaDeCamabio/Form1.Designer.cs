
namespace CasaDeCamabio
{
    partial class wCasaDeCambio
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.lblaApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.grpTipoDeMoneda = new System.Windows.Forms.GroupBox();
            this.rdbBTC = new System.Windows.Forms.RadioButton();
            this.rdbCheque = new System.Windows.Forms.RadioButton();
            this.rdbtransferencia = new System.Windows.Forms.RadioButton();
            this.rdbEfectivo = new System.Windows.Forms.RadioButton();
            this.cmbMonedaDestino = new System.Windows.Forms.ComboBox();
            this.cmbMonedaOrigen = new System.Windows.Forms.ComboBox();
            this.lblMonedaDestino = new System.Windows.Forms.Label();
            this.lblMonedaOrigen = new System.Windows.Forms.Label();
            this.grpConversion = new System.Windows.Forms.GroupBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.txtCanje = new System.Windows.Forms.TextBox();
            this.lblCanje = new System.Windows.Forms.Label();
            this.txtCantidadValor = new System.Windows.Forms.TextBox();
            this.lblCantidadValorAcambiar = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.grpDatosPersonales.SuspendLayout();
            this.grpTipoDeMoneda.SuspendLayout();
            this.grpConversion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(87, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(39, 57);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(52, 13);
            this.lbldireccion.TabIndex = 2;
            this.lbldireccion.Text = "Direccion";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(98, 57);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 20);
            this.txtdireccion.TabIndex = 3;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(42, 95);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 4;
            this.lblCiudad.Text = "Ciudad";
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(98, 86);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cmbCiudad.TabIndex = 5;
            // 
            // lblaApellido
            // 
            this.lblaApellido.AutoSize = true;
            this.lblaApellido.Location = new System.Drawing.Point(360, 21);
            this.lblaApellido.Name = "lblaApellido";
            this.lblaApellido.Size = new System.Drawing.Size(44, 13);
            this.lblaApellido.TabIndex = 6;
            this.lblaApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(411, 21);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(363, 57);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(419, 56);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.txtTelefono);
            this.grpDatosPersonales.Controls.Add(this.lblTelefono);
            this.grpDatosPersonales.Controls.Add(this.txtApellido);
            this.grpDatosPersonales.Controls.Add(this.lblaApellido);
            this.grpDatosPersonales.Controls.Add(this.cmbCiudad);
            this.grpDatosPersonales.Controls.Add(this.lblCiudad);
            this.grpDatosPersonales.Controls.Add(this.txtdireccion);
            this.grpDatosPersonales.Controls.Add(this.lbldireccion);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(30, 24);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(580, 130);
            this.grpDatosPersonales.TabIndex = 10;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // grpTipoDeMoneda
            // 
            this.grpTipoDeMoneda.Controls.Add(this.rdbBTC);
            this.grpTipoDeMoneda.Controls.Add(this.rdbCheque);
            this.grpTipoDeMoneda.Controls.Add(this.rdbtransferencia);
            this.grpTipoDeMoneda.Controls.Add(this.rdbEfectivo);
            this.grpTipoDeMoneda.Controls.Add(this.cmbMonedaDestino);
            this.grpTipoDeMoneda.Controls.Add(this.cmbMonedaOrigen);
            this.grpTipoDeMoneda.Controls.Add(this.lblMonedaDestino);
            this.grpTipoDeMoneda.Controls.Add(this.lblMonedaOrigen);
            this.grpTipoDeMoneda.Location = new System.Drawing.Point(26, 194);
            this.grpTipoDeMoneda.Name = "grpTipoDeMoneda";
            this.grpTipoDeMoneda.Size = new System.Drawing.Size(295, 192);
            this.grpTipoDeMoneda.TabIndex = 11;
            this.grpTipoDeMoneda.TabStop = false;
            this.grpTipoDeMoneda.Text = "Tipo De Moneda";
            // 
            // rdbBTC
            // 
            this.rdbBTC.AutoSize = true;
            this.rdbBTC.Location = new System.Drawing.Point(124, 136);
            this.rdbBTC.Name = "rdbBTC";
            this.rdbBTC.Size = new System.Drawing.Size(46, 17);
            this.rdbBTC.TabIndex = 8;
            this.rdbBTC.TabStop = true;
            this.rdbBTC.Text = "BTC";
            this.rdbBTC.UseVisualStyleBackColor = true;
            // 
            // rdbCheque
            // 
            this.rdbCheque.AutoSize = true;
            this.rdbCheque.Location = new System.Drawing.Point(21, 136);
            this.rdbCheque.Name = "rdbCheque";
            this.rdbCheque.Size = new System.Drawing.Size(62, 17);
            this.rdbCheque.TabIndex = 7;
            this.rdbCheque.TabStop = true;
            this.rdbCheque.Text = "Cheque";
            this.rdbCheque.UseVisualStyleBackColor = true;
            // 
            // rdbtransferencia
            // 
            this.rdbtransferencia.AutoSize = true;
            this.rdbtransferencia.Location = new System.Drawing.Point(124, 112);
            this.rdbtransferencia.Name = "rdbtransferencia";
            this.rdbtransferencia.Size = new System.Drawing.Size(90, 17);
            this.rdbtransferencia.TabIndex = 6;
            this.rdbtransferencia.TabStop = true;
            this.rdbtransferencia.Text = "Transferencia";
            this.rdbtransferencia.UseVisualStyleBackColor = true;
            // 
            // rdbEfectivo
            // 
            this.rdbEfectivo.AutoSize = true;
            this.rdbEfectivo.Location = new System.Drawing.Point(24, 112);
            this.rdbEfectivo.Name = "rdbEfectivo";
            this.rdbEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbEfectivo.TabIndex = 5;
            this.rdbEfectivo.TabStop = true;
            this.rdbEfectivo.Text = "Efectivo";
            this.rdbEfectivo.UseVisualStyleBackColor = true;
            // 
            // cmbMonedaDestino
            // 
            this.cmbMonedaDestino.FormattingEnabled = true;
            this.cmbMonedaDestino.Location = new System.Drawing.Point(111, 67);
            this.cmbMonedaDestino.Name = "cmbMonedaDestino";
            this.cmbMonedaDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaDestino.TabIndex = 4;
            // 
            // cmbMonedaOrigen
            // 
            this.cmbMonedaOrigen.FormattingEnabled = true;
            this.cmbMonedaOrigen.Location = new System.Drawing.Point(103, 34);
            this.cmbMonedaOrigen.Name = "cmbMonedaOrigen";
            this.cmbMonedaOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbMonedaOrigen.TabIndex = 3;
            // 
            // lblMonedaDestino
            // 
            this.lblMonedaDestino.AutoSize = true;
            this.lblMonedaDestino.Location = new System.Drawing.Point(21, 67);
            this.lblMonedaDestino.Name = "lblMonedaDestino";
            this.lblMonedaDestino.Size = new System.Drawing.Size(83, 13);
            this.lblMonedaDestino.TabIndex = 2;
            this.lblMonedaDestino.Text = "Moneda destino";
            // 
            // lblMonedaOrigen
            // 
            this.lblMonedaOrigen.AutoSize = true;
            this.lblMonedaOrigen.Location = new System.Drawing.Point(18, 34);
            this.lblMonedaOrigen.Name = "lblMonedaOrigen";
            this.lblMonedaOrigen.Size = new System.Drawing.Size(78, 13);
            this.lblMonedaOrigen.TabIndex = 0;
            this.lblMonedaOrigen.Text = "Moneda origen";
            // 
            // grpConversion
            // 
            this.grpConversion.Controls.Add(this.btnCambiar);
            this.grpConversion.Controls.Add(this.txtCanje);
            this.grpConversion.Controls.Add(this.lblCanje);
            this.grpConversion.Controls.Add(this.txtCantidadValor);
            this.grpConversion.Controls.Add(this.lblCantidadValorAcambiar);
            this.grpConversion.Location = new System.Drawing.Point(374, 194);
            this.grpConversion.Name = "grpConversion";
            this.grpConversion.Size = new System.Drawing.Size(278, 191);
            this.grpConversion.TabIndex = 12;
            this.grpConversion.TabStop = false;
            this.grpConversion.Text = "Conversion";
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(86, 126);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(80, 26);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // txtCanje
            // 
            this.txtCanje.Location = new System.Drawing.Point(88, 72);
            this.txtCanje.Name = "txtCanje";
            this.txtCanje.Size = new System.Drawing.Size(100, 20);
            this.txtCanje.TabIndex = 3;
            // 
            // lblCanje
            // 
            this.lblCanje.AutoSize = true;
            this.lblCanje.Location = new System.Drawing.Point(32, 75);
            this.lblCanje.Name = "lblCanje";
            this.lblCanje.Size = new System.Drawing.Size(34, 13);
            this.lblCanje.TabIndex = 2;
            this.lblCanje.Text = "Canje";
            // 
            // txtCantidadValor
            // 
            this.txtCantidadValor.Location = new System.Drawing.Point(149, 31);
            this.txtCantidadValor.Name = "txtCantidadValor";
            this.txtCantidadValor.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadValor.TabIndex = 1;
            // 
            // lblCantidadValorAcambiar
            // 
            this.lblCantidadValorAcambiar.AutoSize = true;
            this.lblCantidadValorAcambiar.Location = new System.Drawing.Point(19, 33);
            this.lblCantidadValorAcambiar.Name = "lblCantidadValorAcambiar";
            this.lblCantidadValorAcambiar.Size = new System.Drawing.Size(124, 13);
            this.lblCantidadValorAcambiar.TabIndex = 0;
            this.lblCantidadValorAcambiar.Text = "Cantidad valor a cambiar";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(273, 403);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(120, 31);
            this.btn.TabIndex = 13;
            this.btn.Text = "button1";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // wCasaDeCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.grpConversion);
            this.Controls.Add(this.grpTipoDeMoneda);
            this.Controls.Add(this.grpDatosPersonales);
            this.Name = "wCasaDeCambio";
            this.Text = "Casa de cambio";
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpTipoDeMoneda.ResumeLayout(false);
            this.grpTipoDeMoneda.PerformLayout();
            this.grpConversion.ResumeLayout(false);
            this.grpConversion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label lblaApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.GroupBox grpTipoDeMoneda;
        private System.Windows.Forms.RadioButton rdbBTC;
        private System.Windows.Forms.RadioButton rdbCheque;
        private System.Windows.Forms.RadioButton rdbtransferencia;
        private System.Windows.Forms.RadioButton rdbEfectivo;
        private System.Windows.Forms.ComboBox cmbMonedaDestino;
        private System.Windows.Forms.ComboBox cmbMonedaOrigen;
        private System.Windows.Forms.Label lblMonedaDestino;
        private System.Windows.Forms.Label lblMonedaOrigen;
        private System.Windows.Forms.GroupBox grpConversion;
        private System.Windows.Forms.TextBox txtCantidadValor;
        private System.Windows.Forms.Label lblCantidadValorAcambiar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.TextBox txtCanje;
        private System.Windows.Forms.Label lblCanje;
        private System.Windows.Forms.Button btn;
    }
}

