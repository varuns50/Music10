using Music10.Feature.BasicContent.Models;
using Sitecore.AspNet.RenderingEngine.Configuration;
using Sitecore.AspNet.RenderingEngine.Extensions;

namespace Music10.Feature.BasicContent.Extensions
{
    public static class RenderingEngineOptionsExtensions
    {
        public static RenderingEngineOptions AddFeatureBasicContent(this RenderingEngineOptions options)
        {
            options
                .AddModelBoundView<PromoCard>("PromoCard")
                .AddPartialView("PromoContainer")
                .AddModelBoundView<SectionHeader>("SectionHeader")
                .AddModelBoundView<HeroBanner>("HeroBanner")
                .AddPartialView("Accordion")
                .AddModelBoundView<AccordionItem>("AccordionItem");
            return options;
        }
    }
}
