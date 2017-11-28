namespace etapa1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pasajeros = new System.Windows.Forms.Button();
            this.vuelos = new System.Windows.Forms.Button();
            this.grafo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(827, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Elegir vuelo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Salir.Location = new System.Drawing.Point(37, 539);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(108, 48);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Goldenrod;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 18);
            this.label1.MaximumSize = new System.Drawing.Size(600, 500);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(442, 88);
            this.label1.TabIndex = 2;
            this.label1.Text = " Al Qaeda Flying ";
            // 
            // Pasajeros
            // 
            this.Pasajeros.Location = new System.Drawing.Point(872, 161);
            this.Pasajeros.Name = "Pasajeros";
            this.Pasajeros.Size = new System.Drawing.Size(144, 36);
            this.Pasajeros.TabIndex = 3;
            this.Pasajeros.Text = "Administrar Pasajeros";
            this.Pasajeros.UseVisualStyleBackColor = true;
            this.Pasajeros.Click += new System.EventHandler(this.Pasajeros_Click);
            // 
            // vuelos
            // 
            this.vuelos.Location = new System.Drawing.Point(872, 203);
            this.vuelos.Name = "vuelos";
            this.vuelos.Size = new System.Drawing.Size(144, 35);
            this.vuelos.TabIndex = 4;
            this.vuelos.Text = "Administrar Vuelos";
            this.vuelos.UseVisualStyleBackColor = true;
            this.vuelos.Click += new System.EventHandler(this.vuelos_Click);
            // 
            // grafo
            // 
            this.grafo.Location = new System.Drawing.Point(887, 244);
            this.grafo.Name = "grafo";
            this.grafo.Size = new System.Drawing.Size(102, 39);
            this.grafo.TabIndex = 5;
            this.grafo.Text = "Grafo";
            this.grafo.UseVisualStyleBackColor = true;
            this.grafo.Click += new System.EventHandler(this.grafo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::etapa1.Properties.Resources.allau;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.grafo);
            this.Controls.Add(this.vuelos);
            this.Controls.Add(this.Pasajeros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "AGENCIA DE VUELOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pasajeros;
        private System.Windows.Forms.Button vuelos;
        private System.Windows.Forms.Button grafo;
    }
}

