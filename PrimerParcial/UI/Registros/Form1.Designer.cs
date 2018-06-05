namespace PrimerParcial
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.GruposIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IntegrantestextBox = new System.Windows.Forms.TextBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.GrupostextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.FechasdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GruposIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupos Id";
            // 
            // GruposIdnumericUpDown
            // 
            this.GruposIdnumericUpDown.Location = new System.Drawing.Point(105, 30);
            this.GruposIdnumericUpDown.Name = "GruposIdnumericUpDown";
            this.GruposIdnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.GruposIdnumericUpDown.TabIndex = 1;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackgroundImage = global::PrimerParcial.Properties.Resources.trash_can_512;
            this.Eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eliminarbutton.Location = new System.Drawing.Point(353, 341);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 76);
            this.Eliminarbutton.TabIndex = 5;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackgroundImage = global::PrimerParcial.Properties.Resources.save;
            this.Guardarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guardarbutton.Location = new System.Drawing.Point(194, 341);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 76);
            this.Guardarbutton.TabIndex = 4;
            this.Guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackgroundImage = global::PrimerParcial.Properties.Resources.document;
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Nuevobutton.Location = new System.Drawing.Point(12, 341);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 76);
            this.Nuevobutton.TabIndex = 3;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Buscarbutton.BackgroundImage = global::PrimerParcial.Properties.Resources._104301;
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Buscarbutton.Location = new System.Drawing.Point(231, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(55, 49);
            this.Buscarbutton.TabIndex = 2;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(194, 288);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 23);
            this.Modificarbutton.TabIndex = 6;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Grupos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Integrantes";
            // 
            // IntegrantestextBox
            // 
            this.IntegrantestextBox.Location = new System.Drawing.Point(112, 110);
            this.IntegrantestextBox.Name = "IntegrantestextBox";
            this.IntegrantestextBox.Size = new System.Drawing.Size(174, 20);
            this.IntegrantestextBox.TabIndex = 13;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(101, 137);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(185, 20);
            this.CantidadtextBox.TabIndex = 14;
            // 
            // GrupostextBox
            // 
            this.GrupostextBox.Location = new System.Drawing.Point(93, 169);
            this.GrupostextBox.Name = "GrupostextBox";
            this.GrupostextBox.Size = new System.Drawing.Size(193, 20);
            this.GrupostextBox.TabIndex = 15;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(112, 196);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(174, 20);
            this.DescripciontextBox.TabIndex = 16;
            // 
            // FechasdateTimePicker
            // 
            this.FechasdateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechasdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechasdateTimePicker.Location = new System.Drawing.Point(89, 77);
            this.FechasdateTimePicker.Name = "FechasdateTimePicker";
            this.FechasdateTimePicker.Size = new System.Drawing.Size(93, 20);
            this.FechasdateTimePicker.TabIndex = 17;
            // 
            // ErrorProv
            // 
            this.ErrorProv.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 429);
            this.Controls.Add(this.FechasdateTimePicker);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.GrupostextBox);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.IntegrantestextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.GruposIdnumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GruposIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown GruposIdnumericUpDown;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IntegrantestextBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.TextBox GrupostextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.DateTimePicker FechasdateTimePicker;
        private System.Windows.Forms.ErrorProvider ErrorProv;
    }
}

