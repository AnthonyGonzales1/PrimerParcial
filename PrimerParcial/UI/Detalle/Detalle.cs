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
using PrimerParcial.DAL;
using PrimerParcial.UI.Registros;


namespace PrimerParcial.UI.Detalle
{
    public partial class Detalle : Form
    {
        public Detalle()
        {
            InitializeComponent();
            LlenarcomboBox();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdNumericUpDown.Value);
            Grupos grupos = BLL.GrupoBLL.Buscar(id);
            if (grupos != null)
            {
                LlenarCampos(grupos);
               
            }
            else
                MessageBox.Show("No se encontro", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            IdNumericUpDown.Value = 0;
            PersonasIdcomboBox.SelectedValue = 0;
            DetalledataGridView.DataSource = null;
            CargotextBox.Clear();
          
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            bool Paso = false;
            Grupos grupos;

            if (HayErrores())
            {
                MessageBox.Show("Revise todos los campos", "Validado",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grupos = LlenaClase();

            if (IdNumericUpDown.Value == 0)
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdNumericUpDown.Value);

            if (BLL.GrupoBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se elimino", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {

            List<GrupoDetalle> detalle = new List<GrupoDetalle>();

            if (DetalledataGridView.DataSource != null)
            {
                detalle = (List<GrupoDetalle>)DetalledataGridView.DataSource;
            }

            //Agregar un nuevo detalle con los datos introducidos.
            detalle.Add(
                new GrupoDetalle(
                    id: 0,
                    personaId: (int)PersonasIdcomboBox.SelectedValue,
                    grupoId: (int)GruposIdnumericUpDown.Value,
                    cargo: (string)CargotextBox.Text
                ));

            //Cargar el detalle al Grid
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = detalle;
        }

        private void LlenarcomboBox()
        {
            Repositorio<Personas> repositorio = new Repositorio<Personas>(new Contexto());
            PersonasIdcomboBox.DataSource = repositorio.GetList(c => true);
            PersonasIdcomboBox.ValueMember = "Persona Id";
            PersonasIdcomboBox.DisplayMember = "Nombre";
        }
        private Grupos LlenaClase()
        {
            Grupos grupos = new Grupos();

            grupos.GruposId = Convert.ToInt32(IDNumericUpDown.Value);
            grupos.Descripcion = DescripcionTextBox.Text;
            grupos.Fecha = FechaDateTimePicker.Value;
            grupos.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            grupos.Gruposs = Convert.ToInt32(GruposTextBox.Text);

            //Agregar cada linea del Grid al detalle
            foreach (DataGridViewRow item in DetalledataGridView.Rows)
            {
                grupos.AgregarDetalle(
                    ToInt(item.Cells["Id"].Value),
                    ToInt(item.Cells["GruposId"].Value),
                    ToInt(item.Cells["PersonasId"].Value),
                    ToInt(item.Cells["Cantidad"].Value)
                  );
            }
            return grupos;
        }

        private void LlenarCampos(Grupos grupos)
        {
            IDNumericUpDown.Value = grupos.GruposId;
            FechaDateTimePicker.Value = grupos.Fecha;
            CantidadTextBox.Text = grupos.Cantidad;
            GruposTextBox.Text = grupos.Gruposs;
            IntegrantesTextBox.Text = grupos.Integrantes;
            DescripcionTextBox.Text = grupos.Descripcion;
            
            DetalledataGridView.DataSource = grupos.Detalle;
            
            DetalledataGridView.Columns["Id"].Visible = false;
            DetalledataGridView.Columns["PersonaId"].Visible = false;
        }

        private bool HayErrores()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                errorProvider.SetError(DescripcionTextBox,
                    "No debes dejar el Comentario vacio");
                HayErrores = true;
            }

            if (DetalledataGridView.RowCount == 0)
            {
                errorProvider.SetError(DetalledataGridView,
                    "Es obligatorio seleccionar las ciudades visitadas");
                HayErrores = true;
            }

            return HayErrores;
        }
    }
}
