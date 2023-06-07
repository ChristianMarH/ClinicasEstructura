using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OT.Ternium.NVA.EstructuraClinicas.Models.General
{
    public class ConsultaSesionSelect
    {
        public string vcFecha { get; set; }
        public string vcUsuarioRed { get; set; }
        public Nullable<int> IdPersonal { get; set; }
        public string vcPersonal { get; set; }
        public Nullable<decimal> IdNumeroSocio { get; set; }
        public string vcNombreAfiliado { get; set; }
        public string vcFullNumeroSocio { get; set; }
        public Nullable<decimal> IdExpedienteMedico { get; set; }
        public Nullable<decimal> IdNotaMedica { get; set; }
        public Nullable<decimal> IdNotaEnfermeria { get; set; }
        public Nullable<decimal> IdIngresoHospital { get; set; }
        public string IdArea { get; set; }
        public string vcArea { get; set; }
        public decimal IdAgendaCita { get; set; }
        public Nullable<decimal> IdIngresoPaciente { get; set; }
        public int bActivo { get; set; }
        public string vcMensaje { get; set; }
    }
}