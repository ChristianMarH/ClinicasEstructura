using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OT.Ternium.NVA.EstructuraClinicas.Helper
{
    public static class Transform
    {
        public static IEnumerable<SelectListItem> ListItem(this IEnumerable<Models.General.ComboII> listM)
        {
            var _result = new List<SelectListItem>();
            _result.Add(new SelectListItem() { Selected = true, Text = "Seleccione...", Value = "-1" });
            if (listM != null && listM.Count() > 0) {
                _result = listM.Select(item => new SelectListItem() { Selected = item.Identificador == -1 ? true : false,
                    Text = item.Descripcion,
                    Value = item.Identificador.ToString() }).ToList();
            }
            return _result;
        }
        public static IEnumerable<SelectListItem> ListItem(this IEnumerable<Models.General.Combo> listM)
        {
            var _result = new List<SelectListItem>();
            _result.Add(new SelectListItem() { Selected = true, Text = "Seleccione...", Value = "-1" });
            if (listM != null && listM.Count() > 0)
            {
                _result = listM.Select(item => new SelectListItem()
                {
                    Selected = item.Identificador == -1 ? true : false,
                    Text = item.Descripcion2,
                    Value = item.Identificador.ToString()
                }).ToList();
            }
            return _result;
        }
    }
}