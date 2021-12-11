using Sitecore.Data.Items;

namespace Music10.Feature.Navigation.Services
{
    public interface INavigationRootResolver
    {
        Item GetNavigationRoot(Item contextItem);
    }
}
