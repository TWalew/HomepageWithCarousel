using System.Web;
using System.Web.Optimization;

namespace WebApplication5
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/Portal/Libraries").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Styles/Portal/Styles").Include(
                        "~/Styles/bootstrap/styles.css"));

        }
    }
}
