﻿namespace TallerProgramacion
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.empresaViajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mostrarVideojuegosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(703, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // programaAnemiaToolStripMenuItem
            // 
            this.programaAnemiaToolStripMenuItem.Name = "programaAnemiaToolStripMenuItem";
            this.programaAnemiaToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.programaAnemiaToolStripMenuItem.Text = "Programa Anemia";
            this.programaAnemiaToolStripMenuItem.Click += new System.EventHandler(this.anemiaToolStripMenuItem_Click);
            // 
            // tiendaVideojuegosToolStripMenuItem
            // 
            this.tiendaVideojuegosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.mostrarVideojuegosToolStripMenuItem});
            this.tiendaVideojuegosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tiendaVideojuegosToolStripMenuItem.Image")));
            this.tiendaVideojuegosToolStripMenuItem.Name = "tiendaVideojuegosToolStripMenuItem";
            this.tiendaVideojuegosToolStripMenuItem.Size = new System.Drawing.Size(142, 24)
            this.tiendaVideojuegosToolStripMenuItem.Text = "Tienda Videojuegos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // empresaViajesToolStripMenuItem
            // 
            this.empresaViajesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empresaViajesToolStripMenuItem.Image")));
            this.empresaViajesToolStripMenuItem.Name = "empresaViajesToolStripMenuItem";
            this.empresaViajesToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.empresaViajesToolStripMenuItem.Text = "Empresa Viajes";
            this.empresaViajesToolStripMenuItem.Click += new System.EventHandler(this.empresaViajesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(703, 310);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(9, 366);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(87, 13);
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Text = "Realizado por: ...";
            this.lblNombres.Click += new System.EventHandler(this.lblNames_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(588, 366);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(79, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha: [Actual]";
            this.lblFecha.Click += new System.EventHandler(this.label1_Click);
            // 
            // mostrarVideojuegosToolStripMenuItem
            // 
            this.mostrarVideojuegosToolStripMenuItem.Name = "mostrarVideojuegosToolStripMenuItem";
            this.mostrarVideojuegosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.mostrarVideojuegosToolStripMenuItem.Text = "Inventario videojuegos";
            this.mostrarVideojuegosToolStripMenuItem.Click += new System.EventHandler(this.mostrarVideojuegosToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 408);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mostrarVideojuegosToolStripMenuItem;
    }
}