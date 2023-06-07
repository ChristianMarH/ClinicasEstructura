using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OT.Ternium.NVA.EstructuraClinicas.Models.General
{
    public class Combo
    {
        [DefaultValue(-1)]
        [Display(Name = "Identificador")]
        public int Identificador { get; set; }

        [MinLength(3)]
        [Display(Name = "Descripción1")]
        public string Descripcion1 { get; set; }

        [MinLength(3)]
        [Display(Name = "Descripción2")]
        public string Descripcion2 { get; set; }

        public Combo()
        {
            this.Identificador = -1;
            this.Descripcion1 = string.Empty;
            this.Descripcion2 = string.Empty;
        }

        public Combo(int Identificador, string Descripcion1, string Descripcion2)
        {
            this.Identificador = Identificador;
            this.Descripcion1 = Descripcion1;
            this.Descripcion2 = Descripcion2;
        }
    }
}