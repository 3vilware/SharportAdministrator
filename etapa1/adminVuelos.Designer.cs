namespace etapa1
{
    partial class adminVuelos
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
            this.label2 = new System.Windows.Forms.Label();
            this.ListViewVuelo = new System.Windows.Forms.ListView();
            this.origen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.costo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tiempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboOrigen = new System.Windows.Forms.ComboBox();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTiempo = new System.Windows.Forms.TextBox();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AGREGAR = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.atras = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboVuelo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboFiltroVuelos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMINISTRAR VUELOS";
            // 
            // ListViewVuelo
            // 
            this.ListViewVuelo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.origen,
            this.destino,
            this.costo,
            this.tiempo});
            this.ListViewVuelo.FullRowSelect = true;
            this.ListViewVuelo.GridLines = true;
            this.ListViewVuelo.Location = new System.Drawing.Point(30, 72);
            this.ListViewVuelo.Name = "ListViewVuelo";
            this.ListViewVuelo.Size = new System.Drawing.Size(312, 333);
            this.ListViewVuelo.TabIndex = 2;
            this.ListViewVuelo.UseCompatibleStateImageBehavior = false;
            this.ListViewVuelo.View = System.Windows.Forms.View.Details;
            this.ListViewVuelo.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewVuelo_ColumnClick);
            this.ListViewVuelo.SelectedIndexChanged += new System.EventHandler(this.ListViewVuelo_SelectedIndexChanged);
            // 
            // origen
            // 
            this.origen.Text = "Origen";
            this.origen.Width = 73;
            // 
            // destino
            // 
            this.destino.Text = "Destino";
            this.destino.Width = 75;
            // 
            // costo
            // 
            this.costo.Text = "Costo";
            this.costo.Width = 76;
            // 
            // tiempo
            // 
            this.tiempo.Text = "Tiempo";
            this.tiempo.Width = 86;
            // 
            // comboOrigen
            // 
            this.comboOrigen.FormattingEnabled = true;
            this.comboOrigen.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "L",
            "M",
            "N",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboOrigen.Location = new System.Drawing.Point(421, 183);
            this.comboOrigen.Name = "comboOrigen";
            this.comboOrigen.Size = new System.Drawing.Size(121, 21);
            this.comboOrigen.TabIndex = 3;
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "L",
            "M",
            "N",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboDestino.Location = new System.Drawing.Point(421, 222);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(121, 21);
            this.comboDestino.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ORIGEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DESTINO";
            // 
            // textBoxTiempo
            // 
            this.textBoxTiempo.Location = new System.Drawing.Point(421, 256);
            this.textBoxTiempo.Name = "textBoxTiempo";
            this.textBoxTiempo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTiempo.TabIndex = 7;
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Location = new System.Drawing.Point(421, 291);
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(100, 20);
            this.textBoxCosto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "TIEMPO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "COSTO";
            // 
            // AGREGAR
            // 
            this.AGREGAR.Location = new System.Drawing.Point(467, 328);
            this.AGREGAR.Name = "AGREGAR";
            this.AGREGAR.Size = new System.Drawing.Size(75, 23);
            this.AGREGAR.TabIndex = 11;
            this.AGREGAR.Text = "AGREGAR";
            this.AGREGAR.UseVisualStyleBackColor = true;
            this.AGREGAR.Click += new System.EventHandler(this.AGREGAR_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(369, 382);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(191, 23);
            this.eliminar.TabIndex = 12;
            this.eliminar.Text = "ELIMINAR";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(13, 18);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(55, 23);
            this.atras.TabIndex = 13;
            this.atras.Text = "ATRAS";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(421, 80);
            this.textBoxBuscar.MaxLength = 5;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuscar.TabIndex = 14;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "BUSCAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "AÑADIR VUELO";
            // 
            // comboVuelo
            // 
            this.comboVuelo.FormattingEnabled = true;
            this.comboVuelo.Items.AddRange(new object[] {
            "Origen",
            "Destino",
            "Costo"});
            this.comboVuelo.Location = new System.Drawing.Point(221, 45);
            this.comboVuelo.Name = "comboVuelo";
            this.comboVuelo.Size = new System.Drawing.Size(121, 21);
            this.comboVuelo.TabIndex = 17;
            this.comboVuelo.SelectedIndexChanged += new System.EventHandler(this.comboVuelo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "ORDENAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "POR";
            // 
            // comboFiltroVuelos
            // 
            this.comboFiltroVuelos.FormattingEnabled = true;
            this.comboFiltroVuelos.Items.AddRange(new object[] {
            "Ruta",
            "Origen",
            "Destino"});
            this.comboFiltroVuelos.Location = new System.Drawing.Point(421, 111);
            this.comboFiltroVuelos.Name = "comboFiltroVuelos";
            this.comboFiltroVuelos.Size = new System.Drawing.Size(84, 21);
            this.comboFiltroVuelos.TabIndex = 20;
            this.comboFiltroVuelos.Text = "Ruta";
            this.comboFiltroVuelos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboFiltroVuelos_KeyDown);
            // 
            // adminVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 484);
            this.Controls.Add(this.comboFiltroVuelos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboVuelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.AGREGAR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCosto);
            this.Controls.Add(this.textBoxTiempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDestino);
            this.Controls.Add(this.comboOrigen);
            this.Controls.Add(this.ListViewVuelo);
            this.Controls.Add(this.label2);
            this.Name = "adminVuelos";
            this.Text = "adminVuelos";
            this.Load += new System.EventHandler(this.adminVuelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView ListViewVuelo;
        private System.Windows.Forms.ColumnHeader origen;
        private System.Windows.Forms.ColumnHeader destino;
        private System.Windows.Forms.ColumnHeader costo;
        private System.Windows.Forms.ColumnHeader tiempo;
        private System.Windows.Forms.ComboBox comboOrigen;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTiempo;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AGREGAR;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboVuelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboFiltroVuelos;
    }
}