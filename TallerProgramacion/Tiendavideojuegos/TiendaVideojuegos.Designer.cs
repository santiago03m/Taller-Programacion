namespace TallerProgramacion.TiendVideojuegos
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMosrar = new System.Windows.Forms.Button();
            this.buttonIngresarNuevo = new System.Windows.Forms.Button();
            this.buttonRetirar = new System.Windows.Forms.Button();
            this.buttonPrestar = new System.Windows.Forms.Button();
            this.buttonRegresar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxMostrar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenidos a la tienda de videojuegos!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRegresar);
            this.groupBox1.Controls.Add(this.buttonPrestar);
            this.groupBox1.Controls.Add(this.buttonRetirar);
            this.groupBox1.Controls.Add(this.buttonIngresarNuevo);
            this.groupBox1.Controls.Add(this.buttonMosrar);
            this.groupBox1.Location = new System.Drawing.Point(57, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Que deseas hacer ?";
            // 
            // buttonMosrar
            // 
            this.buttonMosrar.Location = new System.Drawing.Point(19, 32);
            this.buttonMosrar.Name = "buttonMosrar";
            this.buttonMosrar.Size = new System.Drawing.Size(151, 31);
            this.buttonMosrar.TabIndex = 0;
            this.buttonMosrar.Text = "Mostrar videojuegos";
            this.buttonMosrar.UseVisualStyleBackColor = true;
            this.buttonMosrar.Click += new System.EventHandler(this.buttonMosrar_Click);
            // 
            // buttonIngresarNuevo
            // 
            this.buttonIngresarNuevo.Location = new System.Drawing.Point(21, 69);
            this.buttonIngresarNuevo.Name = "buttonIngresarNuevo";
            this.buttonIngresarNuevo.Size = new System.Drawing.Size(149, 31);
            this.buttonIngresarNuevo.TabIndex = 1;
            this.buttonIngresarNuevo.Text = "Ingresar Nuevo videojuegos";
            this.buttonIngresarNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.Location = new System.Drawing.Point(21, 106);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(149, 31);
            this.buttonRetirar.TabIndex = 2;
            this.buttonRetirar.Text = "Retirar";
            this.buttonRetirar.UseVisualStyleBackColor = true;
            // 
            // buttonPrestar
            // 
            this.buttonPrestar.Location = new System.Drawing.Point(21, 143);
            this.buttonPrestar.Name = "buttonPrestar";
            this.buttonPrestar.Size = new System.Drawing.Size(149, 31);
            this.buttonPrestar.TabIndex = 3;
            this.buttonPrestar.Text = "Prestar ";
            this.buttonPrestar.UseVisualStyleBackColor = true;
            // 
            // buttonRegresar
            // 
            this.buttonRegresar.Location = new System.Drawing.Point(21, 180);
            this.buttonRegresar.Name = "buttonRegresar";
            this.buttonRegresar.Size = new System.Drawing.Size(149, 31);
            this.buttonRegresar.TabIndex = 4;
            this.buttonRegresar.Text = "Regresar";
            this.buttonRegresar.UseVisualStyleBackColor = true;
            this.buttonRegresar.Click += new System.EventHandler(this.buttonRegresar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMostrar);
            this.groupBox2.Location = new System.Drawing.Point(291, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 223);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // textBoxMostrar
            // 
            this.textBoxMostrar.Location = new System.Drawing.Point(15, 23);
            this.textBoxMostrar.Multiline = true;
            this.textBoxMostrar.Name = "textBoxMostrar";
            this.textBoxMostrar.Size = new System.Drawing.Size(296, 170);
            this.textBoxMostrar.TabIndex = 0;
            // 
            // TiendaVideojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TiendaVideojuegos";
            this.Text = "TiendaVideojuegos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonIngresarNuevo;
        private System.Windows.Forms.Button buttonMosrar;
        private System.Windows.Forms.Button buttonRegresar;
        private System.Windows.Forms.Button buttonPrestar;
        private System.Windows.Forms.Button buttonRetirar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxMostrar;
    }
}