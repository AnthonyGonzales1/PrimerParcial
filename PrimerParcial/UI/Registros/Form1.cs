using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using PrimerParcial.Entidades;


namespace PrimerParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Grupos LlenaClase()
        {
            Grupos grupos = new Grupos();

            grupos.GruposId = Convert.ToInt32(GruposIdnumericUpDown.Value);
            grupos.Descripcion = DescripciontextBox.Text;
            grupos.Fecha = FechasdateTimePicker.Value;
            grupos.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            grupos.Gruposs = GrupostextBox.Text;
            grupos.Integrantes = IntegrantestextBox.Text;

            return grupos;
        }

        

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            GruposIdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            FechasdateTimePicker.Value = DateTime.Now;
            CantidadtextBox.Clear();
            GrupostextBox.Clear();
            ErrorProv.Clear();

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool Paso = false;
            Grupos grupos;

            if (Validar())
            {
                MessageBox.Show("Revise todos los campos", "Validado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grupos = LlenaClase();

            if (GruposIdnumericUpDown.Value == 0)
                Paso = BLL.GrupoBLL.Guardar(grupos);
            else
                Paso = BLL.GrupoBLL.Modificar(grupos);

            if (Paso)
                MessageBox.Show("Guardado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se guardo", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GruposIdnumericUpDown.Value);
            Grupos grupos = BLL.GrupoBLL.Buscar(id);
            if (grupos != null)
            {
                GruposIdnumericUpDown.Value = grupos.GruposId;
                DescripciontextBox.Text = grupos.Descripcion;
                FechasdateTimePicker.Value = grupos.Fecha;
                CantidadtextBox.Text = grupos.Cantidad.ToString();
                GrupostextBox.Text = grupos.Gruposs;
                IntegrantestextBox.Text = grupos.Integrantes;
            }
            else
                MessageBox.Show("No se encontro", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(GruposIdnumericUpDown.Value);

            if (BLL.GrupoBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se elimino", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool Validar()
        {
            bool Error = false;

            if (GruposIdnumericUpDown.Value == 0)
            {
                ErrorProv.SetError(GruposIdnumericUpDown,
                    "Falta seleccionar Grupo Id");
                Error = true;
            }

            if (String.IsNullOrEmpty(DescripciontextBox.Text))
            {
                ErrorProv.SetError(DescripciontextBox,
                    "Debe ingresar la descripción de los Grupos");
                Error = true;
            }

            if (String.IsNullOrEmpty(CantidadtextBox.Text))
            {
                ErrorProv.SetError(CantidadtextBox,
                    "Debe ingresar una Cantidad");
                Error = true;
            }
            if (String.IsNullOrEmpty(GrupostextBox.Text))
            {
                ErrorProv.SetError(GrupostextBox,
                    "Debe ingresar una Cantidad de Grupos");
                Error = true;
            }

            if (String.IsNullOrEmpty(IntegrantestextBox.Text))
            {
                ErrorProv.SetError(IntegrantestextBox,
                    "Debe ingresar los Integrantes del Grupo");
                Error = true;
            }
            return Error;
        }

        private void Validarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}

    //private void IdnumericUpDown_ValueChanged(object sender, EventArgs e)
        

      //  private void label6_Click(object sender, EventArgs e)
        

       // private void textBox5_TextChanged(object sender, EventArgs e)
        
    

