namespace EmpresaViaje
{
    partial class ViajesFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViajesFormulario));
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LabelOpciones = new System.Windows.Forms.Label();
            this.BotonBarco = new System.Windows.Forms.Button();
            this.BotonAvion = new System.Windows.Forms.Button();
            this.PictureBoxBarco = new System.Windows.Forms.PictureBox();
            this.ImageBoxAvion = new System.Windows.Forms.PictureBox();
            this.GroupBoxIngresoDatos = new System.Windows.Forms.GroupBox();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.TextBoxValorTransporte = new System.Windows.Forms.TextBox();
            this.TextBoxTasaAero = new System.Windows.Forms.TextBox();
            this.TextBoxValorMinuto = new System.Windows.Forms.TextBox();
            this.TextBoxTotal = new System.Windows.Forms.TextBox();
            this.BotonTotal = new System.Windows.Forms.Button();
            this.LabelValorMinutoVuelo = new System.Windows.Forms.Label();
            this.FechaDeViaje = new System.Windows.Forms.DateTimePicker();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.LabelTransporte = new System.Windows.Forms.Label();
            this.LabelTasaAeropuerto = new System.Windows.Forms.Label();
            this.ListaHabitación = new System.Windows.Forms.ListBox();
            this.LabelHabitacion = new System.Windows.Forms.Label();
            this.ListaCamarote = new System.Windows.Forms.ListBox();
            this.NumericoDiasEstadia = new System.Windows.Forms.NumericUpDown();
            this.LabelCamarote = new System.Windows.Forms.Label();
            this.LabelDiasEstadia = new System.Windows.Forms.Label();
            this.TextBoxTiempoViaje = new System.Windows.Forms.TextBox();
            this.LabelTiempoViaje = new System.Windows.Forms.Label();
            this.TextBoxCedula = new System.Windows.Forms.TextBox();
            this.LabelCedula = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.TextBoxDestino = new System.Windows.Forms.TextBox();
            this.LabelDestino = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBarco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxAvion)).BeginInit();
            this.GroupBoxIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericoDiasEstadia)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(472, 19);
            this.LabelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(115, 19);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "Agencia de viajes";
            // 
            // LabelOpciones
            // 
            this.LabelOpciones.AutoSize = true;
            this.LabelOpciones.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpciones.Location = new System.Drawing.Point(419, 69);
            this.LabelOpciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOpciones.Name = "LabelOpciones";
            this.LabelOpciones.Size = new System.Drawing.Size(221, 19);
            this.LabelOpciones.TabIndex = 1;
            this.LabelOpciones.Text = "¿Que excursión le gustaría realizar?";
            this.LabelOpciones.Click += new System.EventHandler(this.LabelOpciones_Click);
            // 
            // BotonBarco
            // 
            this.BotonBarco.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonBarco.Location = new System.Drawing.Point(167, 91);
            this.BotonBarco.Name = "BotonBarco";
            this.BotonBarco.Size = new System.Drawing.Size(130, 33);
            this.BotonBarco.TabIndex = 2;
            this.BotonBarco.Text = "Barco";
            this.BotonBarco.UseVisualStyleBackColor = false;
            this.BotonBarco.Click += new System.EventHandler(this.BotonBarco_Click);
            // 
            // BotonAvion
            // 
            this.BotonAvion.Location = new System.Drawing.Point(747, 91);
            this.BotonAvion.Name = "BotonAvion";
            this.BotonAvion.Size = new System.Drawing.Size(104, 33);
            this.BotonAvion.TabIndex = 3;
            this.BotonAvion.Text = "Avión";
            this.BotonAvion.UseVisualStyleBackColor = true;
            this.BotonAvion.Click += new System.EventHandler(this.BotonAvion_Click);
            // 
            // PictureBoxBarco
            // 
            this.PictureBoxBarco.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxBarco.Image")));
            this.PictureBoxBarco.Location = new System.Drawing.Point(131, 130);
            this.PictureBoxBarco.Name = "PictureBoxBarco";
            this.PictureBoxBarco.Size = new System.Drawing.Size(195, 130);
            this.PictureBoxBarco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxBarco.TabIndex = 4;
            this.PictureBoxBarco.TabStop = false;
            // 
            // ImageBoxAvion
            // 
            this.ImageBoxAvion.Image = ((System.Drawing.Image)(resources.GetObject("ImageBoxAvion.Image")));
            this.ImageBoxAvion.Location = new System.Drawing.Point(682, 127);
            this.ImageBoxAvion.Name = "ImageBoxAvion";
            this.ImageBoxAvion.Size = new System.Drawing.Size(279, 133);
            this.ImageBoxAvion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBoxAvion.TabIndex = 5;
            this.ImageBoxAvion.TabStop = false;
            this.ImageBoxAvion.Click += new System.EventHandler(this.ImageBoxAvion_Click);
            // 
            // GroupBoxIngresoDatos
            // 
            this.GroupBoxIngresoDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBoxIngresoDatos.Controls.Add(this.BotonEliminar);
            this.GroupBoxIngresoDatos.Controls.Add(this.TextBoxValorTransporte);
            this.GroupBoxIngresoDatos.Controls.Add(this.TextBoxTasaAero);
            this.GroupBoxIngresoDatos.Controls.Add(this.TextBoxValorMinuto);
            this.GroupBoxIngresoDatos.Controls.Add(this.TextBoxTotal);
            this.GroupBoxIngresoDatos.Controls.Add(this.BotonTotal);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelValorMinutoVuelo);
            this.GroupBoxIngresoDatos.Controls.Add(this.FechaDeViaje);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelFecha);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelTransporte);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelTasaAeropuerto);
            this.GroupBoxIngresoDatos.Controls.Add(this.ListaHabitación);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelHabitacion);
            this.GroupBoxIngresoDatos.Controls.Add(this.ListaCamarote);
            this.GroupBoxIngresoDatos.Controls.Add(this.NumericoDiasEstadia);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelCamarote);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelDiasEstadia);
            this.GroupBoxIngresoDatos.Controls.Add(this.TextBoxTiempoViaje);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelTiempoViaje);
            this.GroupBoxIngresoDatos.Controls.Add(this.TextBoxCedula);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelCedula);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelNombre);
            this.GroupBoxIngresoDatos.Controls.Add(this.TextBoxNombre);
            this.GroupBoxIngresoDatos.Controls.Add(this.TextBoxDestino);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelDestino);
            this.GroupBoxIngresoDatos.Location = new System.Drawing.Point(66, 275);
            this.GroupBoxIngresoDatos.Name = "GroupBoxIngresoDatos";
            this.GroupBoxIngresoDatos.Size = new System.Drawing.Size(968, 417);
            this.GroupBoxIngresoDatos.TabIndex = 6;
            this.GroupBoxIngresoDatos.TabStop = false;
            this.GroupBoxIngresoDatos.Text = "Ingreso de Datos";
            this.GroupBoxIngresoDatos.Visible = false;
            this.GroupBoxIngresoDatos.Enter += new System.EventHandler(this.GroupBoxIngresoDatos_Enter);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(810, 48);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(75, 37);
            this.BotonEliminar.TabIndex = 28;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // TextBoxValorTransporte
            // 
            this.TextBoxValorTransporte.Location = new System.Drawing.Point(669, 290);
            this.TextBoxValorTransporte.Name = "TextBoxValorTransporte";
            this.TextBoxValorTransporte.Size = new System.Drawing.Size(100, 26);
            this.TextBoxValorTransporte.TabIndex = 27;
            // 
            // TextBoxTasaAero
            // 
            this.TextBoxTasaAero.Location = new System.Drawing.Point(617, 240);
            this.TextBoxTasaAero.Name = "TextBoxTasaAero";
            this.TextBoxTasaAero.Size = new System.Drawing.Size(100, 26);
            this.TextBoxTasaAero.TabIndex = 26;
            // 
            // TextBoxValorMinuto
            // 
            this.TextBoxValorMinuto.Location = new System.Drawing.Point(218, 353);
            this.TextBoxValorMinuto.Name = "TextBoxValorMinuto";
            this.TextBoxValorMinuto.Size = new System.Drawing.Size(100, 26);
            this.TextBoxValorMinuto.TabIndex = 25;
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.Location = new System.Drawing.Point(678, 354);
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.Size = new System.Drawing.Size(100, 26);
            this.TextBoxTotal.TabIndex = 24;
            this.TextBoxTotal.TextChanged += new System.EventHandler(this.TextBoxTotal_TextChanged);
            // 
            // BotonTotal
            // 
            this.BotonTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BotonTotal.Location = new System.Drawing.Point(440, 353);
            this.BotonTotal.Name = "BotonTotal";
            this.BotonTotal.Size = new System.Drawing.Size(210, 26);
            this.BotonTotal.TabIndex = 23;
            this.BotonTotal.Text = "Calcular Precio";
            this.BotonTotal.UseVisualStyleBackColor = false;
            this.BotonTotal.Click += new System.EventHandler(this.BotonTotal_Click_1);
            // 
            // LabelValorMinutoVuelo
            // 
            this.LabelValorMinutoVuelo.AutoSize = true;
            this.LabelValorMinutoVuelo.Location = new System.Drawing.Point(26, 353);
            this.LabelValorMinutoVuelo.Name = "LabelValorMinutoVuelo";
            this.LabelValorMinutoVuelo.Size = new System.Drawing.Size(175, 19);
            this.LabelValorMinutoVuelo.TabIndex = 21;
            this.LabelValorMinutoVuelo.Text = "Valor del Minuto de Vuelo: ";
            // 
            // FechaDeViaje
            // 
            this.FechaDeViaje.Location = new System.Drawing.Point(131, 284);
            this.FechaDeViaje.Name = "FechaDeViaje";
            this.FechaDeViaje.Size = new System.Drawing.Size(254, 26);
            this.FechaDeViaje.TabIndex = 20;
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Location = new System.Drawing.Point(22, 290);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(103, 19);
            this.LabelFecha.TabIndex = 19;
            this.LabelFecha.Text = "Fecha de Viaje:";
            this.LabelFecha.Click += new System.EventHandler(this.LabelFecha_Click);
            // 
            // LabelTransporte
            // 
            this.LabelTransporte.AutoSize = true;
            this.LabelTransporte.Location = new System.Drawing.Point(417, 288);
            this.LabelTransporte.Name = "LabelTransporte";
            this.LabelTransporte.Size = new System.Drawing.Size(190, 19);
            this.LabelTransporte.TabIndex = 17;
            this.LabelTransporte.Text = "Valor del trasnsporte a muelle:";
            // 
            // LabelTasaAeropuerto
            // 
            this.LabelTasaAeropuerto.AutoSize = true;
            this.LabelTasaAeropuerto.Location = new System.Drawing.Point(475, 242);
            this.LabelTasaAeropuerto.Name = "LabelTasaAeropuerto";
            this.LabelTasaAeropuerto.Size = new System.Drawing.Size(132, 19);
            this.LabelTasaAeropuerto.TabIndex = 15;
            this.LabelTasaAeropuerto.Text = "Tasa Aeroportuaria: ";
            // 
            // ListaHabitación
            // 
            this.ListaHabitación.FormattingEnabled = true;
            this.ListaHabitación.ItemHeight = 19;
            this.ListaHabitación.Items.AddRange(new object[] {
            "Suite\t",
            "Normal"});
            this.ListaHabitación.Location = new System.Drawing.Point(617, 178);
            this.ListaHabitación.Name = "ListaHabitación";
            this.ListaHabitación.Size = new System.Drawing.Size(120, 42);
            this.ListaHabitación.TabIndex = 14;
            // 
            // LabelHabitacion
            // 
            this.LabelHabitacion.AutoSize = true;
            this.LabelHabitacion.Location = new System.Drawing.Point(471, 178);
            this.LabelHabitacion.Name = "LabelHabitacion";
            this.LabelHabitacion.Size = new System.Drawing.Size(131, 19);
            this.LabelHabitacion.TabIndex = 13;
            this.LabelHabitacion.Text = "Tipo de Habitación: ";
            // 
            // ListaCamarote
            // 
            this.ListaCamarote.FormattingEnabled = true;
            this.ListaCamarote.ItemHeight = 19;
            this.ListaCamarote.Items.AddRange(new object[] {
            "Lujo",
            "Normal",
            "Economico"});
            this.ListaCamarote.Location = new System.Drawing.Point(617, 85);
            this.ListaCamarote.Name = "ListaCamarote";
            this.ListaCamarote.Size = new System.Drawing.Size(120, 61);
            this.ListaCamarote.TabIndex = 12;
            // 
            // NumericoDiasEstadia
            // 
            this.NumericoDiasEstadia.Location = new System.Drawing.Point(617, 46);
            this.NumericoDiasEstadia.Name = "NumericoDiasEstadia";
            this.NumericoDiasEstadia.Size = new System.Drawing.Size(120, 26);
            this.NumericoDiasEstadia.TabIndex = 11;
            this.NumericoDiasEstadia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LabelCamarote
            // 
            this.LabelCamarote.AutoSize = true;
            this.LabelCamarote.Location = new System.Drawing.Point(471, 85);
            this.LabelCamarote.Name = "LabelCamarote";
            this.LabelCamarote.Size = new System.Drawing.Size(126, 19);
            this.LabelCamarote.TabIndex = 10;
            this.LabelCamarote.Text = "Tipo de Camarote: ";
            // 
            // LabelDiasEstadia
            // 
            this.LabelDiasEstadia.AutoSize = true;
            this.LabelDiasEstadia.Location = new System.Drawing.Point(471, 46);
            this.LabelDiasEstadia.Name = "LabelDiasEstadia";
            this.LabelDiasEstadia.Size = new System.Drawing.Size(108, 19);
            this.LabelDiasEstadia.TabIndex = 8;
            this.LabelDiasEstadia.Text = "Días de estadia: ";
            // 
            // TextBoxTiempoViaje
            // 
            this.TextBoxTiempoViaje.Location = new System.Drawing.Point(218, 212);
            this.TextBoxTiempoViaje.Name = "TextBoxTiempoViaje";
            this.TextBoxTiempoViaje.Size = new System.Drawing.Size(100, 26);
            this.TextBoxTiempoViaje.TabIndex = 7;
            // 
            // LabelTiempoViaje
            // 
            this.LabelTiempoViaje.AutoSize = true;
            this.LabelTiempoViaje.Location = new System.Drawing.Point(62, 215);
            this.LabelTiempoViaje.Name = "LabelTiempoViaje";
            this.LabelTiempoViaje.Size = new System.Drawing.Size(156, 19);
            this.LabelTiempoViaje.TabIndex = 6;
            this.LabelTiempoViaje.Text = "Tiempo de Viaje (Días): ";
            // 
            // TextBoxCedula
            // 
            this.TextBoxCedula.Location = new System.Drawing.Point(160, 157);
            this.TextBoxCedula.Name = "TextBoxCedula";
            this.TextBoxCedula.Size = new System.Drawing.Size(158, 26);
            this.TextBoxCedula.TabIndex = 5;
            // 
            // LabelCedula
            // 
            this.LabelCedula.AutoSize = true;
            this.LabelCedula.Location = new System.Drawing.Point(58, 157);
            this.LabelCedula.Name = "LabelCedula";
            this.LabelCedula.Size = new System.Drawing.Size(59, 19);
            this.LabelCedula.TabIndex = 4;
            this.LabelCedula.Text = "Cedula: ";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(58, 102);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(67, 19);
            this.LabelNombre.TabIndex = 3;
            this.LabelNombre.Text = "Nombre: ";
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(146, 99);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(158, 26);
            this.TextBoxNombre.TabIndex = 2;
            // 
            // TextBoxDestino
            // 
            this.TextBoxDestino.Location = new System.Drawing.Point(146, 44);
            this.TextBoxDestino.Name = "TextBoxDestino";
            this.TextBoxDestino.Size = new System.Drawing.Size(158, 26);
            this.TextBoxDestino.TabIndex = 1;
            // 
            // LabelDestino
            // 
            this.LabelDestino.AutoSize = true;
            this.LabelDestino.Location = new System.Drawing.Point(58, 46);
            this.LabelDestino.Name = "LabelDestino";
            this.LabelDestino.Size = new System.Drawing.Size(62, 19);
            this.LabelDestino.TabIndex = 0;
            this.LabelDestino.Text = "Destino: ";
            // 
            // ViajesFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.GroupBoxIngresoDatos);
            this.Controls.Add(this.ImageBoxAvion);
            this.Controls.Add(this.PictureBoxBarco);
            this.Controls.Add(this.BotonAvion);
            this.Controls.Add(this.BotonBarco);
            this.Controls.Add(this.LabelOpciones);
            this.Controls.Add(this.LabelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViajesFormulario";
            this.Text = "Viajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBarco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxAvion)).EndInit();
            this.GroupBoxIngresoDatos.ResumeLayout(false);
            this.GroupBoxIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericoDiasEstadia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Label LabelOpciones;
        private System.Windows.Forms.Button BotonBarco;
        private System.Windows.Forms.Button BotonAvion;
        private System.Windows.Forms.PictureBox PictureBoxBarco;
        private System.Windows.Forms.PictureBox ImageBoxAvion;
        private System.Windows.Forms.GroupBox GroupBoxIngresoDatos;
        private System.Windows.Forms.Label LabelTiempoViaje;
        private System.Windows.Forms.TextBox TextBoxCedula;
        private System.Windows.Forms.Label LabelCedula;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.TextBox TextBoxDestino;
        private System.Windows.Forms.Label LabelDestino;
        private System.Windows.Forms.Label LabelDiasEstadia;
        private System.Windows.Forms.TextBox TextBoxTiempoViaje;
        private System.Windows.Forms.ListBox ListaHabitación;
        private System.Windows.Forms.Label LabelHabitacion;
        private System.Windows.Forms.ListBox ListaCamarote;
        private System.Windows.Forms.NumericUpDown NumericoDiasEstadia;
        private System.Windows.Forms.Label LabelCamarote;
        private System.Windows.Forms.DateTimePicker FechaDeViaje;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.Label LabelTransporte;
        private System.Windows.Forms.Label LabelTasaAeropuerto;
        private System.Windows.Forms.Label LabelValorMinutoVuelo;
        private System.Windows.Forms.Button BotonTotal;
        private System.Windows.Forms.TextBox TextBoxTotal;
        private System.Windows.Forms.TextBox TextBoxValorMinuto;
        private System.Windows.Forms.TextBox TextBoxValorTransporte;
        private System.Windows.Forms.TextBox TextBoxTasaAero;
        private System.Windows.Forms.Button BotonEliminar;
    }
}

