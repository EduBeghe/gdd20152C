﻿namespace AerolineaFrba.Compra
{
    partial class CargarDatos
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
            this.dni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.confirmar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tarjeta = new System.Windows.Forms.CheckBox();
            this.datosTarjeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carga de datos";
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(279, 103);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(196, 26);
            this.dni.TabIndex = 1;
            this.dni.TextChanged += new System.EventHandler(this.dni_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(279, 152);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(196, 26);
            this.Nombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido";
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(279, 55);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(196, 26);
            this.Apellido.TabIndex = 5;
            this.Apellido.TextChanged += new System.EventHandler(this.Apellido_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Direccion";
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(279, 202);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(196, 26);
            this.Direccion.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(279, 249);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(196, 26);
            this.Telefono.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mail";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(279, 297);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(196, 26);
            this.Mail.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fecha de Nacimiento";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(274, 343);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 26);
            this.fecha.TabIndex = 14;
            // 
            // confirmar
            // 
            this.confirmar.Location = new System.Drawing.Point(161, 404);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(147, 38);
            this.confirmar.TabIndex = 15;
            this.confirmar.Text = "Confirmar Datos";
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(471, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Al ingresar su Apellido y Dni se cargaron sus datos si ya es cliente";
            // 
            // tarjeta
            // 
            this.tarjeta.AutoSize = true;
            this.tarjeta.Location = new System.Drawing.Point(24, 609);
            this.tarjeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.Size = new System.Drawing.Size(156, 24);
            this.tarjeta.TabIndex = 17;
            this.tarjeta.Text = "Pagar con tarjeta";
            this.tarjeta.UseVisualStyleBackColor = true;
            // 
            // datosTarjeta
            // 
            this.datosTarjeta.Location = new System.Drawing.Point(24, 669);
            this.datosTarjeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datosTarjeta.Name = "datosTarjeta";
            this.datosTarjeta.Size = new System.Drawing.Size(306, 60);
            this.datosTarjeta.TabIndex = 18;
            this.datosTarjeta.Text = "Cargar datos de tarjeta";
            this.datosTarjeta.UseVisualStyleBackColor = true;
            this.datosTarjeta.Visible = false;
            // 
            // CargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 457);
            this.Controls.Add(this.datosTarjeta);
            this.Controls.Add(this.tarjeta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.label1);
            this.Name = "CargarDatos";
            this.Text = "CargarDatos";
            this.Load += new System.EventHandler(this.CargarDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox tarjeta;
        private System.Windows.Forms.Button datosTarjeta;
    }
}