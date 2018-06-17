using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimerParcial.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimerParcial.Entidades;
namespace PrimerParcial.BLL.Tests
{
    [TestClass()]
    public class GrupoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Grupos grupos = new Grupos();
            grupos.GruposId = 0;
            grupos.Fecha = DateTime.Now;
            grupos.Descripcion = "Soy yo Anthony";
            grupos.Cantidad = 50;
            grupos.Gruposs = 5;
            grupos.Integrantes = 10;
            paso = GrupoBLL.Guardar(grupos);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            int idGrupos = GrupoBLL.GetList(x => true)[0].GruposId;

            Grupos grupos = GrupoBLL.Buscar(idGrupos);

            grupos.Detalle.Add(new GrupoDetalle(0, grupos.GruposId, 2, 4));

            bool paso = GrupoBLL.Modificar(grupos);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}