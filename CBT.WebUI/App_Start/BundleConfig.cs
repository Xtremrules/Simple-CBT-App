using System.Web.Optimization;

namespace CBT.WebUI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/*.css"));

            bundles.Add(new ScriptBundle("~/bundle/resource").Include(
                "~/Scripts/Resources/*.js"));

            bundles.Add(new ScriptBundle("~/bundle/AngularJS").Include(
                "~/Scripts/*.js"));

            bundles.Add(new ScriptBundle("~/bundle/CBTApp").Include(
                "~/Scripts/CBTApp/app.js",
                "~/Scripts/CBTApp/Controller/*.js"));
            //BundleTable.EnableOptimizations = true;
        }
    }
}