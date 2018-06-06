using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using PrimerParcial.Entidades;


namespace PrimerParcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void Validarbutton_Click(object sender, EventArgs e)
        {

        }

        private void registrarPrsonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimerParcial.UI.Registros.Form1 form1 = new UI.Registros.Form1();
            form1.Show();
        }

        private void consultarGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimerParcial.UI.Consultas.Consultar consultar = new UI.Consultas.Consultar();
            consultar.Show();
        }
    }
}

    //private void IdnumericUpDown_ValueChanged(object sender, EventArgs e)
        

      //  private void label6_Click(object sender, EventArgs e)
        

       // private void textBox5_TextChanged(object sender, EventArgs e)
        
    

