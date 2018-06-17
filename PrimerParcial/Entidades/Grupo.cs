using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Entidades
{
   
        public class Grupos
        {
            [Key]
            public int GruposId { get; set; }

            public string Descripcion { get; set; }

            public float Cantidad { get; set; }

            public DateTime Fecha { get; set; }

            public float Gruposs { get; set; }
            
            public float Integrantes { get; set; }
            
            public virtual ICollection<GrupoDetalle> Detalle { get; set; }
            
            public Grupos()
            {
                this.Detalle = new List<GrupoDetalle>();
            }

        public void AgregarDetalle(int id, int grupoId, int personaId, string cargo)
        {
            this.Detalle.Add(new GrupoDetalle(id, grupoId, personaId, cargo));
        }

        }
    }

