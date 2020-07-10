using System.Web;
using System.Web.Optimization;

namespace CSWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region Template Design
            bundles.Add(new StyleBundle("~/template/js").Include(
                      "~/Scripts/vendor/modernizr-3.5.0.min.js",
                      "~/Scripts/vendor/jquery-1.12.4.min.js",
                      "~/Scripts/popper.min.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/owl.carousel.min.js",
                      "~/Scripts/isotope.pkgd.min.js",
                      "~/Scripts/ajax-form.js",
                      "~/Scripts/waypoints.min.js",
                      "~/Scripts/jquery.counterup.min.js",
                      "~/Scripts/scrollIt.js",
                      "~/Scripts/jquery.scrollUp.min.js",
                      "~/Scripts/wow.min.js",
                      "~/Scripts/nice-select.min.js",
                      "~/Scripts/jquery.slicknav.min.js",
                      "~/Scripts/jquery.magnific-popup.min.js",
                      "~/Scripts/plugins.js",
                      "~/Scripts/gijgo.min.js",
                      "~/Scripts/contact.js",
                      "~/Scripts/jquery.ajaxchimp.min.js",
                      "~/Scripts/jquery.form.js",
                      "~/Scripts/jquery.validate.min.js",
                      "~/Scripts/mail-script.js",
                      "~/Scripts/main.js"));

            bundles.Add(new StyleBundle("~/template/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/owl.carousel.min.css",
                      "~/Content/css/magnific-popup.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/themify-icons.css",
                      "~/Content/css/nice-select.css",
                      "~/Content/css/flaticon.css",
                      "~/Content/css/gijgo.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/slicknav.css",
                      "~/Content/css/style.css"));

            #endregion
        }
    }
}
