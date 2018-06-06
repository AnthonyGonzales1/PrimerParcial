using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimerParcial.BLL;
using PrimerParcial.Entidades;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Grupos LlenaClase()
        {
            Grupos grupos = new Grupos();

            grupos.GruposId = Convert.ToInt32(IDNumericUpDown.Value);
            grupos.Descripcion = DescripcionTextBox.Text;
            grupos.Fecha = FechaDateTimePicker.Value;
            grupos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            grupos.Gruposs = Convert.ToInt32(GruposTextBox.Text);
            

            float cantidad, gruposEst, integr;
            cantidad = Convert.ToInt32(CantidadTextBox.Text);
            gruposEst = Convert.ToInt32(GruposTextBox.Text);
            integr = cantidad / gruposEst;

            IntegrantesTextBox.Text = integr.ToString();
            grupos.Integrantes = Convert.ToInt32(IntegrantesTextBox.Text);
            return grupos;
        }

        private bool Validar()
        {
            bool Error = false;

            if (IDNumericUpDown.Value < 0)
            {
                GruposErrorProvider.SetError(IDNumericUpDown,
                    "Falta seleccionar Grupo Id");
                Error = true;
            }

            if (String.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                GruposErrorProvider.SetError(DescripcionTextBox,
                    "Debe ingresar la descripción de los Grupos");
                Error = true;
            }

            if (String.IsNullOrEmpty(CantidadTextBox.Text))
            {
                GruposErrorProvider.SetError(CantidadTextBox,
                    "Debe ingresar una Cantidad");
                Error = true;
            }
            if (String.IsNullOrEmpty(GruposTextBox.Text))
            {
                GruposErrorProvider.SetError(GruposTextBox,
                    "Debe ingresar una Cantidad de Grupos");
                Error = true;
            }

            /*if (String.IsNullOrEmpty(IntegrantesTextBox.Text))
            {
                GruposErrorProvider.SetError(IntegrantesTextBox,
                    "Debe ingresar los Integrantes del Grupo");
                Error = true;
            }*/
            return Error;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDNumericUpDown.Value);
            Grupos grupos = BLL.GrupoBLL.Buscar(id);
            if (grupos != null)
            {
                IDNumericUpDown.Value = grupos.GruposId;
                DescripcionTextBox.Text = grupos.Descripcion;
                FechaDateTimePicker.Value = grupos.Fecha;
                CantidadTextBox.Text = grupos.Cantidad.ToString();
                GruposTextBox.Text = grupos.Gruposs.ToString();
                IntegrantesTextBox.Text = grupos.Integrantes.ToString();
            }
            else
                MessageBox.Show("No se encontro", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
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

            if (IDNumericUpDown.Value == 0)
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

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            IDNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
            CantidadTextBox.Clear();
            GruposTextBox.Clear();
            IntegrantesTextBox.Clear();
            GruposErrorProvider.Clear();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IDNumericUpDown.Value);

            if (BLL.GrupoBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se elimino", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
