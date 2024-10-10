namespace ProgramaVideojuegos
{
    partial class TiendaVideojuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiendaVideojuegos));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAutor = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.buttonDevolver = new System.Windows.Forms.Button();
            this.buttonPrestar = new System.Windows.Forms.Button();
            this.buttonRetirar = new System.Windows.Forms.Button();
            this.buttonIngresarNuevo = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewVideojuegos = new System.Windows.Forms.DataGridView();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideojuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenidos a la tienda de videojuegos!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAutor);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.textBoxAutor);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.textBoxCodigo);
            this.groupBox1.Controls.Add(this.labelCodigo);
            this.groupBox1.Controls.Add(this.buttonDevolver);
            this.groupBox1.Controls.Add(this.buttonPrestar);
            this.groupBox1.Controls.Add(this.buttonRetirar);
            this.groupBox1.Controls.Add(this.buttonIngresarNuevo);
            this.groupBox1.Controls.Add(this.buttonMostrar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Que deseas hacer ?";
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Location = new System.Drawing.Point(176, 129);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(35, 13);
            this.labelAutor.TabIndex = 10;
            this.labelAutor.Text = "Autor:";
            this.labelAutor.Visible = false;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(176, 92);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.Visible = false;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(179, 143);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(105, 20);
            this.textBoxAutor.TabIndex = 8;
            this.textBoxAutor.Visible = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(179, 106);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(105, 20);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.Visible = false;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(179, 69);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(105, 20);
            this.textBoxCodigo.TabIndex = 6;
            this.textBoxCodigo.Visible = false;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(176, 53);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 5;
            this.labelCodigo.Text = "Código:";
            this.labelCodigo.Visible = false;
            // 
            // buttonDevolver
            // 
            this.buttonDevolver.Location = new System.Drawing.Point(21, 180);
            this.buttonDevolver.Name = "buttonDevolver";
            this.buttonDevolver.Size = new System.Drawing.Size(149, 31);
            this.buttonDevolver.TabIndex = 4;
            this.buttonDevolver.Text = "Devolver";
            this.buttonDevolver.UseVisualStyleBackColor = true;
            this.buttonDevolver.Visible = false;
            this.buttonDevolver.Click += new System.EventHandler(this.buttonDevolver_Click);
            // 
            // buttonPrestar
            // 
            this.buttonPrestar.Location = new System.Drawing.Point(21, 143);
            this.buttonPrestar.Name = "buttonPrestar";
            this.buttonPrestar.Size = new System.Drawing.Size(149, 31);
            this.buttonPrestar.TabIndex = 3;
            this.buttonPrestar.Text = "Prestar ";
            this.buttonPrestar.UseVisualStyleBackColor = true;
            this.buttonPrestar.Visible = false;
            this.buttonPrestar.Click += new System.EventHandler(this.buttonPrestar_Click);
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.Location = new System.Drawing.Point(21, 106);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(149, 31);
            this.buttonRetirar.TabIndex = 2;
            this.buttonRetirar.Text = "Retirar";
            this.buttonRetirar.UseVisualStyleBackColor = true;
            this.buttonRetirar.Visible = false;
            this.buttonRetirar.Click += new System.EventHandler(this.buttonRetirar_Click);
            // 
            // buttonIngresarNuevo
            // 
            this.buttonIngresarNuevo.Location = new System.Drawing.Point(21, 69);
            this.buttonIngresarNuevo.Name = "buttonIngresarNuevo";
            this.buttonIngresarNuevo.Size = new System.Drawing.Size(149, 31);
            this.buttonIngresarNuevo.TabIndex = 1;
            this.buttonIngresarNuevo.Text = "Ingresar Nuevo videojuegos";
            this.buttonIngresarNuevo.UseVisualStyleBackColor = true;
            this.buttonIngresarNuevo.Visible = false;
            this.buttonIngresarNuevo.Click += new System.EventHandler(this.buttonIngresarNuevo_Click);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(19, 32);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(151, 31);
            this.buttonMostrar.TabIndex = 0;
            this.buttonMostrar.Text = "Mostrar videojuegos";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewVideojuegos);
            this.groupBox2.Location = new System.Drawing.Point(318, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 275);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewVideojuegos
            // 
            this.dataGridViewVideojuegos.AllowUserToAddRows = false;
            this.dataGridViewVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVideojuegos.Location = new System.Drawing.Point(16, 18);
            this.dataGridViewVideojuegos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewVideojuegos.Name = "dataGridViewVideojuegos";
            this.dataGridViewVideojuegos.RowHeadersWidth = 51;
            this.dataGridViewVideojuegos.RowTemplate.Height = 24;
            this.dataGridViewVideojuegos.Size = new System.Drawing.Size(449, 240);
            this.dataGridViewVideojuegos.TabIndex = 0;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(652, 352);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(149, 31);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // TiendaVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(812, 394);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TiendaVideojuegos";
            this.Text = "TiendaVideojuegos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVideojuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonIngresarNuevo;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonPrestar;
        private System.Windows.Forms.Button buttonRetirar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewVideojuegos;
        private System.Windows.Forms.Button buttonDevolver;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelNombre;
    }
}