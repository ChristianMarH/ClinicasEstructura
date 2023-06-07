
using System.Web;
using System.Web.Optimization;

namespace OT.Ternium.NVA.EstructuraClinicas
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.3.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/jquery.datatables.js",
                      "~/Scripts/bootstrap-select.min.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/bootstrap-datepicker.es.min.js",
                      "~/Scripts/bootstrap-clockpicker.js",
                      "~/Scripts/sweet-alert.js",
                      "~/Scripts/icheck.js",
                      "~/Scripts/jquery.blockUI.js",
                      "~/Scripts/tools.js",
                      "~/Scripts/jquery-ui.js",

                 "~/Scripts/select2.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.css",
                       "~/Content/datatables-bootstrap.css",
                       "~/Content/nova.css",
                             "~/Content/select2.min.css",
                       "~/Content/image-serialize.css",
                       "~/Content/bootstrap-select.min.css",
                       "~/Content/bootstrap-datepicker.css",
                       "~/Content/bootstrap-clockpicker.css",
                       "~/Content/sweet-alert.css",
                       "~/Content/jquery-ui.css",
                       "~/Content/square/yellow.css"
                       ));



            bundles.Add(new ScriptBundle("~/js/NotaMedica")
             .Include(
                 "~/Scripts/jquery-3.3.1.js",
                 "~/Scripts/select2.min.js",
               "~/Scripts/jquery.datatables.js",
               "~/Scripts/tools.js",
                "~/Scripts/NotaMedica/general.js",
               "~/Scripts/messages.js",
                 "~/Scripts/NotaDiabetes/NotaDiabetes.js"
              ));
        }
    }
}
