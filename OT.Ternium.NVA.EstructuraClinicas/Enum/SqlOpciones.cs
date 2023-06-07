using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OT.Ternium.NVA.EstructuraClinicas.Enum
{
    public enum SqlOpciones
    {
        #region OPCIONES DE CONSULTA
        ConsultaPorId = 1,
        ConsultaGeneral = 2,
        Lista = 3,
        #endregion

        #region OPCIONES DE INSERTAR
        Insertar = 1,
        #endregion

        #region OPCIONES DE ACTUALIZAR
        Actualizar = 1,
        BajaLogica = 2
        #endregion
    }
}