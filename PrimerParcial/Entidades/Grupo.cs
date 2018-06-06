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

            public Grupos()
            {
                GruposId = 0;
                Descripcion = string.Empty;
                Cantidad = 0;
                Fecha = DateTime.Now;
                Gruposs = 0;
                Integrantes = 0;

            }
        }
    }

