namespace etapa1
{
    partial class FormGrafo
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
            this.panelGrafo = new System.Windows.Forms.Panel();
            this.letreroARM = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listBoxVertices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kruskalbutton = new System.Windows.Forms.Button();
            this.primButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxRecorrido = new System.Windows.Forms.ListBox();
            this.comboOrigenes = new System.Windows.Forms.ComboBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.panelGrafo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGrafo
            // 
            this.panelGrafo.Controls.Add(this.letreroARM);
            this.panelGrafo.Location = new System.Drawing.Point(16, 15);
            this.panelGrafo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGrafo.Name = "panelGrafo";
            this.panelGrafo.Size = new System.Drawing.Size(913, 754);
            this.panelGrafo.TabIndex = 0;
            this.panelGrafo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelGrafo_MouseClick);
            // 
            // letreroARM
            // 
            this.letreroARM.AutoSize = true;
            this.letreroARM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroARM.ForeColor = System.Drawing.Color.Red;
            this.letreroARM.Location = new System.Drawing.Point(500, 0);
            this.letreroARM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.letreroARM.Name = "letreroARM";
            this.letreroARM.Size = new System.Drawing.Size(70, 25);
            this.letreroARM.TabIndex = 0;
            this.letreroARM.Text = "label2";
            this.letreroARM.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1105, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(1105, 60);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 54);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click_1);
            // 
            // listBoxVertices
            // 
            this.listBoxVertices.FormattingEnabled = true;
            this.listBoxVertices.ItemHeight = 16;
            this.listBoxVertices.Items.AddRange(new object[] {
            "sin recorrido todavia"});
            this.listBoxVertices.Location = new System.Drawing.Point(937, 34);
            this.listBoxVertices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxVertices.Name = "listBoxVertices";
            this.listBoxVertices.Size = new System.Drawing.Size(159, 116);
            this.listBoxVertices.TabIndex = 3;
            this.listBoxVertices.SelectedIndexChanged += new System.EventHandler(this.listBoxVertices_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(980, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ciudades";
            // 
            // kruskalbutton
            // 
            this.kruskalbutton.Location = new System.Drawing.Point(969, 303);
            this.kruskalbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kruskalbutton.Name = "kruskalbutton";
            this.kruskalbutton.Size = new System.Drawing.Size(140, 46);
            this.kruskalbutton.TabIndex = 7;
            this.kruskalbutton.Text = "Kruskal";
            this.kruskalbutton.UseVisualStyleBackColor = true;
            this.kruskalbutton.Visible = false;
            this.kruskalbutton.Click += new System.EventHandler(this.kruskalbutton_Click);
            // 
            // primButton
            // 
            this.primButton.Location = new System.Drawing.Point(961, 471);
            this.primButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.primButton.Name = "primButton";
            this.primButton.Size = new System.Drawing.Size(133, 34);
            this.primButton.TabIndex = 8;
            this.primButton.Text = "Prim";
            this.primButton.UseVisualStyleBackColor = true;
            this.primButton.Click += new System.EventHandler(this.primButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(941, 409);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccione origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1207, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vertices del Recorrido ";
            // 
            // listBoxRecorrido
            // 
            this.listBoxRecorrido.FormattingEnabled = true;
            this.listBoxRecorrido.ItemHeight = 16;
            this.listBoxRecorrido.Location = new System.Drawing.Point(1248, 36);
            this.listBoxRecorrido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxRecorrido.Name = "listBoxRecorrido";
            this.listBoxRecorrido.Size = new System.Drawing.Size(59, 116);
            this.listBoxRecorrido.TabIndex = 12;
            // 
            // comboOrigenes
            // 
            this.comboOrigenes.FormattingEnabled = true;
            this.comboOrigenes.Location = new System.Drawing.Point(946, 438);
            this.comboOrigenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboOrigenes.Name = "comboOrigenes";
            this.comboOrigenes.Size = new System.Drawing.Size(163, 24);
            this.comboOrigenes.TabIndex = 14;
            this.comboOrigenes.SelectedIndexChanged += new System.EventHandler(this.comboOrigenes_SelectedIndexChanged);
            // 
            // printBtn
            // 
            this.printBtn.Enabled = false;
            this.printBtn.Location = new System.Drawing.Point(937, 207);
            this.printBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(195, 30);
            this.printBtn.TabIndex = 15;
            this.printBtn.Text = "Imprimir Grafo";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // FormGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1385, 814);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.comboOrigenes);
            this.Controls.Add(this.listBoxRecorrido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.primButton);
            this.Controls.Add(this.kruskalbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxVertices);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelGrafo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGrafo";
            this.Text = "FormGrafo";
            this.Load += new System.EventHandler(this.FormGrafo_Load);
            this.Shown += new System.EventHandler(this.FormGrafo_Shown);
            this.panelGrafo.ResumeLayout(false);
            this.panelGrafo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGrafo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListBox listBoxVertices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kruskalbutton;
        private System.Windows.Forms.Button primButton;
        private System.Windows.Forms.Label letreroARM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxRecorrido;
        private System.Windows.Forms.ComboBox comboOrigenes;
        private System.Windows.Forms.Button printBtn;
    }
}