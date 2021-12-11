using Music10.Feature.Navigation.Models;
using Sitecore.Data.Items;

namespace Music10.Feature.Navigation.Services
{
    public interface IHeaderBuilder
    {
        Header GetHeader(Item contextItem);
    }
}
