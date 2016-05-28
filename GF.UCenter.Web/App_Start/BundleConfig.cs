﻿namespace GF.UCenter.Web
{
    using System.Web.Optimization;

    /// <summary>
    ///     Bundle configuration
    /// </summary>
    public class BundleConfig
    {
        /// <summary>
        ///     Register bundles
        ///     For more information on bundling, visit<see cref="http://go.microsoft.com/fwlink/?LinkId=301862" />
        /// </summary>
        /// <param name="bundles">The bundle collection</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/moment").Include(
                "~/Scripts/moment.js"));

            bundles.Add(new ScriptBundle("~/bundles/react").Include(
                "~/Scripts/react/react.js",
                "~/Scripts/react/react-dom.js",
                "~/Scripts/react-bootstrap-table.js",
                "~/Scripts/react/browser.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css",
                "~/Content/react-bootstrap-table-all.min.css"));
        }
    }
}