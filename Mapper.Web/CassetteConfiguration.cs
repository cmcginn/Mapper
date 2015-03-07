using Cassette;
using Cassette.Scripts;
using Cassette.Stylesheets;

namespace Mapper.Web
{
    /// <summary>
    /// Configures the Cassette asset bundles for the web application.
    /// </summary>
    public class CassetteBundleConfiguration : IConfiguration<BundleCollection>
    {
        public void Configure(BundleCollection bundles)
        {
            // TODO: Configure your bundles here...
            // Please read http://getcassette.net/documentation/configuration

            // This default configuration treats each file as a separate 'bundle'.
            // In production the content will be minified, but the files are not combined.
            // So you probably want to tweak these defaults!
            //bundles.AddPerIndividualFile<StylesheetBundle>("Content");
            //bundles.AddPerIndividualFile<ScriptBundle>("Scripts");

            // To combine files, try something like this instead:
            //   bundles.Add<StylesheetBundle>("Content");
            // In production mode, all of ~/Content will be combined into a single bundle.
            
            // If you want a bundle per folder, try this:
            //   bundles.AddPerSubDirectory<ScriptBundle>("Scripts");
            // Each immediate sub-directory of ~/Scripts will be combined into its own bundle.
            // This is useful when there are lots of scripts for different areas of the website.
            bundles.Add<ScriptBundle>("modernizr", new[] { "~/Scripts/modernizr-2.6.2.js" });
            bundles.Add<ScriptBundle>("jquery", new[] { "~/Scripts/jquery-1.10.2.js" });
            bundles.Add<ScriptBundle>("bootstrap", new[] { "~/Scripts/bootstrap.js" });
            // Stylesheets
            bundles.Add<StylesheetBundle>("jquery", new[] { "~/Content/themes/base/all.css" });
            bundles.Add<StylesheetBundle>("bootstrap", new[] { "~/Content/bootstrap.css" });
            bundles.Add<StylesheetBundle>("common", new[] { "~/Content/Site.css" });
        }
    }
}