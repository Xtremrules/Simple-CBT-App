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

            //BundleTable.EnableOptimizations = true;
        }
    }
}