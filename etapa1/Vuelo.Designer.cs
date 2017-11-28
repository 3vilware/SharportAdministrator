namespace etapa1
{
    partial class Vuelo
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
            this.components = new System.ComponentModel.Container();
            this.aceptar = new System.Windows.Forms.Button();
            this.seleccionVuelo = new System.Windows.Forms.ComboBox();
            this.vueloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(188, 79);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 1;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // seleccionVuelo
            // 
            this.seleccionVuelo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vueloBindingSource, "Size", true));
            this.seleccionVuelo.FormattingEnabled = true;
            this.seleccionVuelo.Location = new System.Drawing.Point(34, 81);
            this.seleccionVuelo.Name = "seleccionVuelo";
            this.seleccionVuelo.Size = new System.Drawing.Size(121, 21);
            this.seleccionVuelo.TabIndex = 2;
            this.seleccionVuelo.SelectedIndexChanged += new System.EventHandler(this.seleccionVuelo_SelectedIndexChanged);
            // 
            // vueloBindingSource
            // 
            this.vueloBindingSource.DataSource = typeof(etapa1.Vuelo);
            // 
            // Vuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 201);
            this.Controls.Add(this.seleccionVuelo);
            this.Controls.Add(this.aceptar);
            this.Name = "Vuelo";
            this.Text = "Vuelo";
            ((System.ComponentModel.ISupportInitialize)(this.vueloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.ComboBox seleccionVuelo;
        private System.Windows.Forms.BindingSource vueloBindingSource;
    }
}