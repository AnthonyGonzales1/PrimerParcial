using PrimerParcial.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace PrimerParcial.UI.Consultas
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void BuscarConsultabutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Grupos, bool>> filtro = x => true;

            int id;
            switch (FiltrocomboBox.SelectedIndex)
            {
                case 0:
                    id = Convert.ToInt32(CriteriocomboBox.Text);
                    filtro = x => x.GruposId == id;
                    break;
                case 1:
                    filtro = x => x.Descripcion.Contains(CriteriocomboBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;
                case 2:
                    filtro = x => x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;
                case 3:
                    filtro = x => x.Gruposs.Equals(CriteriocomboBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;
                case 4:
                    filtro = x => x.Cantidad.Equals(CriteriocomboBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;
                case 5:
                    filtro = x => x.Integrantes.Equals(CriteriocomboBox.Text) && x.Fecha >= DesdedateTimePicker.Value && x.Fecha <= HastadateTimePicker.Value;
                    break;
            }
            ConsultadataGridView.DataSource = BLL.GrupoBLL.GetList(filtro);
        }
               
        private void FiltrocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltrocomboBox.SelectedIndex == 2)
                CriteriocomboBox.Enabled = false;
            else
                CriteriocomboBox.Enabled = true;

        }
    }
}
