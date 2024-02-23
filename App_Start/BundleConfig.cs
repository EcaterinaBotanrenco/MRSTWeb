using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/localScripts").Include(
                "~/assets/lib/easing/easing.min.js",
                "~/assets/lib/waypoints/waypoints.min.js",
                "~/assets/lib/counterup/counterup.min.js",
                "~/assets/lib/owlcarousel/owl.carousel.min.js",
                "~/assets/lib/tempusdominus/js/moment.min.js",
                "~/assets/lib/tempusdominus/js/moment-timezone.min.js",
                "~/assets/lib/tempusdominus/js/tempusdominus-bootstrap-4.min.js",
                "~/assets/mail/jqBootstrapValidation.min.js",
                "~/assets/mail/contact.js",
                "~/assets/js/main.js"));

            // Style bundle
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.min.css",
                        "~/assets/lib/animate/animate.min.css",
                        "~/assets/lib/owlcarousel/assets/owl.carousel.min.css",
                        "~/assets/lib/tempusdominus/css/tempusdominus-bootstrap-4.min.css",
                        "~/assets/css/style.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
