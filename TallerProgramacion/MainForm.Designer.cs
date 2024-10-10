namespace TallerProgramacion
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.programaAnemiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaVideojuegosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaViajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.labelNombres1 = new System.Windows.Forms.Label();
            this.labelNombres2 = new System.Windows.Forms.Label();
            this.labelNombres3 = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCarnet1 = new System.Windows.Forms.Label();
            this.labelCarnet2 = new System.Windows.Forms.Label();
            this.labelCarnet3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programaAnemiaToolStripMenuItem,
            this.tiendaVideojuegosToolStripMenuItem,
            this.empresaViajesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(937, 30);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // programaAnemiaToolStripMenuItem
            // 
            this.programaAnemiaToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programaAnemiaToolStripMenuItem.Image = global::TallerProgramacion.Properties.Resources.AnemiaMain;
            this.programaAnemiaToolStripMenuItem.Name = "programaAnemiaToolStripMenuItem";
            this.programaAnemiaToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.programaAnemiaToolStripMenuItem.Text = "Programa Anemia";
            this.programaAnemiaToolStripMenuItem.Click += new System.EventHandler(this.anemiaToolStripMenuItem_Click);
            // 
            // tiendaVideojuegosToolStripMenuItem
            // 
            this.tiendaVideojuegosToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiendaVideojuegosToolStripMenuItem.Image = global::TallerProgramacion.Properties.Resources.VideojuegosMain;
            this.tiendaVideojuegosToolStripMenuItem.Name = "tiendaVideojuegosToolStripMenuItem";
            this.tiendaVideojuegosToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.tiendaVideojuegosToolStripMenuItem.Text = "Tienda Videojuegos";
            this.tiendaVideojuegosToolStripMenuItem.Click += new System.EventHandler(this.tiendaVideojuegosToolStripMenuItem_Click);
            // 
            // empresaViajesToolStripMenuItem
            // 
            this.empresaViajesToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaViajesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empresaViajesToolStripMenuItem.Image")));
            this.empresaViajesToolStripMenuItem.Name = "empresaViajesToolStripMenuItem";
            this.empresaViajesToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.empresaViajesToolStripMenuItem.Text = "Empresa Viajes";
            this.empresaViajesToolStripMenuItem.Click += new System.EventHandler(this.empresaViajesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::TallerProgramacion.Properties.Resources.SalirMain;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(12, 426);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(100, 19);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Realizado por:";
            this.lblNombres.Click += new System.EventHandler(this.lblNames_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(784, 450);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(109, 19);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha: [Actual]";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNombres1
            // 
            this.labelNombres1.AutoSize = true;
            this.labelNombres1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombres1.Location = new System.Drawing.Point(12, 442);
            this.labelNombres1.Name = "labelNombres1";
            this.labelNombres1.Size = new System.Drawing.Size(240, 19);
            this.labelNombres1.TabIndex = 4;
            this.labelNombres1.Text = "Santiago Rueda David -----------";
            // 
            // labelNombres2
            // 
            this.labelNombres2.AutoSize = true;
            this.labelNombres2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombres2.Location = new System.Drawing.Point(12, 474);
            this.labelNombres2.Name = "labelNombres2";
            this.labelNombres2.Size = new System.Drawing.Size(244, 19);
            this.labelNombres2.TabIndex = 5;
            this.labelNombres2.Text = "Daniel Alejandro Martinez Ramirez -";
            // 
            // labelNombres3
            // 
            this.labelNombres3.AutoSize = true;
            this.labelNombres3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombres3.Location = new System.Drawing.Point(12, 458);
            this.labelNombres3.Name = "labelNombres3";
            this.labelNombres3.Size = new System.Drawing.Size(242, 19);
            this.labelNombres3.TabIndex = 6;
            this.labelNombres3.Text = "Vanessa Espinosa Cardona --------";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::TallerProgramacion.Properties.Resources.ParchenseMain;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 31);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(937, 382);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // labelCarnet1
            // 
            this.labelCarnet1.AutoSize = true;
            this.labelCarnet1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarnet1.Location = new System.Drawing.Point(248, 441);
            this.labelCarnet1.Name = "labelCarnet1";
            this.labelCarnet1.Size = new System.Drawing.Size(73, 19);
            this.labelCarnet1.TabIndex = 7;
            this.labelCarnet1.Text = "23158522";
            // 
            // labelCarnet2
            // 
            this.labelCarnet2.AutoSize = true;
            this.labelCarnet2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarnet2.Location = new System.Drawing.Point(248, 460);
            this.labelCarnet2.Name = "labelCarnet2";
            this.labelCarnet2.Size = new System.Drawing.Size(73, 19);
            this.labelCarnet2.TabIndex = 8;
            this.labelCarnet2.Text = "23258706";
            // 
            // labelCarnet3
            // 
            this.labelCarnet3.AutoSize = true;
            this.labelCarnet3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarnet3.Location = new System.Drawing.Point(248, 476);
            this.labelCarnet3.Name = "labelCarnet3";
            this.labelCarnet3.Size = new System.Drawing.Size(73, 19);
            this.labelCarnet3.TabIndex = 9;
            this.labelCarnet3.Text = "23158321";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total: 9 -----> Tema 4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCarnet3);
            this.Controls.Add(this.labelCarnet2);
            this.Controls.Add(this.labelCarnet1);
            this.Controls.Add(this.labelNombres3);
            this.Controls.Add(this.labelNombres2);
            this.Controls.Add(this.labelNombres1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem programaAnemiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendaVideojuegosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaViajesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label labelNombres1;
        private System.Windows.Forms.Label labelNombres2;
        private System.Windows.Forms.Label labelNombres3;
        private System.Windows.Forms.Label labelCarnet1;
        private System.Windows.Forms.Label labelCarnet2;
        private System.Windows.Forms.Label labelCarnet3;
        private System.Windows.Forms.Label label1;
    }
}