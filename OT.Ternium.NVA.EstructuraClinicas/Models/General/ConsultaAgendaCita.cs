using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OT.Ternium.NVA.EstructuraClinicas.Models.General
{
    public class ConsultaAgendaCita
    {
        public Nullable<int> IdAgendaCita { get; set; }
        public Nullable<int> IdNumeroSocio { get; set; }
        public string NumeroSocio { get; set; }
        public string vcNombreSocio { get; set; }
        public Nullable<int> IdMedico { get; set; }
        public string vcCodigoMedico { get; set; }
        public string vNombreMedico { get; set; }
        public string dtFecha { get; set; }
        public string dtHora { get; set; }
        public Nullable<int> iBloque { get; set; }
        public Nullable<int> iNumeroBloques { get; set; }
        public Nullable<int> bCitaExtra { get; set; }
        public string vcCitaEtra { get; set; }
        public string dtFechaCitaExtra { get; set; }
        public string dtHoraCitaExtra { get; set; }
        public Nullable<int> idEstatusCita { get; set; }
        public string vcEstatusCita { get; set; }
        public string dtFechaCancelacion { get; set; }
        public string dtFechaTerminaAtencion { get; set; }
        public string dtHoraCancelacion { get; set; }
        public Nullable<int> IdUsuarioCancela { get; set; }
        public string vcNombreUsuarioCancela { get; set; }
        public string vcNombreCancela { get; set; }
        public Nullable<int> IdParentescoCancela { get; set; }
        public string vcParentesco { get; set; }
        public string vcComentariosCancela { get; set; }
        public Nullable<int> IdEspecialidad { get; set; }
        public Nullable<int> IdUsuarioRegistra { get; set; }
        public string vcNombreUsuarioRegistra { get; set; }
        public string dtFechaRegistro { get; set; }
        public Nullable<int> IdMotivoCancelacion { get; set; }
        public string vcMotivoCancelacion { get; set; }
        public Nullable<int> IdConsultorio { get; set; }
        public string vcConsultorio { get; set; }
        public Nullable<int> IdUsuarioAsistencia { get; set; }
        public string vcNombreUsuarioVerifico { get; set; }
        public string dtRegistroAsistencia { get; set; }
        public Nullable<int> IdClasificacionAfiliado { get; set; }
        public string vcClasificacionAfiliado { get; set; }
        public string vctipoAfiliado { get; set; }
        public int idTipoCita { get; set; }
        public int bTiempoFuera { get; set; }
        public int bMostrarRiesgoCaida { get; set; }
        public int bNotaValoracionPreanestesica { get; set; }
    }
}