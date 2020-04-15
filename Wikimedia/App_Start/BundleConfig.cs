﻿using System.Web.Optimization;

namespace Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;
            bundles.UseCdn = true;

            // Scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery", "https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval", "https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.19.1/jquery.validate.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval", "https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.11/jquery.validate.unobtrusive.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/modernizr", "https://cdnjs.cloudflare.com/ajax/libs/modernizr/2.8.3/modernizr.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/popper", "https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap", "https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"));

            // Styles
            bundles.Add(new StyleBundle("~/Content/bootstrap", "https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/font-awesome", "https://use.fontawesome.com/releases/v5.13.0/css/all.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/Site.css"));
        }
    }
}
