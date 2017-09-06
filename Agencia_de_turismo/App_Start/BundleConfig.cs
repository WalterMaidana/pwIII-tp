using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Agencia_de_turismo.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundle/js_externo/javascript").Include(
                      "~/js/js_externo/jquery-1.11.3.min.js",
                      "~/js/js_externo/jquery-ui.min.js",
                      "~/js/js_externo/npm.js"));

            bundles.Add(new StyleBundle("~/bundle/estilos").Include(
                  "~/css/bootstrap-theme.css",
                  "~/css/bootstrap-theme.css.map",
                  "~/css/bootstrap-theme.min.css",
                  "~/css/bootstrap-theme.min.css.map",
                  "~/css/bootstrap.css",
                  "~/css/bootstrap.css.map",
                  "~/css/bootstrap.min.css",
                  "~/css/bootstrap.min.css.map",
                  "~/css/creative.css",
                  "~/css/jquery.ui.min.css"));
        }
    }
}