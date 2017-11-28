namespace etapa1
{
    partial class adminPasajeros
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
            this.ListViewPasajeros = new System.Windows.Forms.ListView();
            this.columnaNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaVuelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaAsiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.eliminarBoton = new System.Windows.Forms.Button();
            this.buscarPasajeros = new System.Windows.Forms.TextBox();
            this.atras = new System.Windows.Forms.Button();
            this.comboPasajeros = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboFiltroPasajeros = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ListViewPasajeros
            // 
            this.ListViewPasajeros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaNombre,
            this.columnaVuelo,
            this.columnaAsiento});
            this.ListViewPasajeros.FullRowSelect = true;
            this.ListViewPasajeros.GridLines = true;
            this.ListViewPasajeros.Location = new System.Drawing.Point(12, 31);
            this.ListViewPasajeros.Name = "ListViewPasajeros";
            this.ListViewPasajeros.Size = new System.Drawing.Size(329, 330);
            this.ListViewPasajeros.TabIndex = 0;
            this.ListViewPasajeros.UseCompatibleStateImageBehavior = false;
            this.ListViewPasajeros.View = System.Windows.Forms.View.Details;
            this.ListViewPasajeros.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnaNombre
            // 
            this.columnaNombre.Text = "Nombre";
            this.columnaNombre.Width = 191;
            // 
            // columnaVuelo
            // 
            this.columnaVuelo.Text = "Vuelo";
            this.columnaVuelo.Width = 92;
            // 
            // columnaAsiento
            // 
            this.columnaAsiento.Text = "Asiento";
            this.columnaAsiento.Width = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "BUSCAR:";
            // 
            // eliminarBoton
            // 
            this.eliminarBoton.Location = new System.Drawing.Point(398, 117);
            this.eliminarBoton.Name = "eliminarBoton";
            this.eliminarBoton.Size = new System.Drawing.Size(75, 23);
            this.eliminarBoton.TabIndex = 3;
            this.eliminarBoton.Text = "Eliminar";
            this.eliminarBoton.UseVisualStyleBackColor = true;
            this.eliminarBoton.Click += new System.EventHandler(this.eliminarBoton_Click);
            // 
            // buscarPasajeros
            // 
            this.buscarPasajeros.Location = new System.Drawing.Point(398, 28);
            this.buscarPasajeros.Name = "buscarPasajeros";
            this.buscarPasajeros.Size = new System.Drawing.Size(100, 20);
            this.buscarPasajeros.TabIndex = 4;
            this.buscarPasajeros.TextChanged += new System.EventHandler(this.buscarPasajeros_TextChanged);
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(12, 2);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(75, 23);
            this.atras.TabIndex = 5;
            this.atras.Text = "ATRAS";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // comboPasajeros
            // 
            this.comboPasajeros.FormattingEnabled = true;
            this.comboPasajeros.Items.AddRange(new object[] {
            "Nombre",
            "Vuelo",
            "Asiento"});
            this.comboPasajeros.Location = new System.Drawing.Point(220, 4);
            this.comboPasajeros.Name = "comboPasajeros";
            this.comboPasajeros.Size = new System.Drawing.Size(121, 21);
            this.comboPasajeros.TabIndex = 6;
            this.comboPasajeros.SelectedIndexChanged += new System.EventHandler(this.comboPasajeros_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ORDENAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "POR:";
            // 
            // comboFiltroPasajeros
            // 
            this.comboFiltroPasajeros.FormattingEnabled = true;
            this.comboFiltroPasajeros.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboFiltroPasajeros.Items.AddRange(new object[] {
            "Nombre",
            "Vuelo",
            "Asiento"});
            this.comboFiltroPasajeros.Location = new System.Drawing.Point(398, 57);
            this.comboFiltroPasajeros.Name = "comboFiltroPasajeros";
            this.comboFiltroPasajeros.Size = new System.Drawing.Size(75, 21);
            this.comboFiltroPasajeros.TabIndex = 9;
            this.comboFiltroPasajeros.Text = "Nombre";
            this.comboFiltroPasajeros.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboFiltroPasajeros_KeyDown);
            // 
            // adminPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 393);
            this.Controls.Add(this.comboFiltroPasajeros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPasajeros);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.buscarPasajeros);
            this.Controls.Add(this.eliminarBoton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListViewPasajeros);
            this.Name = "adminPasajeros";
            this.Text = "PasajerosVentana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListViewPasajeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnaNombre;
        private System.Windows.Forms.ColumnHeader columnaVuelo;
        private System.Windows.Forms.ColumnHeader columnaAsiento;
        private System.Windows.Forms.Button eliminarBoton;
        private System.Windows.Forms.TextBox buscarPasajeros;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.ComboBox comboPasajeros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboFiltroPasajeros;
    }
}