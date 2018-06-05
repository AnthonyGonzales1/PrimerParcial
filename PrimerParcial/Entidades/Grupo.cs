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

            public int Cantidad { get; set; }

            public DateTime Fecha { get; set; }

            public string Gruposs { get; set; }

            public string Integrantes { get; set; }

            public Grupos()
            {
                GruposId = 0;
                Descripcion = string.Empty;
                Cantidad = 0;
                Fecha = DateTime.Now;
                Gruposs = string.Empty;
                Integrantes = string.Empty;

            }
        }
    }

