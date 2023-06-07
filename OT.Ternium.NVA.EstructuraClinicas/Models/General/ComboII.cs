using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OT.Ternium.NVA.EstructuraClinicas.Models.General
{
    public class ComboII
    {
        [DefaultValue(-1)]
        [Display(Name = "Identificador")]
        public int Identificador { get; set; }

        [MinLength(3)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        

        public ComboII()
        {
            this.Identificador = -1;
            this.Descripcion = string.Empty;
        }

        public ComboII(int Identificador, string Descripcion )
        {
            this.Identificador = Identificador;
            this.Descripcion = Descripcion;
        }
    }
}