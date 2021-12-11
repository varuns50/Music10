using Music10.Feature.Services.Models;
using Sitecore.AspNet.RenderingEngine.Configuration;
using Sitecore.AspNet.RenderingEngine.Extensions;

namespace Music10.Feature.Products.Extensions
{
    public static class RenderingEngineOptionsExtensions
    {
        public static RenderingEngineOptions AddFeatureServices(this RenderingEngineOptions options)
        {
            options
                .AddPartialView("TestimonialContainer")
                .AddModelBoundView<Testimonial>("Testimonial");
            return options;
        }
    }
}
