using Sitecore.LayoutService.Client.Response.Model.Fields;

namespace Music10.Feature.Services.Models
{
    public class Testimonial
    {
        public TextField Title { get; set; }

        public RichTextField Quote { get; set; }

        public ImageField Image { get; set; }
    }
}
