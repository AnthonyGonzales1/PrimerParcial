using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimerParcial.BLL;
using PrimerParcial.Entidades;
using System.Data.Entity;

namespace PrimerParcial.DAL
{
        public class Contexto : System.Data.Entity.DbContext
    {
            public DbSet<Grupos> Grupo { get; set; }

            public Contexto() : base("ConStr")
            {

            }
        }
}

