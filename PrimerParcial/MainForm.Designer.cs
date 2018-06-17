namespace PrimerParcial
{
    partial class MainForm
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
            this.ErrorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPrsonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarGruposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorProv
            // 
            this.ErrorProv.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(269, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPrsonasToolStripMenuItem,
            this.detalleToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registrarPrsonasToolStripMenuItem
            // 
            this.registrarPrsonasToolStripMenuItem.Name = "registrarPrsonasToolStripMenuItem";
            this.registrarPrsonasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarPrsonasToolStripMenuItem.Text = "Registrar Grupos";
            this.registrarPrsonasToolStripMenuItem.Click += new System.EventHandler(this.registrarPrsonasToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarGruposToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarGruposToolStripMenuItem
            // 
            this.consultarGruposToolStripMenuItem.Name = "consultarGruposToolStripMenuItem";
            this.consultarGruposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarGruposToolStripMenuItem.Text = "Consultar Grupos";
            this.consultarGruposToolStripMenuItem.Click += new System.EventHandler(this.consultarGruposToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // detalleToolStripMenuItem
            // 
            this.detalleToolStripMenuItem.Name = "detalleToolStripMenuItem";
            this.detalleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detalleToolStripMenuItem.Text = "Detalle";
            this.detalleToolStripMenuItem.Click += new System.EventHandler(this.detalleToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 341);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider ErrorProv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPrsonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarGruposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleToolStripMenuItem;
    }
}

