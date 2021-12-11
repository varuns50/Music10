using Sitecore.AspNet.RenderingEngine.Binding.Attributes;
using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace Music10.Feature.Products.Models
{
    public class ProductDetailHeader
    {
        public TextField Title { get; set; }

        public TextField ShortDescription { get; set; }
    }
}
