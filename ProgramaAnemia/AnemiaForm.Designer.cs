namespace ProgramaAnemia
{
    partial class AnemiaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHemoglobina = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.numericEdad = new System.Windows.Forms.NumericUpDown();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.txtHemoglobina = new System.Windows.Forms.TextBox();
            this.gbEvaluacion = new System.Windows.Forms.GroupBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.groupBoxEstadisticcas = new System.Windows.Forms.GroupBox();
            this.lblNegativosMayores15Hombres = new System.Windows.Forms.Label();
            this.lblPositivosMayores15Hombres = new System.Windows.Forms.Label();
            this.lblNegativosMayores15Mujeres = new System.Windows.Forms.Label();
            this.lblPositivosMayores15Mujeres = new System.Windows.Forms.Label();
            this.lblNegativos10_15 = new System.Windows.Forms.Label();
            this.lblPositivos10_15 = new System.Windows.Forms.Label();
            this.lblNegativos5_10 = new System.Windows.Forms.Label();
            this.lblPositivos5_10 = new System.Windows.Forms.Label();
            this.lblNegativos1_5 = new System.Windows.Forms.Label();
            this.lblPositivos1_5 = new System.Windows.Forms.Label();
            this.lblNegativos0_1 = new System.Windows.Forms.Label();
            this.lblPositivos0_1 = new System.Windows.Forms.Label();
            this.lblNegativos = new System.Windows.Forms.Label();
            this.lblPositivos = new System.Windows.Forms.Label();
            this.lblTotalExamenes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).BeginInit();
            this.gbEvaluacion.SuspendLayout();
            this.groupBoxEstadisticcas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHemoglobina
            // 
            this.lblHemoglobina.AutoSize = true;
            this.lblHemoglobina.Location = new System.Drawing.Point(329, 32);
            this.lblHemoglobina.Name = "lblHemoglobina";
            this.lblHemoglobina.Size = new System.Drawing.Size(179, 16);
            this.lblHemoglobina.TabIndex = 0;
            this.lblHemoglobina.Text = "Nivel de Hemoglobina (g%) :";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(329, 57);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(87, 16);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad (años) :";
            // 
            // numericEdad
            // 
            this.numericEdad.Location = new System.Drawing.Point(514, 57);
            this.numericEdad.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericEdad.Name = "numericEdad";
            this.numericEdad.Size = new System.Drawing.Size(100, 22);
            this.numericEdad.TabIndex = 4;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(329, 82);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(61, 16);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Género : ";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(513, 85);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(101, 24);
            this.cmbGenero.TabIndex = 6;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(433, 133);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 7;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // txtHemoglobina
            // 
            this.txtHemoglobina.Location = new System.Drawing.Point(514, 29);
            this.txtHemoglobina.Name = "txtHemoglobina";
            this.txtHemoglobina.Size = new System.Drawing.Size(100, 22);
            this.txtHemoglobina.TabIndex = 1;
            // 
            // gbEvaluacion
            // 
            this.gbEvaluacion.Controls.Add(this.btnEvaluar);
            this.gbEvaluacion.Controls.Add(this.lblResultado);
            this.gbEvaluacion.Controls.Add(this.lblHemoglobina);
            this.gbEvaluacion.Controls.Add(this.cmbGenero);
            this.gbEvaluacion.Controls.Add(this.txtHemoglobina);
            this.gbEvaluacion.Controls.Add(this.lblGenero);
            this.gbEvaluacion.Controls.Add(this.lblEdad);
            this.gbEvaluacion.Controls.Add(this.numericEdad);
            this.gbEvaluacion.Location = new System.Drawing.Point(12, 12);
            this.gbEvaluacion.Name = "gbEvaluacion";
            this.gbEvaluacion.Size = new System.Drawing.Size(923, 225);
            this.gbEvaluacion.TabIndex = 8;
            this.gbEvaluacion.TabStop = false;
            this.gbEvaluacion.Text = "Evaluación";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(341, 168);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(75, 16);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado :";
            // 
            // groupBoxEstadisticcas
            // 
            this.groupBoxEstadisticcas.Controls.Add(this.lblNegativosMayores15Hombres);
            this.groupBoxEstadisticcas.Controls.Add(this.lblPositivosMayores15Hombres);
            this.groupBoxEstadisticcas.Controls.Add(this.lblNegativosMayores15Mujeres);
            this.groupBoxEstadisticcas.Controls.Add(this.lblPositivosMayores15Mujeres);
            this.groupBoxEstadisticcas.Controls.Add(this.lblNegativos10_15);
            this.groupBoxEstadisticcas.Controls.Add(this.lblPositivos10_15);
            this.groupBoxEstadisticcas.Controls.Add(this.lblNegativos5_10);
            this.groupBoxEstadisticcas.Controls.Add(this.lblPositivos5_10);
            this.groupBoxEstadisticcas.Controls.Add(this.lblNegativos1_5);
            this.groupBoxEstadisticcas.Controls.Add(this.lblPositivos1_5);
            this.groupBoxEstadisticcas.Controls.Add(this.lblNegativos0_1);
            this.groupBoxEstadisticcas.Controls.Add(this.lblPositivos0_1);
            this.groupBoxEstadisticcas.Controls.Add(this.lblNegativos);
            this.groupBoxEstadisticcas.Controls.Add(this.lblPositivos);
            this.groupBoxEstadisticcas.Controls.Add(this.lblTotalExamenes);
            this.groupBoxEstadisticcas.Location = new System.Drawing.Point(12, 243);
            this.groupBoxEstadisticcas.Name = "groupBoxEstadisticcas";
            this.groupBoxEstadisticcas.Size = new System.Drawing.Size(923, 227);
            this.groupBoxEstadisticcas.TabIndex = 9;
            this.groupBoxEstadisticcas.TabStop = false;
            this.groupBoxEstadisticcas.Text = "Estadísticas del día";
            // 
            // lblNegativosMayores15Hombres
            // 
            this.lblNegativosMayores15Hombres.AutoSize = true;
            this.lblNegativosMayores15Hombres.Location = new System.Drawing.Point(546, 139);
            this.lblNegativosMayores15Hombres.Name = "lblNegativosMayores15Hombres";
            this.lblNegativosMayores15Hombres.Size = new System.Drawing.Size(241, 16);
            this.lblNegativosMayores15Hombres.TabIndex = 14;
            this.lblNegativosMayores15Hombres.Text = "Mayores de 15 (Hombres) Negativos: 0";
            // 
            // lblPositivosMayores15Hombres
            // 
            this.lblPositivosMayores15Hombres.AutoSize = true;
            this.lblPositivosMayores15Hombres.Location = new System.Drawing.Point(546, 112);
            this.lblPositivosMayores15Hombres.Name = "lblPositivosMayores15Hombres";
            this.lblPositivosMayores15Hombres.Size = new System.Drawing.Size(234, 16);
            this.lblPositivosMayores15Hombres.TabIndex = 13;
            this.lblPositivosMayores15Hombres.Text = "Mayores de 15 (Hombres) Positivos: 0";
            // 
            // lblNegativosMayores15Mujeres
            // 
            this.lblNegativosMayores15Mujeres.AutoSize = true;
            this.lblNegativosMayores15Mujeres.Location = new System.Drawing.Point(241, 138);
            this.lblNegativosMayores15Mujeres.Name = "lblNegativosMayores15Mujeres";
            this.lblNegativosMayores15Mujeres.Size = new System.Drawing.Size(233, 16);
            this.lblNegativosMayores15Mujeres.TabIndex = 12;
            this.lblNegativosMayores15Mujeres.Text = "Mayores de 15 (Mujeres) Negativos: 0";
            // 
            // lblPositivosMayores15Mujeres
            // 
            this.lblPositivosMayores15Mujeres.AutoSize = true;
            this.lblPositivosMayores15Mujeres.Location = new System.Drawing.Point(241, 112);
            this.lblPositivosMayores15Mujeres.Name = "lblPositivosMayores15Mujeres";
            this.lblPositivosMayores15Mujeres.Size = new System.Drawing.Size(226, 16);
            this.lblPositivosMayores15Mujeres.TabIndex = 11;
            this.lblPositivosMayores15Mujeres.Text = "Mayores de 15 (Mujeres) Positivos: 0";
            // 
            // lblNegativos10_15
            // 
            this.lblNegativos10_15.AutoSize = true;
            this.lblNegativos10_15.Location = new System.Drawing.Point(6, 139);
            this.lblNegativos10_15.Name = "lblNegativos10_15";
            this.lblNegativos10_15.Size = new System.Drawing.Size(150, 16);
            this.lblNegativos10_15.TabIndex = 10;
            this.lblNegativos10_15.Text = "10-15 años Negativos: 0";
            // 
            // lblPositivos10_15
            // 
            this.lblPositivos10_15.AutoSize = true;
            this.lblPositivos10_15.Location = new System.Drawing.Point(6, 114);
            this.lblPositivos10_15.Name = "lblPositivos10_15";
            this.lblPositivos10_15.Size = new System.Drawing.Size(143, 16);
            this.lblPositivos10_15.TabIndex = 9;
            this.lblPositivos10_15.Text = "10-15 años Positivos: 0\n";
            // 
            // lblNegativos5_10
            // 
            this.lblNegativos5_10.AutoSize = true;
            this.lblNegativos5_10.Location = new System.Drawing.Point(718, 52);
            this.lblNegativos5_10.Name = "lblNegativos5_10";
            this.lblNegativos5_10.Size = new System.Drawing.Size(143, 16);
            this.lblNegativos5_10.TabIndex = 8;
            this.lblNegativos5_10.Text = "5-10 años Negativos: 0";
            // 
            // lblPositivos5_10
            // 
            this.lblPositivos5_10.AutoSize = true;
            this.lblPositivos5_10.Location = new System.Drawing.Point(718, 27);
            this.lblPositivos5_10.Name = "lblPositivos5_10";
            this.lblPositivos5_10.Size = new System.Drawing.Size(136, 16);
            this.lblPositivos5_10.TabIndex = 7;
            this.lblPositivos5_10.Text = "5-10 años Positivos: 0";
            // 
            // lblNegativos1_5
            // 
            this.lblNegativos1_5.AutoSize = true;
            this.lblNegativos1_5.Location = new System.Drawing.Point(464, 52);
            this.lblNegativos1_5.Name = "lblNegativos1_5";
            this.lblNegativos1_5.Size = new System.Drawing.Size(136, 16);
            this.lblNegativos1_5.TabIndex = 6;
            this.lblNegativos1_5.Text = "1-5 años Negativos: 0";
            // 
            // lblPositivos1_5
            // 
            this.lblPositivos1_5.AutoSize = true;
            this.lblPositivos1_5.Location = new System.Drawing.Point(464, 27);
            this.lblPositivos1_5.Name = "lblPositivos1_5";
            this.lblPositivos1_5.Size = new System.Drawing.Size(129, 16);
            this.lblPositivos1_5.TabIndex = 5;
            this.lblPositivos1_5.Text = "1-5 años Positivos: 0";
            // 
            // lblNegativos0_1
            // 
            this.lblNegativos0_1.AutoSize = true;
            this.lblNegativos0_1.Location = new System.Drawing.Point(241, 52);
            this.lblNegativos0_1.Name = "lblNegativos0_1";
            this.lblNegativos0_1.Size = new System.Drawing.Size(136, 16);
            this.lblNegativos0_1.TabIndex = 4;
            this.lblNegativos0_1.Text = "0-1 años Negativos: 0";
            // 
            // lblPositivos0_1
            // 
            this.lblPositivos0_1.AutoSize = true;
            this.lblPositivos0_1.Location = new System.Drawing.Point(241, 27);
            this.lblPositivos0_1.Name = "lblPositivos0_1";
            this.lblPositivos0_1.Size = new System.Drawing.Size(129, 16);
            this.lblPositivos0_1.TabIndex = 3;
            this.lblPositivos0_1.Text = "0-1 años Positivos: 0";
            // 
            // lblNegativos
            // 
            this.lblNegativos.AutoSize = true;
            this.lblNegativos.Location = new System.Drawing.Point(6, 77);
            this.lblNegativos.Name = "lblNegativos";
            this.lblNegativos.Size = new System.Drawing.Size(82, 16);
            this.lblNegativos.TabIndex = 2;
            this.lblNegativos.Text = "Negativos: 0";
            // 
            // lblPositivos
            // 
            this.lblPositivos.AutoSize = true;
            this.lblPositivos.Location = new System.Drawing.Point(6, 52);
            this.lblPositivos.Name = "lblPositivos";
            this.lblPositivos.Size = new System.Drawing.Size(75, 16);
            this.lblPositivos.TabIndex = 1;
            this.lblPositivos.Text = "Positivos: 0";
            // 
            // lblTotalExamenes
            // 
            this.lblTotalExamenes.AutoSize = true;
            this.lblTotalExamenes.Location = new System.Drawing.Point(6, 27);
            this.lblTotalExamenes.Name = "lblTotalExamenes";
            this.lblTotalExamenes.Size = new System.Drawing.Size(118, 16);
            this.lblTotalExamenes.TabIndex = 0;
            this.lblTotalExamenes.Text = "Total Exámenes: 0";
            // 
            // AnemiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 482);
            this.Controls.Add(this.groupBoxEstadisticcas);
            this.Controls.Add(this.gbEvaluacion);
            this.Name = "AnemiaForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericEdad)).EndInit();
            this.gbEvaluacion.ResumeLayout(false);
            this.gbEvaluacion.PerformLayout();
            this.groupBoxEstadisticcas.ResumeLayout(false);
            this.groupBoxEstadisticcas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHemoglobina;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown numericEdad;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.TextBox txtHemoglobina;
        private System.Windows.Forms.GroupBox gbEvaluacion;
        private System.Windows.Forms.GroupBox groupBoxEstadisticcas;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblPositivos0_1;
        private System.Windows.Forms.Label lblNegativos;
        private System.Windows.Forms.Label lblPositivos;
        private System.Windows.Forms.Label lblTotalExamenes;
        private System.Windows.Forms.Label lblPositivos1_5;
        private System.Windows.Forms.Label lblNegativos0_1;
        private System.Windows.Forms.Label lblNegativos10_15;
        private System.Windows.Forms.Label lblPositivos10_15;
        private System.Windows.Forms.Label lblNegativos5_10;
        private System.Windows.Forms.Label lblPositivos5_10;
        private System.Windows.Forms.Label lblNegativos1_5;
        private System.Windows.Forms.Label lblNegativosMayores15Hombres;
        private System.Windows.Forms.Label lblPositivosMayores15Hombres;
        private System.Windows.Forms.Label lblNegativosMayores15Mujeres;
        private System.Windows.Forms.Label lblPositivosMayores15Mujeres;
    }
}