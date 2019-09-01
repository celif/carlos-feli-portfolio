using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace BundleConfig
{
    public class BundleClass
    {
        public static int RegisterBundles(BundleCollection bundles)
        {
            // Add 5 bundles
            bundles.Add(new ScriptBundle("~/wwwroot/js").Include(
                        "~/wwwroot/js/jquery-3.3.1.slim.min.js"));

            bundles.Add(new ScriptBundle("./wwwroot/js").Include(
                        "~/wwwroot/js/popper.min.js"));

            bundles.Add(new ScriptBundle("./wwwroot/js").Include(
                        "~/wwwroot/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("./wwwroot/css").Include(
                      "~/wwwroot/css/site.css"));

            bundles.Add(new StyleBundle("./wwwroot/css").Include(
                      "~/wwwroot/css/bootstrap.min.css"));


            return bundles.Count;
        }
    }
}