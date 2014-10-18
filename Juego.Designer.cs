namespace Robot
{
    partial class Juego
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
            this.pJuego = new System.Windows.Forms.Panel();
            this.pComandos = new System.Windows.Forms.Panel();
            this.bLimpiarLista = new System.Windows.Forms.Button();
            this.bEjecutar = new System.Windows.Forms.Button();
            this.lbComandosEjecutar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.lbComandos = new System.Windows.Forms.ListBox();
            this.pComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pJuego
            // 
            this.pJuego.Location = new System.Drawing.Point(27, 31);
            this.pJuego.Name = "pJuego";
            this.pJuego.Size = new System.Drawing.Size(682, 668);
            this.pJuego.TabIndex = 1;
            // 
            // pComandos
            // 
            this.pComandos.Controls.Add(this.bLimpiarLista);
            this.pComandos.Controls.Add(this.bEjecutar);
            this.pComandos.Controls.Add(this.lbComandosEjecutar);
            this.pComandos.Controls.Add(this.label1);
            this.pComandos.Controls.Add(this.bAgregar);
            this.pComandos.Controls.Add(this.lbComandos);
            this.pComandos.Location = new System.Drawing.Point(732, 31);
            this.pComandos.Name = "pComandos";
            this.pComandos.Size = new System.Drawing.Size(172, 545);
            this.pComandos.TabIndex = 2;
            // 
            // bLimpiarLista
            // 
            this.bLimpiarLista.Location = new System.Drawing.Point(21, 389);
            this.bLimpiarLista.Name = "bLimpiarLista";
            this.bLimpiarLista.Size = new System.Drawing.Size(130, 23);
            this.bLimpiarLista.TabIndex = 5;
            this.bLimpiarLista.Text = "Limpiar Lista";
            this.bLimpiarLista.UseVisualStyleBackColor = true;
            this.bLimpiarLista.Click += new System.EventHandler(this.bLimpiarLista_Click);
            // 
            // bEjecutar
            // 
            this.bEjecutar.Location = new System.Drawing.Point(21, 327);
            this.bEjecutar.Name = "bEjecutar";
            this.bEjecutar.Size = new System.Drawing.Size(130, 23);
            this.bEjecutar.TabIndex = 4;
            this.bEjecutar.Text = "Ejecutar";
            this.bEjecutar.UseVisualStyleBackColor = true;
            this.bEjecutar.Click += new System.EventHandler(this.bEjecutar_Click);
            // 
            // lbComandosEjecutar
            // 
            this.lbComandosEjecutar.FormattingEnabled = true;
            this.lbComandosEjecutar.Location = new System.Drawing.Point(21, 194);
            this.lbComandosEjecutar.Name = "lbComandosEjecutar";
            this.lbComandosEjecutar.Size = new System.Drawing.Size(130, 95);
            this.lbComandosEjecutar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comandos a Ejecutar";
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(21, 119);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(130, 23);
            this.bAgregar.TabIndex = 1;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // lbComandos
            // 
            this.lbComandos.FormattingEnabled = true;
            this.lbComandos.Location = new System.Drawing.Point(21, 17);
            this.lbComandos.Name = "lbComandos";
            this.lbComandos.Size = new System.Drawing.Size(130, 95);
            this.lbComandos.TabIndex = 0;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 700);
            this.Controls.Add(this.pComandos);
            this.Controls.Add(this.pJuego);
            this.Name = "Juego";
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            this.pComandos.ResumeLayout(false);
            this.pComandos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pJuego;
        private System.Windows.Forms.Panel pComandos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.ListBox lbComandos;
        private System.Windows.Forms.Button bLimpiarLista;
        private System.Windows.Forms.Button bEjecutar;
        private System.Windows.Forms.ListBox lbComandosEjecutar;

    }
}