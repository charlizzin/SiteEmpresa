﻿using System.Collections.Generic;
using System.Web;
using System.Web.Optimization;

namespace ProjetoSantana
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            var bundlesVal = new
                        ScriptBundle("~/bundles/jqueryval").Include(
                                    "~/Scripts/jquery.unobtrusive-ajax.js",
                                    "~/Scripts/jquery.validate.js",
                                    "~/Scripts/jquery.validate.unobtrusive.js",
                                    "~/Scripts/globalize.js",
                                    "~/Scripts/jquery.validate.globalize.js");
            bundlesVal.Orderer = new AsIsBundleOrderer();
            bundles.Add(bundlesVal);

            bundles.Add(new ScriptBundle("~/bundles/JqueryTable").Include(
            "~/Scripts/DataTables/jquery.dataTables.min.js",
            "~/Scripts/jquery-3.3.1.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/DataTables/css/jquery.dataTables.min.css"));

            bundles.Add(new ScriptBundle("~/Scripts/Sistema").Include(
                      "~/Scripts/Sistema/Sistema.js"));
        }
        public class AsIsBundleOrderer : IBundleOrderer
        {
            public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
            {
                return files;
            }
        }
    }
}
