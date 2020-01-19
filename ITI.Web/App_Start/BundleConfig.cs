using System.Web;
using System.Web.Optimization;

namespace ITI.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
                        //"~/bower_components/jquery/dist/jquery.min.js",
                        //"~/bower_components/jquery-ui/jquery-ui.min.js",
                        //"~/bower_components/bootstrap/dist/js/bootstrap.min.js",
                        //"~/bower_components/raphael/raphael.min.js",
                        //"~/bower_components/morris.js/morris.min.js",
                        //"~/bower_components/jquery-sparkline/dist/jquery.sparkline.min.js",
                        //"~/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                        //"~/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                        //"~/bower_components/jquery-knob/dist/jquery.knob.min.js",
                        //"~/bower_components/moment/min/moment.min.js",
                        //"~/bower_components/bootstrap-daterangepicker/daterangepicker.js",
                        //"~/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                        //"~/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                        //"~/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                        //"~/bower_components/fastclick/lib/fastclick.js",
                        //"~/dist/js/adminlte.min.js", "~/dist/js/pages/dashboard.js", "~/dist/js/demo.js"
                         
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                     "~/js/jquery-3.3.1.min.js",
                     "~/js/jquery-migrate-3.0.1.min.js",
                     "~/js/jquery-ui.js",
                     "~/js/popper.min.js",
                     "~/js/bootstrap.min.js",
                     "~/js/owl.carousel.min.js",
                     "~/js/jquery.stellar.min.js",
                     "~/js/jquery.countdown.min.js",
                     "~/js/bootstrap-datepicker.min.js",
                     "~/js/jquery.easing.1.3.js",
                     "~/js/aos.js",
                     "~/js/jquery.fancybox.min.js",
                     "~/js/jquery.sticky.js",
                     "~/js/jquery.mb.YTPlayer.min.js",
                     "~/js/main.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/adminjquery").Include(
                       //"~/Scripts/jquery-{version}.js"
                       "~/Scripts/raphael/raphael.min.js",
                       "~/Scripts/bootstrap.min.js",
                        "~/Content/morris.js/morris.min.js",
                        "~/Scripts/jquery-sparkline/dist/jquery.sparkline.min.js",
                        "~/Scripts/jvectormap/jquery-jvectormap-1.2.2.min.js",
                        "~/Scripts/jvectormap/jquery-jvectormap-world-mill-en.js",
                        "~/Scripts/jquery-knob/dist/jquery.knob.min.js",
                        "~/Scripts/moment/min/moment.min.js",
                        "~/Content/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                        "~/Content/bootstrap-daterangepicker/daterangepicker.js",
                        "~/Content/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                        "~/Scripts/jquery-slimscroll/jquery.slimscroll.min.js",
                        "~/Scripts/fastclick/lib/fastclick.js",
                        "~/Scripts/js/adminlte.min.js",
                        "~/Scripts/js/demo.js",
                        "~/Scripts/js/pages/dashboard.js"
                       ));

            //            < script >
            //  $.widget.bridge('uibutton', $.ui.button);
            //</ script >

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
          "~/Scripts/jquery.validate.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/fonts").Include(
                       "~/fonts/flaticon/",
                       "~/fonts/icomoon/"
                ));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/gallery").Include(
                     "~/Scripts/lightboxgallery-min.js")); 

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap/dist/css/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/font-awesome/css/font-awesome.min.css"));
                        //"~/bower_components/font-awesome/css/font-awesome.min.css",
                        //"~/bower_components/Ionicons/css/ionicons.min.css",
                        //"~/dist/css/skins/_all-skins.min.css",
                        //"~/bower_components/morris.js/morris.css",
                        //"~/bower_components/jvectormap/jquery-jvectormap.css",
                        //"~/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css"  

            bundles.Add(new StyleBundle("~/bundles/scss").Include(
                "~/scss/_site-base.scss",
                "~/scss/_site-blocks.scss",
                "~/scss/_site-navbar.scss",
                "~/scss/style.scss",
                "~/scss/bootstrap/"
                ));

            bundles.Add(new StyleBundle("~/bundles/csss").Include(
                 "~/css/bootstrap/", 
                 "~/css/bootstrap-datepicker.css",
                 "~/css/bootstrap.min.css",
                 "~/css/bootstrap.min.css.map",
                 "~/css/jquery-ui.css",
                 "~/css/jquery.mb.YTPlayer.min.css",
                 "~/css/jquery.fancybox.min.css",
                 "~/css/magnific-popup.css",
                 "~/css/mediaelementplayer.css",
                 "~/css/owl.carousel.min.css",
                 "~/css/owl.theme.default.min.css",
                 "~/css/style.css",
                 "~/css/lightboxgallery-min.css"
                    ));
            bundles.Add(new StyleBundle("~/Content/admin").Include(
                        "~/Content/bootstrap.min.css",
                        "~/Content/font-awesome/css/font-awesome.min.css",
                        "~/Content/Ionicons/css/ionicons.min.css",
                        "~/Content/css/AdminLTE.min.css",
                        "~/Content/css/skins/_all-skins.min.css",
                        "~/Content/jvectormap/jquery-jvectormap.css",
                        "~/Content/morris.js/morris.css",
                        "~/Content/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                        "~/Content/bootstrap-daterangepicker/daterangepicker.css",
                        "~/Content/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css"
                ));

            BundleTable.EnableOptimizations = true;
        }
    }
}
