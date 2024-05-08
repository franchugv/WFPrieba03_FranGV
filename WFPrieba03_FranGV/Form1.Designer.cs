namespace WFPrieba03_FranGV
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
            this.LPelicula = new System.Windows.Forms.Label();
            this.comboBoxPelicula = new System.Windows.Forms.ComboBox();
            this.TextBoxPelicula = new System.Windows.Forms.TextBox();
            this.BotonAgregarPelicula = new System.Windows.Forms.Button();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.BotonCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LPelicula
            // 
            this.LPelicula.AutoSize = true;
            this.LPelicula.Location = new System.Drawing.Point(29, 29);
            this.LPelicula.Name = "LPelicula";
            this.LPelicula.Size = new System.Drawing.Size(49, 13);
            this.LPelicula.TabIndex = 0;
            this.LPelicula.Text = "Película:";
            // 
            // comboBoxPelicula
            // 
            this.comboBoxPelicula.FormattingEnabled = true;
            this.comboBoxPelicula.Items.AddRange(new object[] {
            "Aquaman",
            "Green Lentern",
            "Spiderman",
            "The Batman"});
            this.comboBoxPelicula.Location = new System.Drawing.Point(90, 68);
            this.comboBoxPelicula.Name = "comboBoxPelicula";
            this.comboBoxPelicula.Size = new System.Drawing.Size(325, 21);
            this.comboBoxPelicula.Sorted = true;
            this.comboBoxPelicula.TabIndex = 1;
            this.comboBoxPelicula.SelectedIndexChanged += new System.EventHandler(this.comboBoxPelicula_SelectedIndexChanged);
            // 
            // TextBoxPelicula
            // 
            this.TextBoxPelicula.Location = new System.Drawing.Point(90, 29);
            this.TextBoxPelicula.MaxLength = 50;
            this.TextBoxPelicula.Name = "TextBoxPelicula";
            this.TextBoxPelicula.Size = new System.Drawing.Size(325, 20);
            this.TextBoxPelicula.TabIndex = 2;
            // 
            // BotonAgregarPelicula
            // 
            this.BotonAgregarPelicula.Location = new System.Drawing.Point(90, 108);
            this.BotonAgregarPelicula.Name = "BotonAgregarPelicula";
            this.BotonAgregarPelicula.Size = new System.Drawing.Size(118, 21);
            this.BotonAgregarPelicula.TabIndex = 3;
            this.BotonAgregarPelicula.Text = "Agregar";
            this.BotonAgregarPelicula.UseVisualStyleBackColor = true;
            this.BotonAgregarPelicula.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(90, 135);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(118, 23);
            this.BotonGuardar.TabIndex = 4;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            // 
            // BotonCargar
            // 
            this.BotonCargar.Location = new System.Drawing.Point(214, 108);
            this.BotonCargar.Name = "BotonCargar";
            this.BotonCargar.Size = new System.Drawing.Size(118, 23);
            this.BotonCargar.TabIndex = 5;
            this.BotonCargar.Text = "Cargar";
            this.BotonCargar.UseVisualStyleBackColor = true;
            this.BotonCargar.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 211);
            this.Controls.Add(this.BotonCargar);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.BotonAgregarPelicula);
            this.Controls.Add(this.TextBoxPelicula);
            this.Controls.Add(this.comboBoxPelicula);
            this.Controls.Add(this.LPelicula);
            this.Name = "Form1";
            this.Text = "Ejemplo de uso de ComboBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LPelicula;
        private System.Windows.Forms.ComboBox comboBoxPelicula;
        private System.Windows.Forms.TextBox TextBoxPelicula;
        private System.Windows.Forms.Button BotonAgregarPelicula;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Button BotonCargar;
    }
}

