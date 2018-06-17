using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace PrimerParcial.Entidades
{
    public class GrupoDetalle
    {
        [Key]
        public int Id { get; set; }

        public int GrupoId { get; set; }

        public int PersonaId{ get; set; }

        public string Cargo { get; set; }
        

        [ForeignKey("GruposId")]
        public virtual Personas Persona { get; set; }

        public GrupoDetalle(int id)
        {
            this.Id = 0;
            this.GrupoId = 0;

        }

        public GrupoDetalle(int id, int grupoId, int personaId, string cargo) {

            this.Id = id;
            this.GrupoId = grupoId;
            this.PersonaId = personaId;
            this.Cargo = cargo;
            
        }
    }
}
