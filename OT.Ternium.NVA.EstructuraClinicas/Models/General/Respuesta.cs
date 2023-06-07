using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OT.Ternium.NVA.EstructuraClinicas.Models.General
{
    public class Respuesta
    {
        [DefaultValue(false)]
        [Display(Name = "IsError")]
        public bool Error { get; set; }

        [DefaultValue(-1)]
        [Display(Name = "ErrorId")]
        public int ErrorId { get; set; }

        [MinLength(3)]
        [Display(Name = "ErrorMessage")]
        public string ErrorMessage { get; set; }

        [DefaultValue(-1)]
        [Display(Name = "Identificador")]
        public int Identificador { get; set; }

        public Respuesta()
        {
            this.Error = false;
            this.ErrorId = -1;
            this.ErrorMessage = string.Empty;
            this.Identificador = -1;
        }

        public Respuesta(bool Error, int ErrorId, string ErrorMessage, int Identificador)
        {
            this.Error = Error;
            this.ErrorId = ErrorId;
            this.ErrorMessage = ErrorMessage;
            this.Identificador = Identificador;
        }
    }
}