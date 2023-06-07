using OT.Ternium.Framework.Utils;
using OT.Ternium.NVA.EstructuraClinicas.Helper;
using OT.Ternium.NVA.EstructuraClinicas.Models.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace OT.Ternium.NVA.EstructuraClinicas.Repository
{
    public class GeneralRepository
    { /// <summary>
      /// Obtener Id del usuario loggeado a partir de vcUsuarioRed
      /// </summary>
      /// <param name="parameters"></param>
      /// <returns></returns>
        public ConsultaPersonalLogin ConsultaUsuarioLogin(object[] parameters)
        {
            DataSet ds = DataAccessHelper.ExecuteDataSet("SQL-NOVA-SRV-MDW", "[NotaMedica].[spCatPersonalNM_ByLogin]", parameters);
            return ds.Tables[0].ToEntity<ConsultaPersonalLogin>();
        }

        /// <summary>
        /// Metodo para realizar consultas al SP spCldCatDatoCatalogoNM_Combo
        /// Donde se consultan los catálogos
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<ComboII> ConsultaCatalogos(object[] parameters)
        {
            DataSet ds = DataAccessHelper.ExecuteDataSet("SQL-NOVA-SRV-MDW", "[NotaMedica].[spCldCatDatoCatalogoNM_Combo]", parameters);
            return ds.Tables[0].ToList<ComboII>();
        }

        /// <summary>
        /// Metodo para realizar consultas al SP spCatParentesco_Combo
        /// Donde se consultan los catálogos
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public IEnumerable<ComboII> ConsultaCatalogo()
        {
            DataSet ds = DataAccessHelper.ExecuteDataSet("SQL-NOVA-SRV-MDW", "[dbo].[spCatDiagnostico_Combo]");
            return ds.Tables[0].ToList<ComboII>();
        }
    }
}