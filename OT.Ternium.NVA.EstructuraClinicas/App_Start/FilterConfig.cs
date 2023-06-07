using System.Web;
using System.Web.Mvc;

namespace OT.Ternium.NVA.EstructuraClinicas
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
