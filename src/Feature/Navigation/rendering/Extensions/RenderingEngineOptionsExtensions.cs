using Music10.Feature.Navigation.Models;
using Sitecore.AspNet.RenderingEngine.Configuration;
using Sitecore.AspNet.RenderingEngine.Extensions;

namespace Music10.Feature.Navigation.Extensions
{
    public static class RenderingEngineOptionsExtensions
    {
        public static RenderingEngineOptions AddFeatureNavigation(this RenderingEngineOptions options)
        {
            options.AddModelBoundView<Header>("Header")
                   .AddModelBoundView<Footer>("Footer");
            return options;
        }
    }
}
