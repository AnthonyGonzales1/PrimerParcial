using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PrimerParcial.UI.Registros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mainFormcsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PrimerParcial.UI.Registros.Form1 mainForm = new Registros.Form1();

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimerParcial.UI.Consultas.Consultar consultar = new Consultas.Consultar();
        }
    }
}
