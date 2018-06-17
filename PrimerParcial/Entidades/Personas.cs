using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PrimerParcial.Entidades
{
    public class Personas
    {
        [Key]
        public int PersonaId { get; set; }
        public string Nombre { get; set; }

        public Personas()
        {

        }

        //Este truco permitira que se vea el nombre 
        //de la ciudad en el grid.
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
