namespace PrimerParcial.UI.Consultas
{
    partial class Consultar
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
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CriteriocomboBox = new System.Windows.Forms.ComboBox();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarConsultabutton = new System.Windows.Forms.Button();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Id",
            "Fecha",
            "Descripcion",
            "Canttidad de Estudiantes",
            "Grupos de Estudiantes",
            "Integrantes"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(74, 17);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox.TabIndex = 1;
            this.FiltrocomboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrocomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Desde";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(112, 68);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(83, 20);
            this.DesdedateTimePicker.TabIndex = 7;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(404, 68);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(83, 20);
            this.HastadateTimePicker.TabIndex = 8;
            // 
            // CriteriocomboBox
            // 
            this.CriteriocomboBox.FormattingEnabled = true;
            this.CriteriocomboBox.Location = new System.Drawing.Point(366, 17);
            this.CriteriocomboBox.Name = "CriteriocomboBox";
            this.CriteriocomboBox.Size = new System.Drawing.Size(121, 21);
            this.CriteriocomboBox.TabIndex = 9;
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(42, 94);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(526, 278);
            this.ConsultadataGridView.TabIndex = 10;
            // 
            // BuscarConsultabutton
            // 
            this.BuscarConsultabutton.BackgroundImage = global::PrimerParcial.Properties.Resources._104301;
            this.BuscarConsultabutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuscarConsultabutton.Location = new System.Drawing.Point(493, 15);
            this.BuscarConsultabutton.Name = "BuscarConsultabutton";
            this.BuscarConsultabutton.Size = new System.Drawing.Size(53, 45);
            this.BuscarConsultabutton.TabIndex = 6;
            this.BuscarConsultabutton.UseVisualStyleBackColor = true;
            this.BuscarConsultabutton.Click += new System.EventHandler(this.BuscarConsultabutton_Click);
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.BackgroundImage = global::PrimerParcial.Properties.Resources.print;
            this.Imprimirbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imprimirbutton.Location = new System.Drawing.Point(12, 378);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(65, 60);
            this.Imprimirbutton.TabIndex = 5;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.CriteriocomboBox);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.BuscarConsultabutton);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.label1);
            this.Name = "Consultar";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Button BuscarConsultabutton;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.ComboBox CriteriocomboBox;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
    }
}