namespace pryTorresFerrocarril
{
    partial class frmFerro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFerro));
            this.pbTren = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.mtbDistancia = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.lblEstancia = new System.Windows.Forms.Label();
            this.lblBoleto = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTren)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.gbInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTren
            // 
            this.pbTren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbTren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTren.Image = ((System.Drawing.Image)(resources.GetObject("pbTren.Image")));
            this.pbTren.Location = new System.Drawing.Point(-1, -2);
            this.pbTren.Name = "pbTren";
            this.pbTren.Size = new System.Drawing.Size(66, 61);
            this.pbTren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTren.TabIndex = 0;
            this.pbTren.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(74, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(321, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Calculadora de Precios de Boletos";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSubtitulo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSubtitulo.Location = new System.Drawing.Point(75, 33);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(392, 14);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Ingrese los datos del viaje para calcular el precio del boleto de ida y vuelta.";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.maskedTextBox1);
            this.gbDatos.Controls.Add(this.mtbDistancia);
            this.gbDatos.Controls.Add(this.lblDias);
            this.gbDatos.Controls.Add(this.lblDistancia);
            this.gbDatos.Controls.Add(this.lblDatos);
            this.gbDatos.Location = new System.Drawing.Point(-1, 65);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(339, 149);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Sans Serif Collection", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDatos.Location = new System.Drawing.Point(6, 16);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(149, 44);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "📖 Datos del viaje";
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.Location = new System.Drawing.Point(14, 64);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(101, 16);
            this.lblDistancia.TabIndex = 1;
            this.lblDistancia.Text = "Distancia (km):";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(14, 105);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(116, 16);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "Días de estancia:";
            // 
            // mtbDistancia
            // 
            this.mtbDistancia.Location = new System.Drawing.Point(161, 60);
            this.mtbDistancia.Mask = "99999";
            this.mtbDistancia.Name = "mtbDistancia";
            this.mtbDistancia.Size = new System.Drawing.Size(91, 20);
            this.mtbDistancia.TabIndex = 3;
            this.mtbDistancia.ValidatingType = typeof(int);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(161, 101);
            this.maskedTextBox1.Mask = "99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(91, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.lblResultado);
            this.gbInformacion.Controls.Add(this.lblBoleto);
            this.gbInformacion.Controls.Add(this.lblEstancia);
            this.gbInformacion.Controls.Add(this.lblCondicion);
            this.gbInformacion.Controls.Add(this.lblDescuento);
            this.gbInformacion.Controls.Add(this.lblPrecio);
            this.gbInformacion.Controls.Add(this.lblInformacion);
            this.gbInformacion.Location = new System.Drawing.Point(0, 221);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(338, 207);
            this.gbInformacion.TabIndex = 4;
            this.gbInformacion.TabStop = false;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Font = new System.Drawing.Font("Sans Serif Collection", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInformacion.Location = new System.Drawing.Point(9, 16);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(134, 44);
            this.lblInformacion.TabIndex = 0;
            this.lblInformacion.Text = "⛔ Información";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(17, 54);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(125, 13);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "▪︎ Precio por kilómetro: $5";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(17, 76);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(92, 13);
            this.lblDescuento.TabIndex = 2;
            this.lblDescuento.Text = "▪︎ Descuento: 50%";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(17, 99);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(319, 13);
            this.lblCondicion.TabIndex = 3;
            this.lblCondicion.Text = "▪︎ Condición de descuento: Distancia ≥ 100km y estancia ≥ 7 días.";
            // 
            // lblEstancia
            // 
            this.lblEstancia.AutoSize = true;
            this.lblEstancia.Location = new System.Drawing.Point(18, 123);
            this.lblEstancia.Name = "lblEstancia";
            this.lblEstancia.Size = new System.Drawing.Size(154, 13);
            this.lblEstancia.TabIndex = 4;
            this.lblEstancia.Text = "▪︎ Días de estancia entre 1 y 30";
            // 
            // lblBoleto
            // 
            this.lblBoleto.AutoSize = true;
            this.lblBoleto.Location = new System.Drawing.Point(18, 149);
            this.lblBoleto.Name = "lblBoleto";
            this.lblBoleto.Size = new System.Drawing.Size(141, 13);
            this.lblBoleto.TabIndex = 5;
            this.lblBoleto.Text = "▪︎ El boleto es de ida y vuelta";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(18, 175);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(300, 13);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "▪︎ El resultado del cálculo se muestra en el panel de la derecha";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Sans Serif Collection", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(8, 452);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(146, 34);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "🔄 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Sans Serif Collection", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(175, 452);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(161, 34);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "🖩 Calcular Precio";
            this.btnCalcular.UseVisualStyleBackColor = false;
            // 
            // frmFerro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 594);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbTren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFerro";
            this.Text = "Ferrocarril 🚆";
            ((System.ComponentModel.ISupportInitialize)(this.pbTren)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbInformacion.ResumeLayout(false);
            this.gbInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTren;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox mtbDistancia;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblBoleto;
        private System.Windows.Forms.Label lblEstancia;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
    }
}

