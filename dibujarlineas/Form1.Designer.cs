namespace dibujarlineas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtespaciado = new System.Windows.Forms.TextBox();
            this.cbocolores = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btndibujarlineas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espaciado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Colores";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(105, 60);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 3;
            // 
            // txtespaciado
            // 
            this.txtespaciado.Location = new System.Drawing.Point(105, 97);
            this.txtespaciado.Name = "txtespaciado";
            this.txtespaciado.Size = new System.Drawing.Size(100, 20);
            this.txtespaciado.TabIndex = 4;
            // 
            // cbocolores
            // 
            this.cbocolores.FormattingEnabled = true;
            this.cbocolores.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Azul",
            "Negro"});
            this.cbocolores.Location = new System.Drawing.Point(105, 140);
            this.cbocolores.Name = "cbocolores";
            this.cbocolores.Size = new System.Drawing.Size(121, 21);
            this.cbocolores.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(271, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 335);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btndibujarlineas
            // 
            this.btndibujarlineas.Location = new System.Drawing.Point(49, 207);
            this.btndibujarlineas.Name = "btndibujarlineas";
            this.btndibujarlineas.Size = new System.Drawing.Size(195, 72);
            this.btndibujarlineas.TabIndex = 7;
            this.btndibujarlineas.Text = "Dibujar lineas";
            this.btndibujarlineas.UseVisualStyleBackColor = true;
            this.btndibujarlineas.Click += new System.EventHandler(this.btndibujarlineas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 389);
            this.Controls.Add(this.btndibujarlineas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbocolores);
            this.Controls.Add(this.txtespaciado);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtespaciado;
        private System.Windows.Forms.ComboBox cbocolores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndibujarlineas;
    }
}

