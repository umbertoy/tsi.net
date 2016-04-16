using System.Web;
using System.Web.Optimization;

namespace PresentationLayerWeb
{
    public class BundleConfig
    {
        // Para obtener más información sobre Bundles, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/signalR").Include(
                        "~/Scripts/jquery.signalR-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // preparado para la producción y podrá utilizar la herramienta de compilación disponible en http://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css", "~/Content/themes/base/theme.css"));
            bundles.Add(new ScriptBundle("~/Script/Angular").Include(
                "~/Scripts/angular.min.js",
                "~/Scripts/angular-route.min.js",
                "~/Scripts/angular-animate.min.js",
                "~/Scripts/angular-touch.min.js",
                "~/Scripts/Employees/ui-grid/ui-grid.js",
                "~/Scripts/Employees/SPA/employees/employee.module.js",
                "~/Scripts/Employees/SPA/employees/services/employees.service.js",
                "~/Scripts/Employees/SPA/employees/controllers/employee.controller.js",
                "~/Scripts/Employees/SPA/app.js"
                ));
            bundles.Add(new StyleBundle("~/Content/Angular").Include(
                    "~/Content/Angular/style.css",
                    "~/Content/Angular/ui-grid.min.css"));
        }

    }
}
