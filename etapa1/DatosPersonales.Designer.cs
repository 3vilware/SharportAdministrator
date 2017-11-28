namespace etapa1
{
    partial class DatosPersonales
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido1 = new System.Windows.Forms.TextBox();
            this.atras = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.ComboBox();
            this.aceptardatos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numeroasientos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.apellido2 = new System.Windows.Forms.TextBox();
            this.rutaVuelo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATOS DEL PASAJERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "APELLIDO MATERNO";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(74, 65);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(136, 20);
            this.nombre.TabIndex = 3;
            // 
            // apellido1
            // 
            this.apellido1.Location = new System.Drawing.Point(136, 104);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(136, 20);
            this.apellido1.TabIndex = 4;
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(17, 268);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(75, 23);
            this.atras.TabIndex = 5;
            this.atras.Text = "Atras";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "EDAD";
            // 
            // edad
            // 
            this.edad.FormattingEnabled = true;
            this.edad.Items.AddRange(new object[] {
            "18",
            "19",
            "20"});
            this.edad.Location = new System.Drawing.Point(57, 191);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(36, 21);
            this.edad.TabIndex = 8;
            // 
            // aceptardatos
            // 
            this.aceptardatos.Location = new System.Drawing.Point(442, 268);
            this.aceptardatos.Name = "aceptardatos";
            this.aceptardatos.Size = new System.Drawing.Size(75, 23);
            this.aceptardatos.TabIndex = 9;
            this.aceptardatos.Text = "Confirmar";
            this.aceptardatos.UseVisualStyleBackColor = true;
            this.aceptardatos.Click += new System.EventHandler(this.aceptardatos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Seleccionar Asiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numeroasientos
            // 
            this.numeroasientos.AutoSize = true;
            this.numeroasientos.BackColor = System.Drawing.Color.Teal;
            this.numeroasientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroasientos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numeroasientos.Location = new System.Drawing.Point(458, 148);
            this.numeroasientos.Name = "numeroasientos";
            this.numeroasientos.Size = new System.Drawing.Size(24, 18);
            this.numeroasientos.TabIndex = 12;
            this.numeroasientos.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "APELLIDO PATERNO";
            // 
            // apellido2
            // 
            this.apellido2.Location = new System.Drawing.Point(136, 145);
            this.apellido2.Name = "apellido2";
            this.apellido2.Size = new System.Drawing.Size(136, 20);
            this.apellido2.TabIndex = 15;
            // 
            // rutaVuelo
            // 
            this.rutaVuelo.AutoSize = true;
            this.rutaVuelo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaVuelo.Location = new System.Drawing.Point(341, 64);
            this.rutaVuelo.Name = "rutaVuelo";
            this.rutaVuelo.Size = new System.Drawing.Size(166, 16);
            this.rutaVuelo.TabIndex = 16;
            this.rutaVuelo.Text = "(Toque para ver vuelo..)";
            this.rutaVuelo.Click += new System.EventHandler(this.rutaVuelo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(279, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vuelo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(302, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Asientos disponibles->";
            // 
            // DatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 315);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rutaVuelo);
            this.Controls.Add(this.apellido2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numeroasientos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aceptardatos);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.apellido1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatosPersonales";
            this.Text = "DatosPersonales";
            this.Load += new System.EventHandler(this.DatosPersonales_Load);
            this.Shown += new System.EventHandler(this.DatosPersonales_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido1;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox edad;
        private System.Windows.Forms.Button aceptardatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label numeroasientos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox apellido2;
        private System.Windows.Forms.Label rutaVuelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}