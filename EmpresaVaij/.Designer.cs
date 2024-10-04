namespace EmpresaVaij
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LabelOpciones = new System.Windows.Forms.Label();
            this.BotonBarco = new System.Windows.Forms.Button();
            this.BotonAvion = new System.Windows.Forms.Button();
            this.PictureBoxBarco = new System.Windows.Forms.PictureBox();
            this.ImageBoxAvion = new System.Windows.Forms.PictureBox();
            this.GroupBoxIngresoDatos = new System.Windows.Forms.GroupBox();
            this.LabelDestino = new System.Windows.Forms.Label();
            this.TextBoxDestino = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LabelDiasEstadia = new System.Windows.Forms.Label();
            this.LabelCamarote = new System.Windows.Forms.Label();
            this.NumericoDiasEstadia = new System.Windows.Forms.NumericUpDown();
            this.ListaCamarote = new System.Windows.Forms.ListBox();
            this.LabelHabitacion = new System.Windows.Forms.Label();
            this.ListaHabitación = new System.Windows.Forms.ListBox();
            this.LabelTasaAeropuerto = new System.Windows.Forms.Label();
            this.NumericoTasaAeropuerto = new System.Windows.Forms.NumericUpDown();
            this.LabelTransporte = new System.Windows.Forms.Label();
            this.NumericoValorTransporte = new System.Windows.Forms.NumericUpDown();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericoValorMinuto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBarco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxAvion)).BeginInit();
            this.GroupBoxIngresoDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericoDiasEstadia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericoTasaAeropuerto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericoValorTransporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericoValorMinuto)).BeginInit();
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
            this.BotonBarco.Location = new System.Drawing.Point(176, 138);
            this.BotonBarco.Name = "BotonBarco";
            this.BotonBarco.Size = new System.Drawing.Size(130, 33);
            this.BotonBarco.TabIndex = 2;
            this.BotonBarco.Text = "Barco";
            this.BotonBarco.UseVisualStyleBackColor = false;
            // 
            // BotonAvion
            // 
            this.BotonAvion.Location = new System.Drawing.Point(745, 138);
            this.BotonAvion.Name = "BotonAvion";
            this.BotonAvion.Size = new System.Drawing.Size(104, 33);
            this.BotonAvion.TabIndex = 3;
            this.BotonAvion.Text = "Avión";
            this.BotonAvion.UseVisualStyleBackColor = true;
            // 
            // PictureBoxBarco
            // 
            this.PictureBoxBarco.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxBarco.Image")));
            this.PictureBoxBarco.Location = new System.Drawing.Point(129, 177);
            this.PictureBoxBarco.Name = "PictureBoxBarco";
            this.PictureBoxBarco.Size = new System.Drawing.Size(195, 130);
            this.PictureBoxBarco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxBarco.TabIndex = 4;
            this.PictureBoxBarco.TabStop = false;
            // 
            // ImageBoxAvion
            // 
            this.ImageBoxAvion.Image = ((System.Drawing.Image)(resources.GetObject("ImageBoxAvion.Image")));
            this.ImageBoxAvion.Location = new System.Drawing.Point(676, 177);
            this.ImageBoxAvion.Name = "ImageBoxAvion";
            this.ImageBoxAvion.Size = new System.Drawing.Size(279, 133);
            this.ImageBoxAvion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBoxAvion.TabIndex = 5;
            this.ImageBoxAvion.TabStop = false;
            // 
            // GroupBoxIngresoDatos
            // 
            this.GroupBoxIngresoDatos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GroupBoxIngresoDatos.Controls.Add(this.NumericoValorMinuto);
            this.GroupBoxIngresoDatos.Controls.Add(this.label3);
            this.GroupBoxIngresoDatos.Controls.Add(this.dateTimePicker1);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelFecha);
            this.GroupBoxIngresoDatos.Controls.Add(this.NumericoValorTransporte);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelTransporte);
            this.GroupBoxIngresoDatos.Controls.Add(this.NumericoTasaAeropuerto);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelTasaAeropuerto);
            this.GroupBoxIngresoDatos.Controls.Add(this.ListaHabitación);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelHabitacion);
            this.GroupBoxIngresoDatos.Controls.Add(this.ListaCamarote);
            this.GroupBoxIngresoDatos.Controls.Add(this.NumericoDiasEstadia);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelCamarote);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelDiasEstadia);
            this.GroupBoxIngresoDatos.Controls.Add(this.textBox3);
            this.GroupBoxIngresoDatos.Controls.Add(this.label2);
            this.GroupBoxIngresoDatos.Controls.Add(this.textBox2);
            this.GroupBoxIngresoDatos.Controls.Add(this.label1);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelNombre);
            this.GroupBoxIngresoDatos.Controls.Add(this.textBox1);
            this.GroupBoxIngresoDatos.Controls.Add(this.TextBoxDestino);
            this.GroupBoxIngresoDatos.Controls.Add(this.LabelDestino);
            this.GroupBoxIngresoDatos.Location = new System.Drawing.Point(71, 359);
            this.GroupBoxIngresoDatos.Name = "GroupBoxIngresoDatos";
            this.GroupBoxIngresoDatos.Size = new System.Drawing.Size(968, 417);
            this.GroupBoxIngresoDatos.TabIndex = 6;
            this.GroupBoxIngresoDatos.TabStop = false;
            this.GroupBoxIngresoDatos.Text = "Ingreso de Datos";
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
            // TextBoxDestino
            // 
            this.TextBoxDestino.Location = new System.Drawing.Point(146, 44);
            this.TextBoxDestino.Name = "TextBoxDestino";
            this.TextBoxDestino.Size = new System.Drawing.Size(158, 26);
            this.TextBoxDestino.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 26);
            this.textBox1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificación: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 157);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 26);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiempo de Viaje (Días): ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 7;
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
            // LabelCamarote
            // 
            this.LabelCamarote.AutoSize = true;
            this.LabelCamarote.Location = new System.Drawing.Point(471, 85);
            this.LabelCamarote.Name = "LabelCamarote";
            this.LabelCamarote.Size = new System.Drawing.Size(126, 19);
            this.LabelCamarote.TabIndex = 10;
            this.LabelCamarote.Text = "Tipo de Camarote: ";
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
            // LabelHabitacion
            // 
            this.LabelHabitacion.AutoSize = true;
            this.LabelHabitacion.Location = new System.Drawing.Point(471, 178);
            this.LabelHabitacion.Name = "LabelHabitacion";
            this.LabelHabitacion.Size = new System.Drawing.Size(131, 19);
            this.LabelHabitacion.TabIndex = 13;
            this.LabelHabitacion.Text = "Tipo de Habitación: ";
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
            // LabelTasaAeropuerto
            // 
            this.LabelTasaAeropuerto.AutoSize = true;
            this.LabelTasaAeropuerto.Location = new System.Drawing.Point(475, 242);
            this.LabelTasaAeropuerto.Name = "LabelTasaAeropuerto";
            this.LabelTasaAeropuerto.Size = new System.Drawing.Size(132, 19);
            this.LabelTasaAeropuerto.TabIndex = 15;
            this.LabelTasaAeropuerto.Text = "Tasa Aeroportuaria: ";
            // 
            // NumericoTasaAeropuerto
            // 
            this.NumericoTasaAeropuerto.Location = new System.Drawing.Point(617, 240);
            this.NumericoTasaAeropuerto.Name = "NumericoTasaAeropuerto";
            this.NumericoTasaAeropuerto.Size = new System.Drawing.Size(120, 26);
            this.NumericoTasaAeropuerto.TabIndex = 16;
            this.NumericoTasaAeropuerto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // NumericoValorTransporte
            // 
            this.NumericoValorTransporte.Location = new System.Drawing.Point(613, 288);
            this.NumericoValorTransporte.Name = "NumericoValorTransporte";
            this.NumericoValorTransporte.Size = new System.Drawing.Size(120, 26);
            this.NumericoValorTransporte.TabIndex = 18;
            this.NumericoValorTransporte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 284);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 26);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Valor del Minuto de Vuelo: ";
            // 
            // NumericoValorMinuto
            // 
            this.NumericoValorMinuto.Location = new System.Drawing.Point(218, 353);
            this.NumericoValorMinuto.Name = "NumericoValorMinuto";
            this.NumericoValorMinuto.Size = new System.Drawing.Size(120, 26);
            this.NumericoValorMinuto.TabIndex = 22;
            this.NumericoValorMinuto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1200, 814);
            this.Controls.Add(this.GroupBoxIngresoDatos);
            this.Controls.Add(this.ImageBoxAvion);
            this.Controls.Add(this.PictureBoxBarco);
            this.Controls.Add(this.BotonAvion);
            this.Controls.Add(this.BotonBarco);
            this.Controls.Add(this.LabelOpciones);
            this.Controls.Add(this.LabelTitulo);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxBarco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBoxAvion)).EndInit();
            this.GroupBoxIngresoDatos.ResumeLayout(false);
            this.GroupBoxIngresoDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericoDiasEstadia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericoTasaAeropuerto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericoValorTransporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericoValorMinuto)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextBoxDestino;
        private System.Windows.Forms.Label LabelDestino;
        private System.Windows.Forms.Label LabelDiasEstadia;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox ListaHabitación;
        private System.Windows.Forms.Label LabelHabitacion;
        private System.Windows.Forms.ListBox ListaCamarote;
        private System.Windows.Forms.NumericUpDown NumericoDiasEstadia;
        private System.Windows.Forms.Label LabelCamarote;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LabelFecha;
        private System.Windows.Forms.NumericUpDown NumericoValorTransporte;
        private System.Windows.Forms.Label LabelTransporte;
        private System.Windows.Forms.NumericUpDown NumericoTasaAeropuerto;
        private System.Windows.Forms.Label LabelTasaAeropuerto;
        private System.Windows.Forms.NumericUpDown NumericoValorMinuto;
        private System.Windows.Forms.Label label3;
    }
}

