using System.Web;
using System.Web.Optimization;

namespace apiTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/Students").Include(
                      "~/Scripts/Student.js/Students.js"));

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
                "~/Scripts/Student.js/dataTables.bootstrap4.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryDataTables").Include(
                "~/Scripts/Student.js/jquery.dataTables.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-3.5.1").Include(
                "~/Scripts/Student.js/jquery-3.5.1.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


        }
    }
}
