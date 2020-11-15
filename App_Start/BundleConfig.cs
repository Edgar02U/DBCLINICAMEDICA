using System.Web;
using System.Web.Optimization;

namespace WebClinicaMedica
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            //Bundle de estilos para _layout.cshtml
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      // configuracion de la fuente
                      "~/Content/setupfont.css",
                      // Bootstrap 3.3.7 (instado desde NuGet)
                      "~/Content/bootstrap.min.css",
                      // FontAwesome 4.7.0 (instado desde NuGet)
                      "~/Content/font-awesome.min.css",
                      // Estilo del tema
                      "~/dist/css/AdminLTE.min.css",
                      // AdminLTE Skins. Se ha escogido del folder css/skins el tema azul
                      "~/dist/css/skins/skin-blue.min.css",
                      // Ionicons 2.0.1
                      "~/plugins/ionicons/css/ionicons.min.css",
                      // checkbox
                      //"~/Content/iCheck/square/blue.css",
                      //"~/Content/iCheck/flat/blue.css",
                      "~/plugins/iCheck/skins/all.css",
                      "~/Content/jquery-confirm.min.css",
                      "~/Content/chosen.css",
                      // DataTables JQuery
                      //"~/Content/datatables/jquery.dataTables.min.css",
                      "~/Content/datatables/buttons.dataTables.min.css",
                      "~/Content/datatables/font-awesome.min.css",
                      "~/Content/datatables/keyTable.bootstrap.min.css",
                      "~/Content/datatables/select.dataTables.min.css",
                      // JQuery-UI 1.12.1
                      "~/Content/jquery-ui.css",
                      // Panel 
                      "~/Content/panel.css",
                      // TimePicker
                      "~/Content/jquery.timepicker.min.css",
                      // FileInput
                      "~/Scripts/plugins/fileinput/css/fileinput.min.css",
                      // Panel 
                      "~/Content/EstilosComponentes.css",
                      //Toastr(Alertas en tiras)
                      "~/Content/toastr.css",
                       "~/Content/dataTables.bootstrap4.min.css",
                       "~/Content/styleDatatableTH.css"
                      ));

            //Bundle de scripts para _layout.cshtml
            bundles.Add(new ScriptBundle("~/bundles/base").Include(
                      // jQuery 3.1.1 (instalado desde NuGet)
                      "~/Scripts/jquery-{version}.js",
                      // jQuery UI 1.12.1 (instalado desde NuGet)
                      "~/Scripts/jquery-ui-{version}.js",
                      // Bootstrap 3.3.7 JS (instalado desde NuGet)
                      "~/Scripts/bootstrap.min.js",
                      // Slimscroll
                      "~/plugins/slimScroll/jquery.slimscroll.min.js",
                      // FastClick
                      "~/plugins/fastclick/fastclick.min.js",
                      // iCheck (instalado desde NuGet)
                      "~/Scripts/jquery.icheck.js",
                      // AdminLTE App (menu deslizable)
                      "~/dist/js/app.min.js",
                      "~/Scripts/jquery-confirm.min.js",
                      // Funciones
                      "~/Scripts/funciones.js",
                      // Plugins
                      "~/Scripts/plugins/flot/jquery.flot.js",
                      "~/Scripts/plugins/flot/jquery.flot.resize.js",
                      "~/Scripts/plugins/flot/jquery.flot.pie.js",
                      "~/Scripts/plugins/flot/jquery.flot.categories.js",
                       "~/Scripts/plugins/flot/jquery.flot.stack.js",
                      //BlockUI
                      "~/plugins/jquery.blockUI.js"
                      ));

            //Bundle de scripts para _layout.cshtml
            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                      // jQuery 3.1.1 (instalado desde NuGet)
                      "~/Scripts/jquery-{version}.js",
                      // jQuery UI 1.12.1 (instalado desde NuGet)
                      "~/Scripts/jquery-ui-{version}.js",
                      // Bootstrap 3.3.7 JS (instalado desde NuGet)
                      "~/Scripts/bootstrap.min.js",
                      // Slimscroll
                      "~/plugins/slimScroll/jquery.slimscroll.min.js",
                      // FastClick
                      "~/plugins/fastclick/fastclick.min.js",
                      // iCheck (instalado desde NuGet)
                      //"~/Scripts/jquery.icheck.js",
                      "~/plugins/iCheck/icheck.js",
                      // AdminLTE App (menu deslizable)
                      "~/dist/js/app.min.js",
                      "~/Scripts/jquery-confirm.min.js",
                      "~/Scripts/chosen.jquery.js",
                      // DataTables JQuery
                      "~/Scripts/tabla_vista.js",
                      "~/Scripts/datatables/jquery.dataTables.min.js",
                      "~/Scripts/datatables/dataTables.buttons.min.js",
                      "~/Scripts/datatables/jszip.min.js",
                      "~/Scripts/datatables/pdfmake.min.js",
                      "~/Scripts/datatables/vfs_fonts.js",
                      "~/Scripts/datatables/buttons.html5.min.js",
                      "~/Scripts/datatables/dataTables.keyTable.min.js",
                      "~/Scripts/datatables/buttons.print.min.js",
                      "~/Scripts/datatables/dataTables.select.min.js",
                      // Datepicker ES
                      "~/Scripts/datepicker-es.js",
                      // Funciones
                      "~/Scripts/funciones.js",
                      // TimePicker
                      "~/Scripts/jquery.timepicker.min.js",
                      // FileInput
                      "~/Scripts/plugins/fileinput/js/fileinput.min.js",
                      "~/Scripts/plugins/fileinput/js/locales/es.js",
                      "~/Scripts/plugins/fileinput/themes/fa/theme.min.js",
                      "~/Scripts/plugins/fileinput/themes/gly/theme.min.js",
                      "~/Scripts/plugins/fileinput/js/plugins/purify.min.js",
                      "~/Scripts/plugins/fileinput/js/plugins/sortable.min.js",
                      //BlockUI
                      "~/plugins/jquery.blockUI.js",
                      //PartialView 
                      "~/Scripts/PartialView.js",
                      //funcionesAdicionales 
                      "~/Scripts/FuncionesReutilizables.js",
                      //Toastr(Alertas en tiras)
                      "~/Scripts/toastr.js",
                      //Crypto-js
                      "~/Scripts/CryptoJS-v3.1.2/rollups/aes.js",
                      //"~/Scripts/jquery.dataTables.min.js",
                      "~/Scripts/dataTables.bootstrap4.min.js",
                      "~/Scripts/buttons.bootstrap4.min.js"
                      ));
        }
    }
}
